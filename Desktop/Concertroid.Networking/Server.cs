using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using UniversalEditor.IO;
using Concertroid.Networking.Requests;
using Concertroid.Networking.Responses;

namespace Concertroid.Networking
{
	public class Server
	{
		private System.Threading.Thread _thread = null;

		private int mvarPortNumber = 3939;
		public int PortNumber { get { return mvarPortNumber; } set { mvarPortNumber = value; } }

        private Dictionary<string, Variable> mvarVariables = new Dictionary<string, Variable>();
        public Dictionary<string, Variable> Variables { get { return mvarVariables; } }

		/// <summary>
		/// Starts the Concertroid! server listening on the default port.
		/// </summary>
		public void Start()
		{
			if (_thread != null) throw new InvalidOperationException("Server already started");
			_thread = new System.Threading.Thread(_thread_ThreadStart);
			_thread.Start();
		}

		/// <summary>
		/// Stops the running Concertroid! server.
		/// </summary>
		public void Stop()
		{
			if (_thread == null) return;
			_thread.Abort();
			_thread = null;
		}

		private Dictionary<TcpClient, Thread> ClientThreads = new Dictionary<TcpClient, Thread>();

		private TcpListener listener = null;
		private void _thread_ThreadStart()
		{
            try
            {
                listener = new TcpListener(IPAddress.Any, mvarPortNumber);
                listener.Start();
            }
            catch (Exception ex)
            {
                ExceptionThrownEventArgs ea = new ExceptionThrownEventArgs(ex);
                OnExceptionThrown(ea);
                if (ea.Cancel) return;
            }

			while (true)
			{
				TcpClient client = listener.AcceptTcpClient();
				
				Thread threadClient = new Thread(threadClient_ParameterizedThreadStart);
				threadClient.Start(client);
			}
		}

        public event ExceptionThrownEventHandler ExceptionThrown;
        protected virtual void OnExceptionThrown(ExceptionThrownEventArgs e)
        {
            if (ExceptionThrown != null) ExceptionThrown(this, e);
        }

        private BinaryReader mvarReader = null;
        public BinaryReader Reader { get { return mvarReader; } }

        private BinaryWriter mvarWriter = null;
        public BinaryWriter Writer { get { return mvarWriter; } }

		private void threadClient_ParameterizedThreadStart(object param)
		{
			TcpClient client = (param as TcpClient);
			if (client != null)
			{
                NetworkStream ns = client.GetStream();
                mvarReader = new BinaryReader(ns);
                mvarWriter = new BinaryWriter(ns);

                ClientConnectedEventArgs ce = new ClientConnectedEventArgs(client);
				OnClientConnected(ce);
                if (ce.Cancel) return;

                while (client.Connected)
                {
                    try
                    {
                        Request request = GetRequest();
                        if (request is IntroductionRequest)
                        {
                            IntroductionResponse response = new IntroductionResponse(mvarServerVersion, mvarServerName);
                            SendResponse(response);
                        }
                        else
                        {
                            OnRequestReceived(new RequestReceivedEventArgs(request));
                        }
                    }
                    catch (System.IO.IOException)
                    {
                    }
                }
			}
		}

        public event RequestReceivedEventHandler RequestReceived;
        protected virtual void OnRequestReceived(RequestReceivedEventArgs e)
        {
            if (RequestReceived != null) RequestReceived(this, e);
        }

        private Request GetRequest()
        {
            BinaryReader br = mvarReader;
            byte requestTypeID = br.ReadByte();
            switch (requestTypeID)
            {
                case 1:
                {
                    int major = br.ReadInt32();
                    int minor = br.ReadInt32();
                    int build = br.ReadInt32();
                    int revision = br.ReadInt32();
                    Version version = new Version(major, minor, build, revision);

                    IntroductionRequest request = new IntroductionRequest(version);
                    return request;
                }
                case 3:
                {
                    ParameterRequestMode mode = (ParameterRequestMode)br.ReadByte();
                    string parameterName = br.ReadNullTerminatedString();

                    ParameterRequest request = null;
                    if (mode == ParameterRequestMode.Set)
                    {
                        DataType dataType = (DataType)br.ReadByte();
                        object value = br.ReadObject(dataType);
                        request = new ParameterRequest(parameterName, dataType, value);
                    }
                    else
                    {
                        request = new ParameterRequest(parameterName);
                    }
                    return request;
                }
            }
            return null;
        }
        private void SendResponse(Response response)
        {
            BinaryWriter bw = mvarWriter;
            if (response is IntroductionResponse)
            {
                IntroductionResponse ir = (response as IntroductionResponse);
                bw.Write((byte)1);
                bw.Write(ir.Version);
                bw.WriteNullTerminatedString(ir.ServerName);
                bw.Flush();
            }
            else if (response is ParameterResponse)
            {
                ParameterResponse pr = (response as ParameterResponse);
                bw.Write((byte)3);
                bw.WriteNullTerminatedString(pr.Name);
                bw.Write((byte)pr.DataType);
                bw.WriteObject(pr.Value, pr.DataType);
            }
        }

		public event ClientConnectedEventHandler ClientConnected;
		protected virtual void OnClientConnected(ClientConnectedEventArgs e)
		{
			if (ClientConnected != null) ClientConnected(this, e);
		}

        private Version mvarServerVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
        public Version ServerVersion { get { return mvarServerVersion; } set { mvarServerVersion = value; } }

        private string mvarServerName = String.Empty;
        public string ServerName { get { return mvarServerName; } set { mvarServerName = value; } }
    }
}
