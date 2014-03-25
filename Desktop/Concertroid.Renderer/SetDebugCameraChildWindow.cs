using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Caltron;
using Caltron.Controls;

using UniversalEditor;

namespace Concertroid.Renderer
{
    public class SetDebugCameraChildWindow : Caltron.ChildWindow
    {
        public SetDebugCameraChildWindow()
        {
            this.Title = "SET DEBUG CAMERA";
            this.Visible = false;
            this.Position = new PositionVector2(800, 128);
            this.Size = new Dimension2D(200, 200);

            Checkbox chkEnable = new Checkbox();
            chkEnable.Text = "Enable";
            chkEnable.Position = new PositionVector2(3, 3);
            chkEnable.Size = new Dimension2D(128, 18);
            this.Controls.Add(chkEnable);
        }
    }
}
