using Rectify11Installer.Core;

namespace Rectify11Installer
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            bool setupMode = false;
            if (args.Length > 0)
            {
                var a = args[0];
                if (a == "/setup")
                {
                    setupMode = true;
                }
            }
            if (!setupMode)
            {
                if (Environment.OSVersion.Version.Build >= 21242) { }
                else
                {
                    Application.VisualStyleState = System.Windows.Forms.VisualStyles.VisualStyleState.NoneEnabled;
                    var h = MessageBox.Show("Rectify11 installer is only tested on Windows 11. If you want to continue, press Yes. The Rectify11 team is not responsible for damaging your Windows installation.", "Compatibility Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (h == DialogResult.Yes)
                    {

                    }
                    else
                    {
                        return;
                    }
                }

                if (IsRunningFromNetworkDrive())
                {
                    MessageBox.Show("This application cannot run on a network drive.", "Compatibility Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            string tempfldr = @"C:\Windows\Rectify11";
            if (!Directory.Exists(tempfldr))
            {
                Directory.CreateDirectory(tempfldr);
            }
            //Make sure to write latest file
            File.WriteAllText(tempfldr + "\\rectify11.xml", Properties.Resources.rectify11_xml);

            try
            {
                Patches.GetAll();
            }
            catch (Exception ex)
            {
                Application.VisualStyleState = System.Windows.Forms.VisualStyles.VisualStyleState.NonClientAreaEnabled;
                MessageBox.Show("Failure while loading: Rectify11.xml. The error details can be found below.\n" + ex.ToString(), "Initialization Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _ = DarkMode.fnAllowDarkModeForApp(DarkMode.PreferredAppMode.AllowDark);

            if (File.Exists(Application.StartupPath + "/install.log"))
                File.Delete(Application.StartupPath + "/install.log");

            if (!File.Exists(tempfldr + "\\Dark.msstyles") && !File.Exists(tempfldr + "\\light.msstyles"))
            {
                File.WriteAllBytes(tempfldr + "\\Dark.msstyles", Properties.Resources.Dark_msstyles);
                File.WriteAllBytes(tempfldr + "\\light.msstyles", Properties.Resources.light_msstyles);
            }
            try
            {
                Theme.LoadTheme();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failure while loading theming. The error details can be found below.\n" + ex.ToString(), "Initialization Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (!setupMode)
                    return;
            }

            Theme.DarkModeBool = Theme.IsUsingDarkMode;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.ThreadException += Application_ThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            Application.VisualStyleState = System.Windows.Forms.VisualStyles.VisualStyleState.ClientAndNonClientAreasEnabled;

            if (setupMode)
            {
                Application.Run(new SetupModeForm());
            }
            else
            {
                Application.Run(new FrmWizard());
            }
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            MessageBox.Show($"A fatal error occured: {(Exception)e.ExceptionObject}\nPlease report this as a bug\n", "Runtime Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            MessageBox.Show($"A fatal error occured: {e.Exception}\nPlease report this as a bug\n", "Runtime Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        private static bool IsRunningFromNetworkDrive()
        {
            var dir = AppDomain.CurrentDomain.BaseDirectory;
            var driveLetter = dir.First();
            if (!Char.IsLetter(driveLetter))
                return true;
            if (new DriveInfo(driveLetter.ToString()).DriveType == DriveType.Network)
                return true;
            return false;
        }
    }
}