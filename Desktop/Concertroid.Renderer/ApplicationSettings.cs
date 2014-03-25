using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UniversalEditor;

namespace Concertroid.Renderer
{
    public static class ApplicationSettings
    {
        private static Color mvarLightOnAmbientColor = Color.FromRGBA(0.7f, 0.7f, 0.7f, 1.0f);
        public static Color LightOnAmbientColor { get { return mvarLightOnAmbientColor; } set { mvarLightOnAmbientColor = value; } }

        private static Color mvarLightOnDiffuseColor = Color.FromRGBA(0.9f, 0.9f, 0.9f, 1.0f);
        public static Color LightOnDiffuseColor { get { return mvarLightOnDiffuseColor; } set { mvarLightOnDiffuseColor = value; } }

        private static Color mvarLightOnSpecularColor = Color.FromRGBA(0.6f, 0.6f, 0.6f, 1.0f);
        public static Color LightOnSpecularColor { get { return mvarLightOnSpecularColor; } set { mvarLightOnSpecularColor = value; } }

        private static Color mvarLightOffAmbientColor = Color.FromRGBA(-0.05, -0.05, -0.05);
        public static Color LightOffAmbientColor { get { return mvarLightOffAmbientColor; } set { mvarLightOffAmbientColor = value; } }

        private static Color mvarLightOffDiffuseColor = Color.FromRGBA(-0.05, -0.05, -0.05);
        public static Color LightOffDiffuseColor { get { return mvarLightOffDiffuseColor; } set { mvarLightOffDiffuseColor = value; } }

        private static Color mvarLightOffSpecularColor = Color.FromRGBA(-0.05, -0.05, -0.05);
        public static Color LightOffSpecularColor { get { return mvarLightOffSpecularColor; } set { mvarLightOffSpecularColor = value; } }

        public static void Load()
        {







        }


    }
}
