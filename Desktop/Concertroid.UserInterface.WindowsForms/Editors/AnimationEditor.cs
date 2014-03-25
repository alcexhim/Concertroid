using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using UniversalEditor.UserInterface.WindowsForms;

namespace Concertroid.Manager.Editors
{
	public partial class AnimationEditor : Editor
	{
		public AnimationEditor()
		{
			InitializeComponent();
		}

		public override string Title { get { return "Animation Editor"; } }

		public override void Copy()
		{
			base.Copy();
		}
		public override void Paste()
		{
			base.Paste();
		}
		public override void Delete()
		{
			base.Delete();
		}
	}
}
