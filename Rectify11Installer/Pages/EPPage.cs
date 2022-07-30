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
    }
}
