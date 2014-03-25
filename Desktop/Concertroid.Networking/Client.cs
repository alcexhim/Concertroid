using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

using UniversalEditor;
using UniversalEditor.IO;

using Concertroid.Networking.Requests;
using Concertroid.Networking.Responses;
using UniversalEditor.ObjectModels.Concertroid.Concert;

namespace Concertroid.Networking
{
	public class Client
	{
		private string mvarHostNameOrIPAddress = "localhost";
		public string HostNameOrIPAddress { get { return mvarHostNameOrIPAddress; } set { mvarHostNameOrIPAddress = value; } }

		private int mvarPortNumber = 3939;
		public int PortNumber { get { return mvarPortNumber; } set { mvarPortNumber = value; } }

		private Version mvarServerVersion = new Version();
		public Version ServerVersion { get { return mvarServerVersion; } }

        private string mvarServerName = String.Empty;
        public string ServerName { get { return mvarServerName; } }

		private Version mvarClientVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
		public Version ClientVersion { get { return mvarClientVersion; } set { mvarClientVersion = value; } }

		private BinaryReader mvarReader = null;
		public BinaryReader Reader { get { return mvarReader; } }

		private BinaryWriter mvarWriter = null;
        public BinaryWriter Writer { get { return mvarWriter; } }

        TcpClient mvarUnderlyingClient = null;
        public TcpClient UnderlyingClient { get { return mvarUnderlyingClient; } }

        public void Connect()
		{
			Connect(mvarHostNameOrIPAddress);
		}
        public void Connect(string HostNameOrIPAddress)
		{
			Connect(HostNameOrIPAddress, mvarPortNumber);
		}
		public void Connect(string HostNameOrIPAddress, int PortNumber)
		{
            if (mvarUnderlyingClient != null) throw new InvalidOperationException("Already connected");

            try
            {
                mvarHostNameOrIPAddress = HostNameOrIPAddress;
                mvarPortNumber = PortNumber;

                mvarUnderlyingClient = new TcpClient();
                mvarUnderlyingClient.Connect(mvarHostNameOrIPAddress, mvarPortNumber);

                NetworkStream ns = mvarUnderlyingClient.GetStream();

                mvarReader = new BinaryReader(ns);
                mvarWriter = new BinaryWriter(ns);

                // Present the initial Hello
                SendRequest(new IntroductionRequest(mvarClientVersion));
                Response resp = GetResponse();

                // Response should be a Hello back.
                if (resp is IntroductionResponse)
                {
                    IntroductionResponse ir = (resp as IntroductionResponse);
                    mvarServerVersion = ir.Version;
                    mvarServerName = ir.ServerName;
                }
                else
                {
                    throw new InvalidOperationException();
                }
            }
            catch (Exception ex)
            {
                mvarUnderlyingClient = null;
                throw ex;
            }
		}

        public void Disconnect()
        {
            if (mvarUnderlyingClient != null)
            {
                mvarUnderlyingClient.GetStream().Flush();
                mvarUnderlyingClient.GetStream().Close();
                mvarUnderlyingClient.Close();
            }
            mvarUnderlyingClient = null;
        }

        public readonly byte[] CONCERTROID_SIGNAL_CLIENT = new byte[] { 39, (byte)'C', (byte)'L', (byte)'I' };
        public readonly byte[] CONCERTROID_SIGNAL_SERVER = new byte[] { 39, (byte)'S', (byte)'V', (byte)'R' };

        #region Private API
        private void SendRequest(Request request)
        {
            BinaryWriter bw = mvarWriter;
            bw.Write(CONCERTROID_SIGNAL_CLIENT);

            if (request is IntroductionRequest)
            {
                IntroductionRequest ir = (request as IntroductionRequest);
                bw.Write((byte)1);
                bw.Write(ir.Version);
                bw.Flush();
            }
            else if (request is ParameterRequest)
            {
                ParameterRequest pr = (request as ParameterRequest);
                bw.Write((byte)3);
                bw.Write((byte)pr.Mode);
                bw.WriteNullTerminatedString(pr.ParameterName);
                if (pr.Mode == ParameterRequestMode.Set)
                {
                    bw.Write((byte)pr.DataType);
                    bw.WriteObject(pr.Value);
                }
            }
        }
        private Response GetResponse(Request request)
        {
            SendRequest(request);
            return GetResponse();
        }
        private Response GetResponse()
        {
            BinaryReader br = mvarReader;
            
            byte respID = br.ReadByte();
            switch (respID)
            {
                case 1: // hello
                {
                    int major = br.ReadInt32();
                    int minor = br.ReadInt32();
                    int build = br.ReadInt32();
                    int revision = br.ReadInt32();

                    string serverName = br.ReadNullTerminatedString();

                    Version version = new Version(major, minor, build, revision);
                    return new IntroductionResponse(version, serverName);
                }
                case 2: // general notification
                {
                    break;
                }
                case 3: // variable
                {
                    ParameterRequestMode mode = (ParameterRequestMode)br.ReadByte();
                    switch (mode)
                    {
                        case ParameterRequestMode.Get:
                        {
                            string parameterName = br.ReadNullTerminatedString();
                            DataType parameterType = (DataType)br.ReadByte();
                            object parameterValue = br.ReadObject(parameterType);
                            return new ParameterResponse(parameterName, parameterType, parameterValue);
                        }
                        case ParameterRequestMode.Set:
                        {
                            break;
                        }
                    }
                    break;
                }
            }
            return null;
        }
        #endregion


        #region Public API
        public object GetVariableValue(string VariableName)
        {
            ParameterResponse response = (GetResponse(new ParameterRequest(VariableName)) as ParameterResponse);
            if (response == null) throw new InvalidOperationException();
            return response.Value;
        }
        public void SetVariableValue(string VariableName, DataType VariableDataType, object VariableValue)
        {
            ParameterResponse response = (GetResponse(new ParameterRequest(VariableName, VariableDataType, VariableValue)) as ParameterResponse);
            if (response == null) throw new InvalidOperationException();
        }

        public void UpdateCharacter(string CharacterName, string SkinName, bool Visible, float OffsetX, float OffsetY, float OffsetZ)
        {
        }
        public void LoadConcert(ConcertObjectModel data)
        {
        }
        #endregion

        //  1 byte                  Concertroid Command Type
        //      if Type = 02            general notification
        //          1 byte                  notification type
        //                                      1 = ready, 2 = busy (timecode/etc. information follows), 3 = command successful, 4 = command error (additional error information follows)
        //      if Type = 03            operate on a variable
        //          1 byte                  operation (get = 1, set = 2)
        //          null-terminated string  name
        //          1 byte                  type
        //                                      1 = Boolean, Byte, Char, DateTime, Decimal, Double, Guid, Int16, Int32, Int64, SByte, Single, String, UInt16, UInt32, UInt64, Version, 255 = length-prefixed and type-prefixed variable array, 
        //                                      if 255, has an additional 4-byte unsigned int length parameter as well as another byte for the type of items in array.
        //          n byte(s)               value
        //      if Type = 10            update character
        //          null-terminated string  name
        //          null-terminated string  skin
        //          boolean                 visible?
        //          float                   offsetX
        //          float                   offsetY
        //          float                   offsetZ
        //      if Type = 11            load a set list
        //          int                     set list data length
        //          byte[]                  set list data
        //      if Type = 12            play a song from the set list
        //          int                     index into the set list for the requested song

		//	Server: 39 "SVR" | 01 | 01 00 00 00 | 00 00 00 00 | C6 27 00 00 | 2B 00 00 00
        //  Client: 39 "CLI" | 01 | 01 00 00 00 | 00 00 00 00 | C6 27 00 00 | 2B 00 00 00
        //  Server: 39 "SVR" | 02 | 01                  * ready
		//  Client: 39 "CLI" | 03 | "Renderer Visible" | 00 | 01 | 01
		//  Server: 39 "SVR" | 02 | 03                  * command successful
        //  Client: 39 "CLI" | 05 | "Miku" | 00 | "Default" | 00 | 01 | 00 00 00 00 | 00 00 00 00 | 00 00 00 00
        //  Server: 39 "SVR" | 02 | 03                  * command successful
		//  Client: 39 "CLI" | 06 | 00 00 00 00 | ...   * load a set list, the bytes are set list data parsed using the binary set list file format
        //  Server: 39 "SVR" | 02 | 03                  * command successful
		//  Client: 39 "CLI" | 07 | 01 00 00 00         * play song #1 from the currently loaded set list
        //  Server: 39 "SVR" | 02 | 03                  * command successful
		//  Timecode format: 8 bytes ticks
        //  Server: 39 "SVR" | 02 | 02 | 00 00 00 00 00 00 00 00

		public bool RendererVisible
		{
			get
			{
				if (mvarReader == null || mvarWriter == null) throw new InvalidOperationException();

				ParameterResponse response = (GetResponse(new ParameterRequest("Renderer Visible")) as ParameterResponse);
                if (response == null) throw new InvalidOperationException();

                return ((bool)response.Value == true);
			}
			set
			{
				Response response = GetResponse(new ParameterRequest("Renderer Visible", DataType.Boolean, value));

			}
		}

        public void Authenticate(string userName, string password)
        {

        }
    }
}
