using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Concertroid.SelfExtractor
{
    static class Program
    {
        public const int STUBSIZE = 194048;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string stubFileName = System.Reflection.Assembly.GetExecutingAssembly().Location;
            byte[] stubData = System.IO.File.ReadAllBytes(stubFileName);

            if (stubData.Length == STUBSIZE)
            {
                MessageBox.Show("This self-extracting application does not contain a valid PolyMo Live! concert package.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            byte[] stubContent = new byte[stubData.Length - STUBSIZE];
        }
    }
}
