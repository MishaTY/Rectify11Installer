namespace Rectify11Installer.Pages
{
    public partial class EPPage : WizardPage, IRectifyInstalllerEPOptions
    {
        public bool w10 { get => chkW10.Checked; }
        public bool w11 { get => chkW11.Checked; }
        public bool w10TaskB { get => chkW10TaskB.Checked; }
        public bool micaExplorer { get => chkMicaExplorer.Checked; }
        public EPPage()
        {
            InitializeComponent();
        }

        private void EPPage_Load(object sender, EventArgs e)
        {

        }

        private void chkW11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void darkAwareFlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void chkW10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
