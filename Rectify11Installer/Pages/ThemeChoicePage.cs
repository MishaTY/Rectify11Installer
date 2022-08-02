using Rectify11Installer.Controls;

namespace Rectify11Installer.Pages
{
    public partial class ThemeChoicePage : WizardPage, IRectifyInstalllerThemeOptions
    {
        public bool Light { get => darkAwareRadioButton1.Checked; }
        public bool Dark { get => darkAwareRadioButton2.Checked; }
        public bool Black { get => darkAwareRadioButton3.Checked; }
        public ThemeChoicePage()
        {
            InitializeComponent();
        }

        private void ThemeChoicePage_Load(object sender, EventArgs e)
        {
            if (Theme.DarkModeBool)
                darkAwareRadioButton3.Checked = true;
            else
                darkAwareRadioButton1.Checked = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            darkAwareRadioButton1.Checked = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            darkAwareRadioButton2.Checked = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            darkAwareRadioButton3.Checked = true;
        }

        private void darkAwareRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
