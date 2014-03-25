using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UniversalEditor;
using Caltron;

namespace Concertroid.Renderer.Controls
{
    public class SplashScreenControl : Control2D
    {
        public SplashScreenControl()
        {
            this.Position = new PositionVector2(0, 0);

            double scale = 0.8;
            double width = 1024 * scale;
            double height = 400 * scale;
            this.Size = new Dimension2D(width, height);
        }

        private string mvarImageFileName = String.Join(System.IO.Path.DirectorySeparatorChar.ToString(), new string[] { System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "Images", "SplashScreen.tga" });
        public string ImageFileName { get { return mvarImageFileName; } set { mvarImageFileName = value; } }

        protected override void OnRender(RenderEventArgs e)
        {
            e.Canvas.DrawImage(0, 0, Size.Width, Size.Height, mvarImageFileName);
        }
    }
}
