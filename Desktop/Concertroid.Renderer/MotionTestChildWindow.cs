using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UniversalEditor;
using Caltron;

namespace Concertroid.Renderer
{
    public class MotionTestChildWindow : Caltron.ChildWindow
    {
        public MotionTestChildWindow()
        {
            this.Title = "MOTION TEST";
            this.Visible = false;
            this.Position = new PositionVector2(128, 128);
            this.Size = new Dimension2D(200, 300);
        }
    }
}
