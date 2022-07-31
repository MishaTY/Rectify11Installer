namespace Rectify11Installer.Pages
{
    public partial class UninstallConfirmPage : WizardPage, IRectifyInstalllerUninstallOptions
    {
        public UninstallConfirmPage()
        {
            InitializeComponent();
        }

        public bool RemoveExplorerPatcher => chkExplorerPatcher.Checked;

        public bool RemoveWinver => chkRemoveWinver.Checked;

        public bool RestoreWallpapers => chkRemoveWallpapers.Checked;
        public bool RemoveASDF => chkRemoveAsdf.Checked;

    }
}
