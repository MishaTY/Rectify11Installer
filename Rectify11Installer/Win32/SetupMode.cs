using Microsoft.Win32;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Rectify11Installer.Win32
{
    public static class SetupMode
    {
        public static void Enter()
        {
            RegistryKey? sys = Registry.LocalMachine.OpenSubKey("SYSTEM", true);
            if (sys == null)
            {
                throw new Exception("HKEY_LOCAL_MACHINE/SYSTEM is null");
            }

            RegistryKey? setup = sys.OpenSubKey("Setup", true);
            if (setup == null)
            {
                throw new Exception("HKEY_LOCAL_MACHINE/SYSTEM/Setup is null");
            }

            //SetupType values
            //0=Do nothing, show login screen
            //1=Run CMDLine then REBOOT
            //2=Run CMDLine then show login screen

            setup.SetValue("SystemSetupInProgress", 1, RegistryValueKind.DWord);
            setup.SetValue("SetupType", 1, RegistryValueKind.DWord); //reboot
            setup.SetValue("SetupPhase", 1, RegistryValueKind.DWord); //?

            var mod = Process.GetCurrentProcess().MainModule;

            if (mod != null)
            {
                var path = mod.FileName;
                setup.SetValue("CmdLine", $"\"{path}\" /setup", RegistryValueKind.String);
            }
            else
            {
                Exit(); //This is done just in case if it gets enabled
                throw new Exception("Process.GetCurrentProcess().MainModule returned null");
            }
            setup.Close();
            CommitRegistry();
        }

        public static void Exit()
        {
            RegistryKey? sys = Registry.LocalMachine.OpenSubKey("SYSTEM", true);
            if (sys == null)
            {
                throw new Exception("HKEY_LOCAL_MACHINE/SYSTEM is null");
            }

            RegistryKey? setup = sys.OpenSubKey("Setup", true);
            if (setup == null)
            {
                throw new Exception("HKEY_LOCAL_MACHINE/SYSTEM/Setup is null");
            }

            //SetupType values
            //0=Do nothing, show login screen
            //1=Run CMDLine then REBOOT
            //2=Run CMDLine then show login screen

            setup.SetValue("SystemSetupInProgress", 0, RegistryValueKind.DWord);
            setup.SetValue("SetupType", 0, RegistryValueKind.DWord); //reboot
            setup.SetValue("SetupPhase", 0, RegistryValueKind.DWord); //?

            setup.SetValue("CmdLine", "", RegistryValueKind.String);
            setup.Close();
            CommitRegistry();
        }

        [DllImport("Advapi32.dll", EntryPoint = "RegFlushKey")]
        public static extern int RegFlushKey(IntPtr hKey);

        const uint HKEY_CLASSES_ROOT = 0x80000000;
        const uint HKEY_CURRENT_USER = 0x80000001;
        const uint HKEY_LOCAL_MACHINE = 0x80000002;
        const uint HKEY_USERS = 0x80000003;

        public static void CommitRegistry()
        {
            IntPtr hkeyLocalMachine = new IntPtr(unchecked((int)HKEY_LOCAL_MACHINE));
            RegFlushKey(hkeyLocalMachine);
        }

        public static void RebootSystem()
        {
            NativeMethods.Reboot();
        }
    }
}