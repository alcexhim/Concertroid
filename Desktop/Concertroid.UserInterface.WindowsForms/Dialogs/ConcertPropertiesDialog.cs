using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Concertroid.Manager.Dialogs
{
    public partial class ConcertPropertiesDialog : Form
    {
        public ConcertPropertiesDialog()
        {
            InitializeComponent();
            base.Font = SystemFonts.MenuFont;
        }
    }
}
