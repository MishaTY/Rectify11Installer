namespace Rectify11Installer.Core
{
    public partial class FailUI : Form
    {
        public FailUI()
        {
            InitializeComponent();
            Cursor.Show();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            TopMost = false;
            SetupMode.RebootSystem();
        }

        private void FailUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                TopMost = false;
                SetupMode.RebootSystem();
            }
        }
    }
}
