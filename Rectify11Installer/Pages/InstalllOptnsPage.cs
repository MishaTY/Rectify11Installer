namespace Rectify11Installer.Pages
{
    public partial class InstalllOptnsPage : WizardPage, IRectifyInstalllerInstallOptions
    {
        public bool ShouldInstallExplorerPatcher { get => chkExplorerPatcher.Checked; }
        public bool ShouldInstallASDF { get => chkAsdf.Checked; }
        public bool ShouldInstallWallpaper { get => chkWallpaper.Checked; }
        public bool ShouldInstallWinver { get => chkWinVer.Checked; }
        public bool DoSafeInstall { get => radSafe.Checked; }
        public InstalllOptnsPage()
        {
            InitializeComponent();
        }
    }
}
