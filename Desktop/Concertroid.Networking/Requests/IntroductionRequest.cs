using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Concertroid.Networking.Requests
{
    public class IntroductionRequest : Request
    {
        private Version mvarVersion = new Version();
        public Version Version { get { return mvarVersion; } }

        public IntroductionRequest(Version version)
        {
            mvarVersion = version;
        }
    }
}
