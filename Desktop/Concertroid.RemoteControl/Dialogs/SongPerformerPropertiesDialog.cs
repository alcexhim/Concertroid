using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Concertroid.Manager.Dialogs
{
    public partial class SongPerformerPropertiesDialog : Form
    {
        public SongPerformerPropertiesDialog()
        {
            InitializeComponent();
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCharacter.Text))
            {
                MessageBox.Show("Please select a character.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(txtCostume.Text))
            {
                MessageBox.Show("Please select a costume for the character to wear.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(txtMotion.Text))
            {
                MessageBox.Show("Please select a motion file for the character to dance to.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!optAfterPerformanceDismissCharacter.Checked && !optAfterPerformanceLightsOff.Checked && !optAfterPerformanceLightsOn.Checked)
            {
                MessageBox.Show("Please select an action to take after the performance is complete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}
