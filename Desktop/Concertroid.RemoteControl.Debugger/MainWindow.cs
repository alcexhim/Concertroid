using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Concertroid.RemoteControl
{
	public partial class MainWindow : Form
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void mnuHelpAbout_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Concertroid Remote Debugger\r\nVersion " + (System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString()) + "\r\n\r\nLicensed under the GNU General Public License version 3", "About Concertroid Remote Debugger", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
