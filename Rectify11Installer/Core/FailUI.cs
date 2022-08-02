namespace Rectify11Installer.Core
{
    public partial class FailUI : Form
    {
        public FailUI()
        {
            InitializeComponent();
            Cursor.Show();
            Focus();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            TopMost = false;
            SetupMode.RebootSystem();
        }

        private void FailUI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                TopMost = false;
                SetupMode.RebootSystem();
            }
        }
    }
}