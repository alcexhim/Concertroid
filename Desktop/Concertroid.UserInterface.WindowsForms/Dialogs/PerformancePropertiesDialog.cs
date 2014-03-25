using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Concertroid.ObjectModels.Concert;

namespace Concertroid.Manager.Dialogs
{
    public partial class PerformancePropertiesDialog : Form
    {
        public PerformancePropertiesDialog()
        {
            InitializeComponent();
            base.Font = SystemFonts.MenuFont;
        }

        private ConcertObjectModel mvarConcert = null;
        public ConcertObjectModel Concert { get { return mvarConcert; } set { mvarConcert = value; } }

        private void cmdSongPerformerAdd_Click(object sender, EventArgs e)
        {

        }

        private void cmdSongPerformerModify_Click(object sender, EventArgs e)
        {

        }

        private void cmdSongPerformerRemove_Click(object sender, EventArgs e)
        {

        }

        private void cmdSongPerformerClear_Click(object sender, EventArgs e)
        {

        }

        private void cmdBrowseSong_Click(object sender, EventArgs e)
        {
            if (mvarConcert.Songs.Count < 1)
            {
                MessageBox.Show("There are no songs to choose from.  Load a song library, or create a song in \"Assets/Manual Control\" view, and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            SongBrowserDialog dlg = new SongBrowserDialog();
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

            }
        }
    }
}
