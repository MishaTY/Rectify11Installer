using Microsoft.Win32;
using System.Text.RegularExpressions;

namespace Rectify11Installer.Win32
{
    public class RuntimeHelper
    {
        public static bool IsVCRuntimeInstalled()
        {
            string dependenciesPath = @"SOFTWARE\Classes\Installer\Dependencies";

            using (RegistryKey dependencies = Registry.LocalMachine.OpenSubKey(dependenciesPath))
            {
                if (dependencies == null) return false;

                foreach (string subKeyName in dependencies.GetSubKeyNames().Where(n => !n.ToLower().Contains("dotnet") && !n.ToLower().Contains("microsoft")))
                {
                    using (RegistryKey subDir = Registry.LocalMachine.OpenSubKey(dependenciesPath + "\\" + subKeyName))
                    {
                        var value = subDir.GetValue("DisplayName")?.ToString() ?? null;
                        if (string.IsNullOrEmpty(value)) continue;

                        if (Regex.IsMatch(value, @"C\+\+ (2017|2019|2022).*\(x64\)")) //here u can specify your version.
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }
    }
}
