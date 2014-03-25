using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Concertroid.Manager.Dialogs
{
	public partial class ConnectToServerDialog : Form
	{
		public ConnectToServerDialog()
		{
			InitializeComponent();
            base.Font = SystemFonts.MenuFont;
        }

        private void cmdLogIn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUserName.Text) || String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please enter a user name and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(cboServer.Text))
            {
                MessageBox.Show("Please specify the Concertroid rendering server to which you would like to connect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
	}
}
