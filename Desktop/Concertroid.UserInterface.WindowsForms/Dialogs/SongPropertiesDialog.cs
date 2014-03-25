using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Concertroid.Manager.Dialogs
{
    public partial class SongPropertiesDialog : Form
    {
        public SongPropertiesDialog()
        {
            InitializeComponent();
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSongTitle.Text))
            {
                MessageBox.Show("Please select a song title.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!optAuthorizationStatusAuthorized.Checked && !optAuthorizationStatusImplicit.Checked && !optAuthorizationStatusNotAuthorized.Checked)
            {
                MessageBox.Show("Please record the authorization status of this song.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (optAuthorizationStatusNotAuthorized.Checked)
            {
                MessageBox.Show("Don't forget to contact the producers of this song before the event and ensure that you receive permission to use this song in your event.  The software will automatically skip over songs whose authorization status is set to \"Not Authorized\"!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
