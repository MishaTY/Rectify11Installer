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
            if (Environment.OSVersion.Version.Build >= 25169)
            {
                chkW10.Enabled = false; // They killed win10 start menu in 25169, if win10 option is selected then EP would die. 
                chkW11.Checked = true;
                label2.Text = "*Win10 start menu is removed in build 25169 and above";
            }
        }
    }
}
