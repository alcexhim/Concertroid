using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Concertroid.Networking
{
    public delegate void RequestReceivedEventHandler(object sender, RequestReceivedEventArgs e);
    public class RequestReceivedEventArgs : EventArgs
    {
        private Request mvarRequest = null;
        public Request Request { get { return mvarRequest; } }

        public RequestReceivedEventArgs(Request request)
        {
            mvarRequest = request;
        }
    }
}
