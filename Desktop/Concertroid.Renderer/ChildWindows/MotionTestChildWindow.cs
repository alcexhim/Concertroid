using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UniversalEditor;

using Caltron;
using Caltron.Controls.Controls2D;

namespace Concertroid.Renderer.ChildWindows
{
    public class MotionTestChildWindow : Caltron.ChildWindow
    {
        public MotionTestChildWindow()
        {
            this.Title = "MOTION TEST";
            this.Visible = false;
            this.Position = new PositionVector2(13, 13);
            this.Size = new Dimension2D(200, 300);

            Label lblChara = new Label();
            lblChara.Name = "lblChara";
            lblChara.Text = "CHARA";
            lblChara.Position = new PositionVector2(4, 4);
            lblChara.Size = new Dimension2D(4, 4);
            this.Controls.Add(lblChara);

            ComboBox cboChara = new ComboBox();
            cboChara.Name = "cboChara";
            cboChara.Items.Add("MIKU");
            cboChara.Items.Add("RIN");
            cboChara.Items.Add("LEN");
            cboChara.Items.Add("LUKA");
            cboChara.Items.Add("MEIKO");
            cboChara.Items.Add("KAITO");
            cboChara.Position = new PositionVector2(60, 4);
            cboChara.Size = new Dimension2D(48, 18);
            cboChara.SelectedItem = cboChara.Items[0];
            this.Controls.Add(cboChara);

            Label lblCostume = new Label();
            lblCostume.Name = "lblCostume";
            lblCostume.Text = "COSTUME";
            lblCostume.Position = new PositionVector2(4, 4 + (20 * 1));
            lblCostume.Size = new Dimension2D(4, 4);
            this.Controls.Add(lblCostume);

            ComboBox cboCostume = new ComboBox();
            cboCostume.Name = "cboCostume";
            cboCostume.Items.Add("DEFAULT");
            cboCostume.Items.Add("AMERICANA");
            cboCostume.Items.Add("CONFLICT");
            cboCostume.Items.Add("TIME_LIMIT");
            cboCostume.Position = new PositionVector2(60, 4 + (18 * 1));
            cboCostume.Size = new Dimension2D(80, 18);
            cboCostume.SelectedItem = cboCostume.Items[0];
            this.Controls.Add(cboCostume);

            Label lblSet = new Label();
            lblSet.Name = "lblSet";
            lblSet.Text = "SET";
            lblSet.Position = new PositionVector2(4, 4 + (20 * 2));
            lblSet.Size = new Dimension2D(4, 4);
            this.Controls.Add(lblSet);

            ComboBox cboSet = new ComboBox();
            cboSet.Name = "cboSet";
            cboSet.Items.Add("PV567");
            cboSet.Items.Add("PV569");
            cboSet.Items.Add("PV580");
            cboSet.Items.Add("PV591");
            cboSet.Position = new PositionVector2(60, 4 + (18 * 2));
            cboSet.Size = new Dimension2D(96, 18);
            cboSet.SelectedItem = cboSet.Items[0];
            this.Controls.Add(cboSet);

            Label lblBone = new Label();
            lblBone.Name = "lblBone";
            lblBone.Text = "BONE";
            lblBone.Position = new PositionVector2(4, 4 + (20 * 3));
            lblBone.Size = new Dimension2D(4, 4);
            this.Controls.Add(lblBone);

            ComboBox cboBone = new ComboBox();
            cboBone.Name = "cboBone";
            cboBone.Position = new PositionVector2(60, 4 + (18 * 3));
            cboBone.Size = new Dimension2D(90, 18);
            this.Controls.Add(cboBone);


            Label lblRotate = new Label();
            lblRotate.Name = "lblRotate";
            lblRotate.Text = "ROTATE";
            lblRotate.Position = new PositionVector2(4, 4 + (20 * 4));
            lblRotate.Size = new Dimension2D(100, 18);
            lblRotate.HorizontalAlignment = HorizontalAlignment.Center;
            this.Controls.Add(lblRotate);


            Label lblRotateX = new Label();
            lblRotateX.Name = "lblRotateX";
            lblRotateX.Text = "X     0";
            lblRotateX.Position = new PositionVector2(4, 4 + (20 * 5));
            lblRotateX.Size = new Dimension2D(100, 18);
            this.Controls.Add(lblRotateX);

            ScrollBar hscRotateX = new ScrollBar();
            hscRotateX.Name = "hscRotateX";
            hscRotateX.Position = new PositionVector2(80, 4 + (20 * 5));
            hscRotateX.Size = new Dimension2D(90, 18);
            hscRotateX.Minimum = -10;
            hscRotateX.Maximum = 10;
            this.Controls.Add(hscRotateX);

            Label lblRotateY = new Label();
            lblRotateY.Name = "lblRotateY";
            lblRotateY.Text = "Y     0";
            lblRotateY.Position = new PositionVector2(4, 4 + (20 * 6));
            lblRotateY.Size = new Dimension2D(100, 18);
            this.Controls.Add(lblRotateY);

            ScrollBar hscRotateY = new ScrollBar();
            hscRotateY.Name = "hscRotateY";
            hscRotateY.Position = new PositionVector2(80, 4 + (20 * 6));
            hscRotateY.Size = new Dimension2D(90, 18);
            hscRotateY.Minimum = -10;
            hscRotateY.Maximum = 10;
            this.Controls.Add(hscRotateY);

            Label lblRotateZ = new Label();
            lblRotateZ.Name = "lblRotateZ";
            lblRotateZ.Text = "Z     0";
            lblRotateZ.Position = new PositionVector2(4, 4 + (20 * 7));
            lblRotateZ.Size = new Dimension2D(100, 18);
            this.Controls.Add(lblRotateZ);

            ScrollBar hscRotateZ = new ScrollBar();
            hscRotateZ.Name = "hscRotateZ";
            hscRotateZ.Position = new PositionVector2(80, 4 + (20 * 7));
            hscRotateZ.Size = new Dimension2D(90, 18);
            hscRotateZ.Minimum = -10;
            hscRotateZ.Maximum = 10;
            this.Controls.Add(hscRotateZ);


            Label lblPosition = new Label();
            lblPosition.Name = "lblPosition";
            lblPosition.Text = "POSITION";
            lblPosition.Position = new PositionVector2(4, 4 + (20 * 8));
            lblPosition.Size = new Dimension2D(100, 18);
            lblPosition.HorizontalAlignment = HorizontalAlignment.Center;
            this.Controls.Add(lblPosition);


            Label lblPositionX = new Label();
            lblPositionX.Name = "lblPositionX";
            lblPositionX.Text = "X     0";
            lblPositionX.Position = new PositionVector2(4, 4 + (20 * 9));
            lblPositionX.Size = new Dimension2D(100, 18);
            this.Controls.Add(lblPositionX);

            ScrollBar hscPositionX = new ScrollBar();
            hscPositionX.Name = "hscPositionX";
            hscPositionX.Position = new PositionVector2(80, 4 + (20 * 9));
            hscPositionX.Size = new Dimension2D(90, 18);
            hscPositionX.Minimum = -10;
            hscPositionX.Maximum = 10;
            this.Controls.Add(hscPositionX);

            Label lblPositionY = new Label();
            lblPositionY.Name = "lblPositionY";
            lblPositionY.Text = "Y     0";
            lblPositionY.Position = new PositionVector2(4, 4 + (20 * 10));
            lblPositionY.Size = new Dimension2D(100, 18);
            this.Controls.Add(lblPositionY);

            ScrollBar hscPositionY = new ScrollBar();
            hscPositionY.Name = "hscPositionY";
            hscPositionY.Position = new PositionVector2(80, 4 + (20 * 10));
            hscPositionY.Size = new Dimension2D(90, 18);
            hscPositionY.Minimum = -10;
            hscPositionY.Maximum = 10;
            this.Controls.Add(hscPositionY);

            Label lblPositionZ = new Label();
            lblPositionZ.Name = "lblPositionZ";
            lblPositionZ.Text = "Z     0";
            lblPositionZ.Position = new PositionVector2(4, 4 + (20 * 11));
            lblPositionZ.Size = new Dimension2D(100, 18);
            this.Controls.Add(lblPositionZ);

            ScrollBar hscPositionZ = new ScrollBar();
            hscPositionZ.Name = "hscPositionZ";
            hscPositionZ.Position = new PositionVector2(80, 4 + (20 * 11));
            hscPositionZ.Size = new Dimension2D(90, 18);
            hscPositionZ.Minimum = -10;
            hscPositionZ.Maximum = 10;
            this.Controls.Add(hscPositionZ);
        }
    }
}
