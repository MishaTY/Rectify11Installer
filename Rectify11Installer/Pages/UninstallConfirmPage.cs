namespace Rectify11Installer.Pages
{
    public partial class UninstallConfirmPage : WizardPage, IRectifyInstalllerUninstallOptions
    {
        public UninstallConfirmPage()
        {
            InitializeComponent();
        }

        public bool RemoveExplorerPatcher => chkExplorerPatcher.Checked;

        public bool RemoveThemesAndThemeTool => chkRemoveThemes.Checked;

        public bool RestoreWallpapers => chkRestoreWallpaper.Checked;

        private void chkRemoveThemes_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
