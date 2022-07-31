using Rectify11Installer.Core;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Rectify11Installer.Win32
{
    namespace Rectify11
    {
        public class PatcherHelper
        {
            [return: MarshalAs(UnmanagedType.Bool)]
            [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
            static extern bool MoveFileEx(string lpExistingFileName, string lpNewFileName,
              MoveFileFlags dwFlags);

            [Flags]
            enum MoveFileFlags
            {
                MOVEFILE_REPLACE_EXISTING = 0x00000001,
                MOVEFILE_COPY_ALLOWED = 0x00000002,
                MOVEFILE_DELAY_UNTIL_REBOOT = 0x00000004,
                MOVEFILE_WRITE_THROUGH = 0x00000008,
                MOVEFILE_CREATE_HARDLINK = 0x00000010,
                MOVEFILE_FAIL_IF_NOT_TRACKABLE = 0x00000020
            }
            public static bool TakeOwnership(string fileName, bool recursive)
            {
                Process takeOwnProcess = new Process();
                ProcessStartInfo takeOwnStartInfo = new ProcessStartInfo
                {
                    FileName = "takeown.exe",

                    // Do not write error output to standard stream.
                    RedirectStandardError = true,
                    // Do not write output to Process.StandardOutput Stream.
                    RedirectStandardOutput = true,
                    // Do not read input from Process.StandardInput (i/e; the keyboard).
                    RedirectStandardInput = false,

                    UseShellExecute = false,
                    // Do not show a command window.
                    CreateNoWindow = true,

                    Arguments = "/f " + fileName + " /a "
                };

                if (recursive)
                    takeOwnStartInfo.Arguments += "/r";

                takeOwnProcess.EnableRaisingEvents = true;
                takeOwnProcess.StartInfo = takeOwnStartInfo;
                takeOwnProcess.OutputDataReceived += GrantFullControlProcess_OutputDataReceived;
                takeOwnProcess.ErrorDataReceived += GrantFullControlProcess_OutputDataReceived;

                Logger.WriteLine("Running process: takeown " + takeOwnStartInfo.Arguments + "\n");

                // Start the process.
                takeOwnProcess.Start();
                takeOwnProcess.BeginOutputReadLine();
                takeOwnProcess.BeginErrorReadLine();
                // Wait for the process to exit.
                takeOwnProcess.WaitForExit();

                int exitCode = takeOwnProcess.ExitCode;
                bool takeOwnSuccessful = true;

                // Now we need to see if the process was successful.
                if (exitCode > 0 & !takeOwnProcess.HasExited)
                {
                    takeOwnProcess.Kill();
                    takeOwnSuccessful = false;
                }

                // Now clean up after ourselves.
                takeOwnProcess.Dispose();

                if (!takeOwnSuccessful)
                    Debugger.Break();

                return takeOwnSuccessful;
            }
            public static bool GrantFullControl(string fileName, string userName, bool recursive)
            {
                Process grantFullControlProcess = new Process();
                ProcessStartInfo grantFullControlStartInfo = new ProcessStartInfo();

                grantFullControlStartInfo.FileName = "icacls.exe";

                // Do not write error output to standard stream.
                grantFullControlStartInfo.RedirectStandardError = true;
                // Do not write output to Process.StandardOutput Stream.
                grantFullControlStartInfo.RedirectStandardOutput = true;
                // Do not read input from Process.StandardInput (i/e; the keyboard).
                grantFullControlStartInfo.RedirectStandardInput = false;

                grantFullControlStartInfo.UseShellExecute = false;
                // Do not show a command window.
                grantFullControlStartInfo.CreateNoWindow = true;

                grantFullControlStartInfo.Arguments = fileName + " /grant " + userName + ":(F) ";
                if (recursive) grantFullControlStartInfo.Arguments += "/T";
                grantFullControlProcess.OutputDataReceived += GrantFullControlProcess_OutputDataReceived;
                grantFullControlProcess.ErrorDataReceived += GrantFullControlProcess_OutputDataReceived;

                grantFullControlProcess.EnableRaisingEvents = true;
                grantFullControlProcess.StartInfo = grantFullControlStartInfo;

                Logger.WriteLine("Running process: icacls " + grantFullControlStartInfo.Arguments+"\n");

                // Start the process.
                grantFullControlProcess.Start();
                grantFullControlProcess.BeginOutputReadLine();
                grantFullControlProcess.BeginErrorReadLine();
                grantFullControlProcess.WaitForExit();

                int exitCode = grantFullControlProcess.ExitCode;
                bool grantFullControlSuccessful = true;

                // Now we need to see if the process was successful.
                if (exitCode > 0 & !grantFullControlProcess.HasExited)
                {
                    grantFullControlProcess.Kill();
                    grantFullControlSuccessful = false;
                }

                // Now clean up after ourselves.
                grantFullControlProcess.Dispose();
                return grantFullControlSuccessful;
            }

            private static void GrantFullControlProcess_OutputDataReceived(object sender, DataReceivedEventArgs e)
            {
                if (e.Data != null)
                {
                    Logger.WriteLine(e.Data);
                }
            }

            public static bool ResetPermissions(string fileName)
            {
                Process resetPermissionsProcess = new Process();
                ProcessStartInfo resetPermissionsStartInfo = new ProcessStartInfo();

                resetPermissionsStartInfo.FileName = "icacls.exe";

                // Do not write error output to standard stream.
                resetPermissionsStartInfo.RedirectStandardError = false;
                // Do not write output to Process.StandardOutput Stream.
                resetPermissionsStartInfo.RedirectStandardOutput = false;
                // Do not read input from Process.StandardInput (i/e; the keyboard).
                resetPermissionsStartInfo.RedirectStandardInput = false;

                resetPermissionsStartInfo.UseShellExecute = false;
                // Do not show a command window.
                resetPermissionsStartInfo.CreateNoWindow = true;

                resetPermissionsStartInfo.Arguments = fileName + " /reset";

                resetPermissionsProcess.EnableRaisingEvents = true;
                resetPermissionsProcess.StartInfo = resetPermissionsStartInfo;

                // Start the process.
                resetPermissionsProcess.Start();

                // Wair for the process to finish.
                resetPermissionsProcess.WaitForExit();

                int exitCode = resetPermissionsProcess.ExitCode;
                bool resetPermissionsSuccessful = true;

                // Now we need to see if the process was successful.
                if (exitCode > 0 & !resetPermissionsProcess.HasExited)
                {
                    resetPermissionsProcess.Kill();
                    resetPermissionsSuccessful = false;
                }

                if (!resetPermissionsSuccessful)
                    Debugger.Break();

                // Now clean up after ourselves.
                resetPermissionsProcess.Dispose();
                return resetPermissionsSuccessful;
            }
            public static bool ResetOwner(string fileName)
            {
                Process resetOwnerProcess = new Process();
                ProcessStartInfo resetOwnerStartInfo = new ProcessStartInfo();

                resetOwnerStartInfo.FileName = "icacls.exe";

                // Do not write error output to standard stream.
                resetOwnerStartInfo.RedirectStandardError = false;
                // Do not write output to Process.StandardOutput Stream.
                resetOwnerStartInfo.RedirectStandardOutput = false;
                // Do not read input from Process.StandardInput (i/e; the keyboard).
                resetOwnerStartInfo.RedirectStandardInput = false;

                resetOwnerStartInfo.UseShellExecute = false;
                // Do not show a command window.
                resetOwnerStartInfo.CreateNoWindow = true;

                resetOwnerStartInfo.Arguments = fileName + " /setowner " + "\"" + "NT Service\\TrustedInstaller" + "\"";

                resetOwnerProcess.EnableRaisingEvents = true;
                resetOwnerProcess.StartInfo = resetOwnerStartInfo;

                // Start the process.
                resetOwnerProcess.Start();

                //Wait for the process to finish.
                resetOwnerProcess.WaitForExit();

                int exitCode = resetOwnerProcess.ExitCode;
                bool resetOwnerSuccessful = true;

                // Now we need to see if the process was successful.
                if (exitCode > 0 & !resetOwnerProcess.HasExited)
                {
                    resetOwnerProcess.Kill();
                    resetOwnerSuccessful = false;
                }

                // Now clean up after ourselves.
                resetOwnerProcess.Dispose();
                return resetOwnerSuccessful;
            }
            public static string? LastCmd;
            public static bool ReshackAddRes(string reshackerPath, string filename, string destination, string action, string? resource, string type)
            {
                string cmd = "";

                cmd += " -open " + filename;
                cmd += " -save " + destination;
                cmd += " -action " + action;
                if (resource != null)
                {
                    cmd += " -resource \"" + resource+"\"";
                }
                cmd += " -mask " + type;
                Logger.WriteLine("Running process: " + reshackerPath + " " + cmd + "\n");

                LastCmd = cmd;
                Process reshackFileProcess = new Process();
                ProcessStartInfo reshackFileStartInfo = new ProcessStartInfo
                {
                    FileName = reshackerPath,
                    // Do not write error output to standard stream.
                    RedirectStandardError = true,
                    // Do not write output to Process.StandardOutput Stream.
                    RedirectStandardOutput = true,
                    // Do not read input from Process.StandardInput (i/e; the keyboard).
                    RedirectStandardInput = false,

                    UseShellExecute = true,
                    // Do not show a command window.
                    CreateNoWindow = true,

                    Arguments = cmd
                };
                reshackFileProcess.EnableRaisingEvents = true;
                reshackFileProcess.StartInfo = reshackFileStartInfo;
                reshackFileProcess.OutputDataReceived += GrantFullControlProcess_OutputDataReceived;
                reshackFileProcess.ErrorDataReceived += GrantFullControlProcess_OutputDataReceived;

                // Start the process.
                reshackFileProcess.Start();
                reshackFileProcess.BeginOutputReadLine();
                reshackFileProcess.BeginErrorReadLine();
                // Wait for the process to finish.
                reshackFileProcess.WaitForExit();

                int exitCode = reshackFileProcess.ExitCode;
                bool reshackFileSuccessful = true;

                // Now we need to see if the process was successful.
                if (exitCode != 0)
                {
                    reshackFileProcess.Kill();
                    reshackFileSuccessful = false;
                }

                // Now clean up after ourselves.
                reshackFileProcess.Dispose();
                return reshackFileSuccessful;
            }
            public async static Task<bool> SevenzExtract(string szpath, string destinationdir, string file, string curdir)
            {
                string cmd = "";

                cmd += " x";
                cmd += " -o" + destinationdir;
                cmd += " " + file;

                Logger.WriteLine("Running process: " + szpath + " " + cmd + "\n");

                LastCmd = cmd;
                Environment.CurrentDirectory = curdir;
                Process szFileProcess = new();
                ProcessStartInfo szFileStartInfo = new()
                {
                    FileName = szpath,
                    // Do not write error output to standard stream.
                    RedirectStandardError = true,
                    // Do not write output to Process.StandardOutput Stream.
                    RedirectStandardOutput = true,
                    // Do not read input from Process.StandardInput (i/e; the keyboard).
                    RedirectStandardInput = false,

                    UseShellExecute = true,
                    // Do not show a command window.
                    CreateNoWindow = true,

                    Arguments = cmd
                };
                szFileProcess.EnableRaisingEvents = true;
                szFileProcess.StartInfo = szFileStartInfo;
                szFileProcess.OutputDataReceived += GrantFullControlProcess_OutputDataReceived;
                szFileProcess.ErrorDataReceived += GrantFullControlProcess_OutputDataReceived;

                // Start the process.
                szFileProcess.Start();
                szFileProcess.BeginOutputReadLine();
                szFileProcess.BeginErrorReadLine();
                // Wait for the process to finish.
                szFileProcess.WaitForExit();

                int exitCode = szFileProcess.ExitCode;
                bool szFileSuccessful = true;

                // Now we need to see if the process was successful.
                if (exitCode != 0)
                {
                    szFileProcess.Kill();
                    szFileSuccessful = false;
                }

                // Now clean up after ourselves.
                szFileProcess.Dispose();
                return szFileSuccessful;
            }
            public async static Task<bool> RunAsyncCommands(string szpath, string args, string curdir)
            {

                Logger.WriteLine("Running process: " + szpath + " " + args + "\n");

                Environment.CurrentDirectory = curdir;
                Process szFileProcess = new();
                ProcessStartInfo szFileStartInfo = new()
                {
                    FileName = szpath,
                    // Do not write error output to standard stream.
                    RedirectStandardError = true,
                    // Do not write output to Process.StandardOutput Stream.
                    RedirectStandardOutput = true,
                    // Do not read input from Process.StandardInput (i/e; the keyboard).
                    RedirectStandardInput = false,

                    UseShellExecute = true,
                    // Do not show a command window.
                    CreateNoWindow = true,

                    Arguments = args
                };
                szFileProcess.EnableRaisingEvents = true;
                szFileProcess.StartInfo = szFileStartInfo;
                szFileProcess.OutputDataReceived += GrantFullControlProcess_OutputDataReceived;
                szFileProcess.ErrorDataReceived += GrantFullControlProcess_OutputDataReceived;

                // Start the process.
                szFileProcess.Start();
                szFileProcess.BeginOutputReadLine();
                szFileProcess.BeginErrorReadLine();
                // Wait for the process to finish.
                szFileProcess.WaitForExit();

                int exitCode = szFileProcess.ExitCode;
                bool szFileSuccessful = true;

                // Now we need to see if the process was successful.
                if (exitCode != 0)
                {
                    szFileProcess.Kill();
                    szFileSuccessful = false;
                }

                // Now clean up after ourselves.
                szFileProcess.Dispose();
                return szFileSuccessful;
            }

        }
    }
}
