using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Caltron;

namespace Concertroid.Renderer.Controls
{
    public class WatermarkControl : Control2D
    {
        private string WatermarkFileName = String.Join(System.IO.Path.DirectorySeparatorChar.ToString(), new string[] { "Images", "Watermark.tga" });
        
        protected override void OnRender(RenderEventArgs e)
        {
            base.OnRender(e);
            if (System.IO.File.Exists(WatermarkFileName)) e.Canvas.DrawImage(0, 0, 164, 26, WatermarkFileName);
        }
    }
}
