namespace Rectify11Installer.Pages
{
    public partial class WizardPage : UserControl
    {
        public string WizardTopText { get; set; } = "Wizard Page";
        public bool WizardShowTitle { get; set; } = true;
        public WizardPage()
        {
            InitializeComponent();
        }
    }
}
