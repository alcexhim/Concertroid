using System;
using System.Collections.Generic;
using System.Text;

using Caltron;

namespace Concertroid.Renderer
{
    public class RenderWindow : Window
    {
        private double rot = 15.0;
        private int times = 0;

        public RenderWindow()
        {
            base.AlwaysRender = true;
        }

        private float col = 0;
        private sbyte dir = 10;

        protected override void OnAfterRender(RenderEventArgs e)
        {
            base.OnAfterRender(e);

            // From http://basic4gl.wikispaces.com/2D+Drawing+in+OpenGL
            // Setup a 2D projection
            int XSize = 640, YSize = 480;
            e.MatrixMode = MatrixMode.Projection;
            e.ResetMatrix();
            
            Caltron.Internal.OpenGL.Methods.glOrtho(0, base.Size.Width, base.Size.Height, 0, 0, 1);
            e.EnableDepthTesting = false;

            e.MatrixMode = MatrixMode.ModelView;
            e.ResetMatrix();
            
            // Variables
            double x2 = base.Size.Width / 2, y2 = base.Size.Height / 2, x1 = (base.Size.Width - x2) / 2, y1 = (base.Size.Height - y2) / 2;
 
            // Draw a scene
            e.Color = new Color(255, 255, 255, 1.0);
            // e.ResetColorBuffer();

            e.Texture = Texture.FromFile(@"U:\Applications\PolyMoLive\bin\Debug\Images\SplashScreen\PMMLive.png", TextureRotation.None, TextureFlip.None);
            // e.Texture = null;

            e.Rotate(0.0 , RotationAxis.X);

            e.Begin(RenderMode.Quads);

            Caltron.Internal.OpenGL.Methods.glTexCoord2f(0, 0);
            e.DrawVertex(x1, y1);
            Caltron.Internal.OpenGL.Methods.glTexCoord2f(1, 0);
            e.DrawVertex(x2, y1);
            Caltron.Internal.OpenGL.Methods.glTexCoord2f(1, 1);
            e.DrawVertex(x2, y2);
            Caltron.Internal.OpenGL.Methods.glTexCoord2f(0, 1);
            e.DrawVertex(x1, y2);
            e.End();

            /*
            if (times == 10)
            {
                rot += 15;
                times = 0;
            }
            times++;
             */
            
        }

    }
}
