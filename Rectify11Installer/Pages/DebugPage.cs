using Rectify11Installer.Core;
using Rectify11Installer.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rectify11Installer.Pages
{
    public partial class DebugPage : WizardPage
    {
        public DebugPage()
        {
            InitializeComponent();
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(navigationButton3, new Point(10,10));
        }

        private void winuiButton2_Click(object sender, EventArgs e)
        {
            InstallStatus.IsRectify11Installed = true;
        }

        private void winuiButton3_Click(object sender, EventArgs e)
        {
            SetupMode.Exit();
        }
    }
}
