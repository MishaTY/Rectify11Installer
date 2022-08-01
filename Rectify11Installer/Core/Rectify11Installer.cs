using Microsoft.Win32;
using Rectify11Installer.Core;
using Rectify11Installer.Win32.Rectify11;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;

namespace Rectify11Installer
{
    public class RectifyInstaller : IRectifyInstaller
    {
        #region Variables
        private IRectifyInstallerWizard? Wizard;
        private FrmWizard frmWizard = new();
        private bool isInstalling = true;
        static readonly string rectify11Folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), "Rectify11");
        static readonly string r11Files = Path.Combine(rectify11Folder, "files");
        static readonly string windir = Environment.GetFolderPath(Environment.SpecialFolder.Windows);
        static readonly string sysdir = Environment.SystemDirectory;
        #endregion
        #region Interface implementation
        public async Task<bool> InstallUserMode(IRectifyInstalllerInstallOptions options, IRectifyInstalllerThemeOptions themeOptions, IRectifyInstalllerEPOptions epOptions)
        {
            // extract the files
            File.WriteAllBytes(Path.Combine(rectify11Folder, "7za.exe"), Properties.Resources._7za_exe);
            File.WriteAllBytes(Path.Combine(rectify11Folder, "files.7z"), Properties.Resources.files_7z);
            if (Directory.Exists(r11Files))
            {
                Directory.Delete(r11Files, true);
            }
            await Task.Run(() => PatcherHelper.SevenzExtract(Path.Combine(rectify11Folder, "7za.exe"),"x", null, r11Files, Path.Combine(rectify11Folder, "files.7z"), rectify11Folder));

            // themes
            if (Directory.Exists(Path.Combine(windir, @"Resources\Themes\rectify11")))
            {
                Directory.Delete(Path.Combine(windir, @"Resources\Themes\rectify11"), true);
            }
            Directory.Move(rectify11Folder + @"\files\themes\rectify11", Path.Combine(windir, @"Resources\Themes\rectify11"));
            DirectoryInfo d = new(Path.Combine(r11Files, "themes"));
            FileInfo[] Files = d.GetFiles("*.theme");
            foreach (FileInfo file in Files)
            {
                File.Copy(file.FullName, Path.Combine(windir, "Resources", "Themes", file.Name), true);
            }
            var basee = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
            var themes = basee.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\ThemeManager", RegistryKeyPermissionCheck.ReadWriteSubTree);
            if ((themes != null) && (!File.Exists(Path.Combine(sysdir, "SecureUxTheme.dll"))))
            {
                if (themeOptions.Light)
                    themes.SetValue("DllName", @"%SystemRoot%\resources\Themes\rectify11\Aero.msstyles", RegistryValueKind.String);
                else if (themeOptions.Dark)
                    themes.SetValue("DllName", @"%SystemRoot%\resources\Themes\rectify11\Dark.msstyles", RegistryValueKind.String);
                else if (themeOptions.Black)
                    themes.SetValue("DllName", @"%SystemRoot%\resources\Themes\rectify11\Black.msstyles", RegistryValueKind.String);
            }
            themes = basee.OpenSubKey(@"Control Panel\Desktop", RegistryKeyPermissionCheck.ReadWriteSubTree);
            if (themes != null)
            {
                themes.SetValue(@"WallpaperStyle", 10.ToString());
                themes.SetValue(@"TileWallpaper", 0.ToString());
                if ((themeOptions.Dark) || (themeOptions.Black))
                    themes.SetValue(@"Wallpaper", @"%windir%\Web\Wallpaper\Rectify11\img19.jpg");
                else if (themeOptions.Light)
                    themes.SetValue(@"Wallpaper", @"%windir%\Web\Wallpaper\Rectify11\img0.jpg");
            }
            basee.Close();

            // context menu
            if (!Directory.Exists(Path.Combine(windir, "contextmenus")))
                Directory.Move(Path.Combine(r11Files, "contextmenus"), Path.Combine(windir, "contextmenus"));
            await Task.Run(() => PatcherHelper.RunAsyncCommands("shell.exe", "-r -i -s", Path.Combine(windir, @"contextmenus\nilesoft-shell-1.6")));

            // disable display timeout
            await Task.Run(() => PatcherHelper.RunAsyncCommands("powercfg.exe", "-change -monitor-timeout-ac 0", sysdir));
            await Task.Run(() => PatcherHelper.RunAsyncCommands("powercfg.exe", "-change -monitor-timeout-dc 0", sysdir));

            // create scheduled tasks
            await Task.Run(() => PatcherHelper.RunAsyncCommands("schtasks.exe", "/create /tn mfe /xml " + rectify11Folder + @"\files\mfe.xml", sysdir));
            await Task.Run(() => PatcherHelper.RunAsyncCommands("schtasks.exe", "/create /tn asdf /xml " + rectify11Folder + @"\files\asdf.xml", sysdir));
            await Task.Run(() => PatcherHelper.RunAsyncCommands("schtasks.exe", "/create /tn micafix /xml " + rectify11Folder + @"\files\micafix.xml", sysdir));

            // mfe runtime
            if (!Directory.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), @"dotnet\shared\Microsoft.NETCore.App\3.1.27")))
                await Task.Run(() => PatcherHelper.RunAsyncCommands(Path.Combine(r11Files, "3.1core.exe"), "/install /quiet /norestart", rectify11Folder));

            // mfe
            if (!Directory.Exists(Path.Combine(windir, "MicaForEveryone")))
                Directory.Move(Path.Combine(r11Files, "MicaForEveryone"), Path.Combine(windir, "MicaForEveryone"));

            // mfe config
            if (themeOptions.Light)
                File.Copy(Path.Combine(r11Files, "light.conf"), Path.Combine(windir, "MicaForEveryone", "MicaForEveryone.conf"), true);
            else if (themeOptions.Dark)
                File.Copy(Path.Combine(r11Files, "dark.conf"), Path.Combine(windir, "MicaForEveryone", "MicaForEveryone.conf"), true);
            else if (themeOptions.Black)
                File.Copy(Path.Combine(r11Files, "black.conf"), Path.Combine(windir, "MicaForEveryone", "MicaForEveryone.conf"), true);

            // fix.reg for fixing classic theme colors
            await Task.Run(() => PatcherHelper.RunAsyncCommands("reg.exe", "import " + rectify11Folder + @"\files\FIX.reg", rectify11Folder));

            // cursors
            await Task.Run(() => PatcherHelper.RunAsyncCommands("rundll32.exe", "setupapi,InstallHinfSection DefaultInstall 132 " + rectify11Folder + @"\files\cursors\install.inf", rectify11Folder));
            await Task.Run(() => PatcherHelper.RunAsyncCommands("rundll32.exe", "setupapi,InstallHinfSection DefaultInstall 132 " + rectify11Folder + @"\files\cursors\linstall.inf", rectify11Folder));
            await Task.Run(() => PatcherHelper.RunAsyncCommands("rundll32.exe", "setupapi,InstallHinfSection DefaultInstall 132 " + rectify11Folder + @"\files\cursors\xlinstall.inf", rectify11Folder));

            // explorerpatcher
            if (options.ShouldInstallExplorerPatcher)
            {
                Process process = Process.Start(rectify11Folder + @"\files\ep_setup.exe");
                await process.WaitForExitAsync();
                await PatcherHelper.RunAsyncCommands("regsvr32.exe", "/s \"%PROGRAMFILES%\\ExplorerPatcher\\ExplorerPatcher.amd64.dll\"", rectify11Folder);
                await Task.Run(() => PatcherHelper.RunAsyncCommands("reg.exe", "import " + rectify11Folder + @"\files\ep\basic.reg", rectify11Folder));
                if (epOptions.w10)
                    await Task.Run(() => PatcherHelper.RunAsyncCommands("reg.exe", "import " + rectify11Folder + @"\files\ep\w10start.reg", rectify11Folder));
                else if (epOptions.w11)
                    await Task.Run(() => PatcherHelper.RunAsyncCommands("reg.exe", "import " + rectify11Folder + @"\files\ep\w11start.reg", rectify11Folder));
                if (epOptions.w10TaskB)
                    await Task.Run(() => PatcherHelper.RunAsyncCommands("reg.exe", "import " + rectify11Folder + @"\files\ep\w10taskb.reg", rectify11Folder));
                if (epOptions.micaExplorer)
                    await Task.Run(() => PatcherHelper.RunAsyncCommands("reg.exe", "import " + rectify11Folder + @"\files\ep\micaexpl.reg", rectify11Folder));
            }

            // uxtheme
            TaskDialogPage pg;
            if (File.Exists(Path.Combine(sysdir, "SecureUxTheme.dll")))
            {
                pg = new TaskDialogPage()
                {
                    Icon = TaskDialogIcon.Information,
                    Text = "Since you have SecureUxTheme installed, you have to manually apply the theme using ThemeTool.",
                    Heading = "Last step",
                    Caption = "Info",
                };
                TaskDialog.ShowDialog(frmWizard, pg);
            }
            else if (!File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), @"UltraUXThemePatcher\uninstall.exe")))
            {
                Process process = Process.Start(rectify11Folder + @"\files\UltraUXThemePatcher_4.3.4.exe");
                await process.WaitForExitAsync();
            }
            try
            {
#pragma warning disable SYSLIB0014 // Type or member is obsolete
                using WebClient wc = new();
#pragma warning restore SYSLIB0014 // Type or member is obsolete
                wc.DownloadFileAsync(new Uri("https://aka.ms/vs/17/release/vc_redist.x64.exe"), Path.Combine(rectify11Folder, "vc17.exe"));
                Process process = Process.Start(rectify11Folder + @"\vc17.exe", "/install /quiet /norestart");
                await process.WaitForExitAsync();
            }
            catch
            {

            }

            return true;
        }

        public async void Install(IRectifyInstalllerInstallOptions options, IRectifyInstalllerThemeOptions themeOptions)
        {
            isInstalling = true;
            if (Wizard == null)
            {
                throw new Exception("SetParentWizard() in IRectifyInstaller was not called!");
            }

            try
            {
                InstallStatus.IsRectify11Installed = true;

                #region Setup
                Wizard.SetProgress(0);
                Wizard.SetProgressText("Initializing...");
                var backupDir = Path.Combine(rectify11Folder, "Backup");
                #endregion

                var patches = Patches.GetAll();
                int i = 0;
                foreach (var item in patches)
                {
                    if (item.DisableOnSafeMode && options.DoSafeInstall)
                    {

                    }
                    else
                    {
                        //get the package

                        var usr = GetAMD64Package(item.WinSxSPackageName);
                        if (usr == null)
                        {
                            Logger.Warn("Cannot find package: " + item.WinSxSPackageName + ", which is needed to patch " + item.DllName);
                            continue;
                        }

                        Wizard.SetProgress(i * 100 / patches.Length);
                        Wizard.SetProgressText("Patching file: " + item.DllName);

                        var WinSxSFilePath = usr.Path + @"\" + item.DllName;
                        string WinsxsDir = Path.GetFileName(usr.Path);
                        string file = WinsxsDir + "/" + item.DllName;

                        string fileProper = Path.Combine(rectify11Folder, "Tmp", file); //relative path to the file location
                        string backupDirW = backupDir + "/" + WinsxsDir; //backup dir where the file is located at

                        if (!File.Exists(WinSxSFilePath))
                        {
                            Logger.Warn("Cannot find path in package: " + WinSxSFilePath + ", which is needed to patch " + item.DllName);
                            continue;
                        }

                        if (!File.Exists(item.Systempath))
                        {
                            Logger.Warn("Hardlink target in package: " + item.WinSxSPackageName + ", which is not found at" + item.Systempath);
                            continue;
                        }

                        Directory.CreateDirectory(Path.Combine(rectify11Folder, "Tmp") + WinsxsDir);
                        File.Copy(WinSxSFilePath, fileProper, true);

                        Directory.CreateDirectory(backupDirW);

                        if (!File.Exists(backupDirW + "/" + item.DllName))
                        {
                            File.Copy(WinSxSFilePath, backupDirW + "/" + item.DllName, true);

                            //for now: we will only patch files that don't exist in the backup directory
                            //this is to save time during developent and avoid overwriting orginal files with modified ones

                            foreach (var patch in item.PatchInstructions)
                            {
                                var r = rectify11Folder + @"\files\" + patch.Resource;
                                if (string.IsNullOrEmpty(patch.Resource))
                                    r = null;

                                //This is where we mod the file
                                if (!PatcherHelper.ReshackAddRes(r11Files + @"\ResourceHacker.exe",
                                    fileProper,
                                    fileProper,
                                    patch.Action, //"addoverwrite",
                                    r,
                                    patch.GroupAndLocation))//ICONGROUP,1,0
                                {
                                    Wizard.CompleteInstaller(RectifyInstallerWizardCompleteInstallerEnum.Fail, isInstalling, $"Resource hacker failed at DLL: {item.DllName}\nCommand line:\n" + PatcherHelper.LastCmd + "\nSee installer.log for more information");
                                    return;
                                }
                            }

                            ReplaceFileInPackage(usr, item.Systempath, fileProper);

                            i++;
                        }
                    }
                }

                //So instead of patching bootux.dll on main windows drive through reshack, I just took 25126 bootux, and made the installer directly copy it, 
                //and its mui directly. This will do 2 things, 1. 25126 bootux works correctly even in win10, so, it will give immersive boot menu, the win11 icon instead of generic OS icon,
                //and 2. For some reason patching bootux that way breaks the recovery menu in new copper builds, it wont happen with this.
                File.Copy(rectify11Folder + @"\files\bootux.dll", Path.Combine(sysdir, "bootux.dll"), true);
                File.Copy(rectify11Folder + @"\files\bootux.dll.mui", Path.Combine(sysdir, @"en-us\bootux.dll.mui"), true);

                var basee = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
                var winre = basee.OpenSubKey(@"SOFTWARE\Rectify11", RegistryKeyPermissionCheck.ReadWriteSubTree);
                if (winre != null)
                {
                    var b = winre.GetValue("WinREPatchedVer");
                    if (b == null)
                    {
                        //======================================= WinRE Modification ===========================================//

                        //This will make sure that winre.wim exists in C:\Recovery, in case the user had it disabled or deleted before.
                        await Task.Run(() => PatcherHelper.RunAsyncCommands("reagentc.exe", "/enable", sysdir));
                        if (File.Exists(@"C:\Recovery\WindowsRE\Winre.wim"))
                        {
                            File.Copy(@"C:\Recovery\WindowsRE\Winre.wim", Path.Combine(sysdir, @"Recovery\Winre.wim"), true);
                            Wizard.SetProgressText("Mounting WinRE");

                            //mounting winre
                            await Task.Run(() => PatcherHelper.RunAsyncCommands("dism.exe", "/mount-image /imagefile:" + Path.Combine(sysdir, @"Recovery\Winre.wim") + " /index:1 /mountdir:" + rectify11Folder + @"\files\WinReMount", sysdir));
                            Wizard.SetProgressText("Patching WinRE files");

                            //copying or patching important files only, no need to patch entire winre
                            File.Copy(windir + @"\regedit.exe", rectify11Folder + @"\files\WinReMount\Windows\regedit.exe", true);
                            File.Copy(rectify11Folder + @"\files\rectify11_wallpapers\img0.jpg", rectify11Folder + @"\files\WinReMount\Windows\System32\winre.jpg", true);
                            File.Copy(sysdir + @"\cmd.exe", rectify11Folder + @"\files\WinReMount\Windows\System32\cmd.exe", true);
                            File.Copy(windir + @"\notepad.exe", rectify11Folder + @"\files\WinReMount\Windows\notepad.exe", true);
                            File.Copy(sysdir + @"\uxinit.dll", rectify11Folder + @"\files\WinReMount\Windows\System32\uxinit.dll", true);
                            File.Copy(sysdir + @"\bootux.dll", rectify11Folder + @"\files\WinReMount\Windows\System32\bootux.dll", true);
                            File.Copy(sysdir + @"\rstrui.exe", rectify11Folder + @"\files\WinReMount\Windows\System32\rstrui.exe", true);
                            File.Copy(rectify11Folder + @"\files\winpeshl.exe", rectify11Folder + @"\files\WinReMount\Windows\System32\winpeshl.exe", true);
                            File.Copy(sysdir + @"\themeui.dll", rectify11Folder + @"\files\WinReMount\Windows\System32\themeui.dll", true);
                            File.Copy(sysdir + @"\uxtheme.dll", rectify11Folder + @"\files\WinReMount\Windows\System32\uxtheme.dll", true);
                            File.Copy(rectify11Folder + @"\files\winpeshl.exe.mui", rectify11Folder + @"\files\WinReMount\Windows\System32\en-us\winpeshl.exe.mui", true);
                            File.Copy(sysdir + @"\en-us\bootux.dll.mui", rectify11Folder + @"\files\WinReMount\Windows\System32\en-us\bootux.dll.mui", true);
                            File.Copy(windir + @"\Resources\themes\rectify11\aero.msstyles", rectify11Folder + @"\files\WinreMount\Windows\Resources\themes\aero\aero.msstyles", true);

                            //for installing segvar fonts in winre
                            await Task.Run(() => PatcherHelper.RunAsyncCommands("reg.exe", "load " + @"HKLM\tempreg" + " " + rectify11Folder + @"\files\WinReMount\Windows\System32\config\SOFTWARE", sysdir));
                            await Task.Run(() => PatcherHelper.RunAsyncCommands("reg.exe", "import " + rectify11Folder + @"\files\winre.reg", sysdir));
                            await Task.Run(() => PatcherHelper.RunAsyncCommands("reg.exe", "unload " + @"HKLM\tempreg", sysdir));

                            //Adding segoe ui variable fonts to WinRE
                            File.Copy(rectify11Folder + @"\files\segvar\SegoeUI-VF.ttf", rectify11Folder + @"\files\WinReMount\Windows\Fonts\SegoeUI-VF.ttf", true);
                            File.Copy(rectify11Folder + @"\files\segvar\Segoe-UI-Variable-Static-Display-Semibold.ttf", rectify11Folder + @"\files\WinReMount\Windows\Fonts\Segoe-UI-Variable-Static-Display-Semibold.ttf", true);
                            File.Copy(rectify11Folder + @"\files\segvar\Segoe-UI-Variable-Static-Small-Semilight.ttf", rectify11Folder + @"\files\WinReMount\Windows\Fonts\Segoe-UI-Variable-Static-Small-Semilight.ttf", true);
                            File.Copy(rectify11Folder + @"\files\segvar\Segoe-UI-Variable-Static-Small.ttf", rectify11Folder + @"\files\WinReMount\Windows\Fonts\Segoe-UI-Variable-Static-Small.ttf", true);
                            File.Copy(rectify11Folder + @"\files\segvar\Segoe-UI-Variable-Static-Text-Light.ttf", rectify11Folder + @"\files\WinReMount\Windows\Fonts\Segoe-UI-Variable-Static-Text-Light.ttf", true);
                            File.Copy(rectify11Folder + @"\files\segvar\Segoe-UI-Variable-Static-Text-Semibold.ttf", rectify11Folder + @"\files\WinReMount\Windows\Fonts\Segoe-UI-Variable-Static-Text-Semibold.ttf", true);

                            Wizard.SetProgressText("Unmounting WinRE");
                            //unmounting image
                            await Task.Run(() => PatcherHelper.RunAsyncCommands("dism.exe", "/unmount-image /mountdir:" + rectify11Folder + @"\files\WinReMount" + " /commit", sysdir));
                            Wizard.SetProgressText("Setting WinRE path");

                            //This is to make sure that our changes are actually saved in WinRE.
                            Directory.Delete(@"C:\Recovery", true);
                            await Task.Run(() => PatcherHelper.RunAsyncCommands("reagentc.exe", "/disable", sysdir));
                            await Task.Run(() => PatcherHelper.RunAsyncCommands("reagentc.exe", "/setreimage /path " + Path.Combine(sysdir, "Recovery"), sysdir));
                            await Task.Run(() => PatcherHelper.RunAsyncCommands("reagentc.exe", "/enable", sysdir));

                            winre.SetValue("WinREPatchedVer", "3.0");
                        }

                    }

                }


                Wizard.SetProgress(99);
                Wizard.SetProgressText("Installing other features");
                if (options.ShouldInstallWinver)
                {
                    PatcherHelper.TakeOwnership(Path.Combine(sysdir, "winver.exe"), false);
                    PatcherHelper.GrantFullControl(Path.Combine(sysdir, "winver.exe"), "Everyone", false);
                    if (File.Exists(rectify11Folder + @"\backup\winver_backup.exe"))
                    {
                        File.Copy(Path.Combine(sysdir, "winver.exe"), rectify11Folder + @"\backup\winver_backup.exe", true);
                        File.Copy(rectify11Folder + @"\files\winver.exe", Path.Combine(sysdir, "winver.exe"), true);
                    }
                }
                if (options.ShouldInstallWallpaper)
                {
                    if (Directory.Exists(windir + @"\Web\Wallpaper\Rectify11"))
                        Directory.Delete(windir + @"\Web\Wallpaper\Rectify11", true);
                    Directory.Move(rectify11Folder + @"\files\rectify11_wallpapers", windir + @"\Web\Wallpaper\Rectify11");
                }
                var themes = basee.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\RunOnce", RegistryKeyPermissionCheck.ReadWriteSubTree);
                if (themes != null)
                {
                    if (themeOptions.Light)
                        themes.SetValue("Rectify11", @"%WINDIR%\Resources\Themes\lightrectified.theme", RegistryValueKind.String);
                    else if (themeOptions.Dark)
                        themes.SetValue("Rectify11", @"%WINDIR%\Resources\Themes\darkrectified.theme", RegistryValueKind.String);
                    else if (themeOptions.Black)
                        themes.SetValue("Rectify11", @"%WINDIR%\Resources\Themes\blacknonhighcontrastribbon.theme", RegistryValueKind.String);
                }
                basee.Close();

                if (options.ShouldInstallASDF)
                {
                    File.Copy(rectify11Folder + @"\files\AccentColorizer.exe", windir + @"\AccentColorizer.exe", true);
                }
                Wizard.CompleteInstaller(RectifyInstallerWizardCompleteInstallerEnum.Success, isInstalling, "");
                Directory.Delete(rectify11Folder + @"\files", true);
                File.Delete(rectify11Folder + @"\files.7z");
                File.Delete(rectify11Folder + @"\7za.exe");
                return;
            }
            catch (Exception ex)
            {
                Wizard.CompleteInstaller(RectifyInstallerWizardCompleteInstallerEnum.Fail, isInstalling, ex.ToString());
            }
        }
        public void Uninstall(IRectifyInstalllerUninstallOptions options)
        {
            isInstalling = false;
            if (Wizard == null)
            {
                throw new Exception("SetParentWizard() in IRectifyInstaller was not called!");
            }

            try
            {
                #region Setup
                Wizard.SetProgressText("Taking ownership of system files");
                Wizard.SetProgress(1);
                var backupDir = @"C:\Windows\Rectify11\Backup";
                #endregion
                var patches = Patches.GetAll();
                int i = 0;
                foreach (var item in patches)
                {
                    Wizard.SetProgress(i * 100 / patches.Length);
                    Wizard.SetProgressText("Restoring file: " + item.DllName);

                    var usr = GetAMD64Package(item.WinSxSPackageName);
                    if (usr == null)
                    {
                        Logger.Warn("Cannot find package: " + item.WinSxSPackageName + ", which is needed to patch " + item.DllName);
                    }
                    else
                    {
                        var backupFilePath = backupDir + @"\" + Path.GetFileName(usr.Path) + @"\" + item.DllName;

                        if (!File.Exists(backupFilePath))
                        {
                            Logger.Warn("File backup path does not exist: " + backupFilePath);
                        }
                        else
                        {
                            ReplaceFileInPackage(usr, item.Systempath, backupFilePath);
                        }
                    }
                    i++;
                }

                Wizard.SetProgressText("Removing optional features");
                Wizard.SetProgress(98);



                if (options.RestoreWallpapers)
                {
                    if (Directory.Exists(Path.Combine(windir, @"Web\Wallpaper\Rectify11")))
                    Directory.Delete(Path.Combine(windir, @"Web\Wallpaper\Rectify11"), true);
                }


                if (options.RemoveWinver)
                {
                    File.Copy(rectify11Folder + @"\backup\winver_backup.exe", Path.Combine(windir, @"System32\winver.exe"), true);
                }
                if (options.RemoveASDF)
                {
                    if (File.Exists(Path.Combine(windir, "AccentColorizer.exe")))
                    {
                        File.Delete(Path.Combine(windir, "AccentColorizer.exe"));
                    }
                }

                // mfe
                if (Directory.Exists(Path.Combine(windir, "MicaForEveryone")))
                {
                    Directory.Delete(Path.Combine(windir, "MicaForEveryone"), true);
                }
                Wizard.SetProgress(99);
                Wizard.SetProgressText("Removing old backups");
                Directory.Delete(Path.Combine(windir, @"Rectify11"), true);

                InstallStatus.IsRectify11Installed = false;
                Wizard.CompleteInstaller(RectifyInstallerWizardCompleteInstallerEnum.Success, isInstalling, "");
                return;
            }
            catch (Exception ex)
            {
                Wizard.CompleteInstaller(RectifyInstallerWizardCompleteInstallerEnum.Fail, isInstalling, ex.ToString());
            }
        }
        public void SetParentWizard(IRectifyInstallerWizard wiz)
        {
            Wizard = wiz;
        }
        #endregion
        #region Private methods
        private void ReplaceFileInPackage(Package usr, string hardlinkTarget, string source)
        {
            string dllName = Path.GetFileName(source);
            var WinSxSFilePath = usr.Path + @"\" + dllName;

            //Rename old hardlink
            try
            {
                if (File.Exists(hardlinkTarget + ".bak"))
                    File.Delete(hardlinkTarget + ".bak");
            }
            catch { }
            File.Move(hardlinkTarget, hardlinkTarget + ".bak", true);

            //Delete old hardlink
            ScheduleForDeletion(hardlinkTarget + ".bak");

            //rename old file
            File.Move(WinSxSFilePath, WinSxSFilePath + ".bak", true);

            //copy new file over
            File.Move(source, WinSxSFilePath, true);

            //create hardlink
            if (!Win32.NativeMethods.CreateHardLinkA(hardlinkTarget, WinSxSFilePath, IntPtr.Zero))
            {
                if (Wizard != null)
                    Wizard.CompleteInstaller(RectifyInstallerWizardCompleteInstallerEnum.Fail, isInstalling, "CreateHardLinkW() failed: " + new Win32Exception().Message);
                throw new Exception("failure while calling MoveFileEx()");
            }

            ScheduleForDeletion(WinSxSFilePath + ".bak");
        }
        private void ScheduleForDeletion(string path)
        {
            if (!File.Exists(path))
                return;

            //schedule .bak for deletion
            try
            {
                File.Delete(path);
            }
            catch
            {
                //delete it first
                if (!Win32.NativeMethods.MoveFileEx(path, null, Win32.NativeMethods.MoveFileFlags.MOVEFILE_DELAY_UNTIL_REBOOT))
                {
                    if (Wizard != null)
                        Wizard.CompleteInstaller(RectifyInstallerWizardCompleteInstallerEnum.Fail, isInstalling, "MoveFileEx() failed: " + new Win32Exception().Message);
                    throw new Exception("failure while calling MoveFileEx()");
                }
            }
        }
        private Package? GetAMD64Package(string name)
        {
            var usercpl = FindPackage(name);
            if (usercpl.Count == 0)
            {
                return null;
            }
            foreach (var item in usercpl)
            {
                if (item.Arch == PackageArch.Amd64)
                {
                    return item;
                }
            }
            return null;
        }
        private List<Package> FindPackage(string name)
        {
            List<Package> p = new List<Package>();
            var build = Environment.OSVersion.Version.Build.ToString();
            foreach (var item in Directory.GetDirectories(@"C:\Windows\WinSxS\"))
            {
                if (item.Contains(build) && item.Contains(name + "_"))
                {
                    var path = item.Replace(@"C:\Windows\WinSxS\", "");
                    if (path.StartsWith("amd64_"))
                    {
                        p.Add(new Package(item, PackageArch.Amd64));
                    }
                    else if (path.StartsWith("wow64_"))
                    {
                        p.Add(new Package(item, PackageArch.Wow64));
                    }
                }
            }

            return p;
        }
        #endregion
    }
}
