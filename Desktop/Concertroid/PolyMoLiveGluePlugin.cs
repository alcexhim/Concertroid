using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Glue;

namespace Concertroid
{
    public class PolyMoLiveGluePlugin : Plugin
    {
        protected override void OnApplicationEvent(ApplicationEventEventArgs e)
        {
            base.OnApplicationEvent(e);

            switch (e.EventName)
            {
                case Glue.Common.Constants.EventNames.ApplicationStart:
                {

                    break;
                }
            }
        }
    }
}
