using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Concertroid.Networking.Responses
{
    public class IntroductionResponse : Response
    {
        private Version mvarVersion = new Version();
        public Version Version { get { return mvarVersion; } }

        private string mvarServerName = String.Empty;
        public string ServerName { get { return mvarServerName; } }

        public IntroductionResponse(Version version, string serverName)
        {
            mvarVersion = version;
            mvarServerName = serverName;
        }
    }
}
