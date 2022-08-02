using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace Rectify11Installer.Core
{
    public class IniFile
    {
        string Path;
        string EXE
        {
            get
            {
                var name = Assembly.GetExecutingAssembly().GetName();
                if (name == null)
                    throw new Exception();
                if (name.Name == null)
                    throw new Exception();

                return name.Name;
            }
        }

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern long WritePrivateProfileString(string Section, string? Key, string? Value, string FilePath);

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

        public IniFile(string? IniPath = null)
        {
            Path = new FileInfo(IniPath ?? EXE + ".ini").FullName;
        }

        public string Read(string Key, string? Section = null)
        {

            var RetVal = new StringBuilder(255);
            GetPrivateProfileString(Section ?? EXE, Key, "", RetVal, 255, Path);
            return RetVal.ToString();
        }

        public void Write(string? Key, string? Value, string? Section = null)
        {
            WritePrivateProfileString(Section ?? EXE, Key, Value, Path);
        }

        public void DeleteKey(string Key, string? Section = null)
        {
            Write(Key, null, Section ?? EXE);
        }

        public void DeleteSection(string? Section = null)
        {
            Write(null, null, Section ?? EXE);
        }

        public bool KeyExists(string Key, string? Section = null)
        {
            return Read(Key, Section).Length > 0;
        }
    }
}
