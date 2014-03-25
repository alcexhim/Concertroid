using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Concertroid.Manager.Dialogs
{
    public partial class CostumeTransitionPropertiesDialog : Form
    {
        public CostumeTransitionPropertiesDialog()
        {
            InitializeComponent();
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCostume.Text))
            {
                MessageBox.Show("Please select a costume to transition to.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(txtTransition.Text))
            {
                MessageBox.Show("Please select a transition to use for this costume change.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
