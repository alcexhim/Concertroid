using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using AwesomeControls.DockingWindows;

using Concertroid.ObjectModels.Concert;

namespace Concertroid.Manager
{
    public partial class MainForm : Form
    {
        private ConcertObjectModel mvarConcert = new ConcertObjectModel();
        public ConcertObjectModel Concert { get { return mvarConcert; } set { mvarConcert = value; } }

        public MainForm()
        {
            InitializeComponent();

            mvarConcert.Title = "Untitled1";
            pnlLibraries.Concert = mvarConcert;

            switch (System.Environment.OSVersion.Platform)
            {
                case PlatformID.MacOSX:
                case PlatformID.Unix:
                {
                    mnuEditPreferences.Visible = true;
                    mnuToolsOptions.Visible = false;
                    break;
                }
                case PlatformID.Win32NT:
                case PlatformID.Win32S:
                case PlatformID.Win32Windows:
                case PlatformID.WinCE:
                case PlatformID.Xbox:
                {
                    mnuEditPreferences.Visible = false;
                    mnuToolsOptions.Visible = true;
                    break;
                }
            }
        }

        private void FileExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FileOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            ofd.Title = "Select File";
            
            if (mvarConcert == null) mvarConcert = new ConcertObjectModel();
            ofd.Filter = UniversalEditor.Common.Dialog.GetCommonDialogFilter(mvarConcert.MakeReference());
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                UniversalEditor.Common.Reflection.GetAvailableObjectModel<ConcertObjectModel>(ofd.FileName, ref mvarConcert);

            }
        }

        private void mnuHelpAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Concertroid! Manager version " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString() + "\r\nWritten by Michael Becker\r\nLicensed under the GNU General Public License, Concertroid! is free software.\r\n\r\n", "About Concertroid! Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FileNew_Click(object sender, EventArgs e)
        {
            mvarConcert = new ConcertObjectModel();

        }

        private void mnuToolsOptions_Click(object sender, EventArgs e)
        {

        }
    }
}
