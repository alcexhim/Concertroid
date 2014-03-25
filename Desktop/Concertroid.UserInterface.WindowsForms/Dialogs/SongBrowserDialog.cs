using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Concertroid.Manager.Dialogs
{
    public partial class SongBrowserDialog : Form
    {
        public SongBrowserDialog()
        {
            InitializeComponent();
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            if (lvSongs.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a song.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}
