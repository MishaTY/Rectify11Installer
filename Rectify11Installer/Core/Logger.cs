using System.Text;

namespace Rectify11Installer.Core
{
    public class Logger
    {
        private static string Text = "";
        private static FileStream? fs;
        public static void WriteLine(string s)
        {
            lock (Text)
            {
                try
                {
                    if (!File.Exists("installer.log"))
                    {
                        File.WriteAllText("installer.log", "");
                    }
                    Text += s + "\n";

                    if (fs == null)
                    {
                        fs = new FileStream("installer.log", FileMode.Create, FileAccess.Write);
                    }


                    fs.Position = 0;
                    byte[] bt = Encoding.ASCII.GetBytes(Text);
                    fs.Write(bt, 0, bt.Length);
                    fs.Flush();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("A error occured while trying to write to the log file. It is safe to ignore this message.\n" + ex.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public static void CloseLog()
        {
            if (fs != null)
                fs.Close();
        }

        public static void Warn(string v)
        {
            WriteLine("[WARNING] " + v);
        }
    }
}
