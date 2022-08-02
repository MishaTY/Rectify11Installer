namespace Rectify11Installer.Pages
{
    public partial class RebootPage : WizardPage
    {
        int timer = 0;
        public RebootPage()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer += 1000;
            if (timer == 20000)
            {
                timer1.Stop();
                winuiButton1_Click(this, new EventArgs());
            }
        }
        public void Start()
        {
            timer1.Start();
        }
        private void winuiButton1_Click(object sender, EventArgs e)
        {
            Win32.NativeMethods.Reboot();
            Application.Exit();
        }
    }
}
