using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Concertroid.Networking
{
    public delegate void ExceptionThrownEventHandler(object sender, ExceptionThrownEventArgs e);
    public class ExceptionThrownEventArgs : CancelEventArgs
    {
        private Exception mvarException = null;
        public Exception Exception { get { return mvarException; } }

        public ExceptionThrownEventArgs(Exception exception)
        {
            mvarException = exception;
        }
    }
}
