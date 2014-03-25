using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Concertroid.Networking
{
	public delegate void ClientConnectedEventHandler(object sender, ClientConnectedEventArgs e);
	public class ClientConnectedEventArgs : System.ComponentModel.CancelEventArgs
	{
		private System.Net.Sockets.TcpClient mvarClient = null;
		public System.Net.Sockets.TcpClient Client { get { return mvarClient; } }

		public ClientConnectedEventArgs(System.Net.Sockets.TcpClient client)
		{
			mvarClient = client;
		}
	}
}
