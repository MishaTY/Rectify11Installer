using Microsoft.Win32;
using Rectify11Installer.Core;
using Rectify11Installer.Win32.Rectify11;
using System.ComponentModel;

namespace Rectify11Installer
{
    public class RectifyInstaller : IRectifyInstaller
    {
        private IRectifyInstallerWizard? Wizard;
        private bool IsInstalling = true;
        #region Interface implementation
        public async void Install(IRectifyInstalllerInstallOptions options, IRectifyInstalllerThemeOptions themeOptions)
        {
            IsInstalling = true;
            if (Wizard == null)
            {
                throw new Exception("SetParentWizard() in IRectifyInstaller was not called!");
            }

            try
            {
                InstallStatus.IsRectify11Installed = true;

                string tempfldr = @"C:\Windows\Rectify11";
                #region Setup
                Wizard.SetProgress(0);
                Wizard.SetProgressText("Initializing...");
                var backupDir = @"C:\Windows\Rectify11\Backup";
                //why
               //File.Copy(Application.ExecutablePath, @"C:\Windows\Rectify11\rectify11setup.exe", true);
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

                        string fileProper = "C:/Windows/Rectify11/Tmp/" + file; //relative path to the file location
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

                        Directory.CreateDirectory("C:/Windows/Rectify11/Tmp/" + WinsxsDir);
                        File.Copy(WinSxSFilePath, fileProper, true);

                        Directory.CreateDirectory(backupDirW);

                        if (!File.Exists(backupDirW + "/" + item.DllName))
                        {
                            File.Copy(WinSxSFilePath, backupDirW + "/" + item.DllName, true);

                            //for now: we will only patch files that don't exist in the backup directory
                            //this is to save time during developent and avoid overwriting orginal files with modified ones

                            foreach (var patch in item.PatchInstructions)
                            {
                                var r = tempfldr + @"\files\" + patch.Resource;
                                if (string.IsNullOrEmpty(patch.Resource))
                                    r = null;

                                //This is where we mod the file
                                if (!PatcherHelper.ReshackAddRes(tempfldr + @"\files\ResourceHacker.exe",
                                    fileProper,
                                    fileProper,
                                    patch.Action, //"addoverwrite",
                                    r,
                                    patch.GroupAndLocation))//ICONGROUP,1,0
                                {
                                    Wizard.CompleteInstaller(RectifyInstallerWizardCompleteInstallerEnum.Fail, IsInstalling, $"Resource hacker failed at DLL: {item.DllName}\nCommand line:\n" + PatcherHelper.LastCmd + "\nSee installer.log for more information");
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
                File.Copy(tempfldr + @"\files\bootux.dll", @"C:\Windows\System32\bootux.dll", true);
                File.Copy(tempfldr + @"\files\bootux.dll.mui", @"C:\Windows\System32\en-us\bootux.dll.mui", true);
                await Task.Run(() => PatcherHelper.RunAsyncCommands("resourceHacker.exe", "-open " + @"C:\Windows\Branding\basebrd\Basebrd.dll" + " -save " + @"C:\Windows\Branding\Basebrd\Basebrd.dll" + " -action addoverwrite -res " + tempfldr + @"\files\basebrd.res" + " -mask IMAGE", tempfldr + @"\files"));
                await Task.Run(() => PatcherHelper.RunAsyncCommands("resourceHacker.exe", "-open " + @"C:\Windows\Branding\shellbrd\Shellbrd.dll" + " -save " + @"C:\Windows\Branding\shellbrd\shellbrd.dll" + " -action addoverwrite -res " + tempfldr + @"\files\shellbrd.res" + " -mask IMAGE", tempfldr + @"\files"));
                if (File.Exists(@"C:\Windows\notepad.exe"))
                {
                    PatcherHelper.TakeOwnership(@"C:\Windows\notepad.exe", false);
                    PatcherHelper.GrantFullControl(@"C:\Windows\notepad.exe", "Everyone", false);
                    await Task.Run(() => PatcherHelper.RunAsyncCommands("resourceHacker.exe", "-open " + @"C:\Windows\notepad.exe" + " -save " + @"C:\Windows\notepad.exe" + " -action addoverwrite -res " + tempfldr + @"\files\notepad.res" + " -mask ICONGROUP", tempfldr + @"\files"));
                }
                if (File.Exists(@"C:\Windows\System32\notepad.exe"))
                {
                    PatcherHelper.TakeOwnership(@"C:\Windows\System32\notepad.exe", false);
                    PatcherHelper.GrantFullControl(@"C:\Windows\System32\notepad.exe", "Everyone", false);
                    await Task.Run(() => PatcherHelper.RunAsyncCommands("resourceHacker.exe", "-open " + @"C:\Windows\System32\notepad.exe" + " -save " + @"C:\Windows\System32\notepad.exe" + " -action addoverwrite -res " + tempfldr + @"\files\notepad.res" + " -mask ICONGROUP", tempfldr + @"\files"));
                }
                //======================================= WinRE Modification ===========================================//

                //This will make sure that winre.wim exists in C:\Recovery, in case the user had it disabled/deleted before.
                await Task.Run(() => PatcherHelper.RunAsyncCommands("reagentc.exe", "/enable", @"C:\Windows\System32"));
                if (File.Exists(@"C:\Recovery\WindowsRE\Winre.wim"))
                {
                    File.Copy(@"C:\Recovery\WindowsRE\Winre.wim", @"C:\Windows\System32\Recovery\Winre.wim", true);
                    Wizard.SetProgressText("Mounting WinRE");

                    //mounting winre
                    await Task.Run(() => PatcherHelper.RunAsyncCommands("dism.exe", "/mount-image /imagefile:" + @"C:\Windows\System32\Recovery\Winre.wim" + " /index:1 /mountdir:" + tempfldr + @"\files\WinReMount", @"C:\Windows\System32"));
                    Wizard.SetProgressText("Patching WinRE files");

                    //copying/patching important files only, no need for entire winre
                    File.Copy(@"C:\Windows\regedit.exe", tempfldr + @"\files\WinReMount\Windows\regedit.exe", true);
                    File.Copy(tempfldr + @"\files\rectify11_wallpapers\img0.jpg", tempfldr + @"\files\WinReMount\Windows\System32\winre.jpg", true);
                    File.Copy(tempfldr + @"\files\rectify11_wallpapers\img0.jpg", tempfldr + @"\files\WinReMount\Windows\System32\winpe.jpg", true);
                    File.Copy(@"C:\Windows\System32\cmd.exe", tempfldr + @"\files\WinReMount\Windows\System32\cmd.exe", true);
                    File.Copy(tempfldr + @"\files\notepad.exe", tempfldr + @"\files\WinReMount\Windows\notepad.exe", true);
                    File.Copy(@"C:\Windows\System32\uxinit.dll", tempfldr + @"\files\WinReMount\Windows\System32\uxinit.dll", true);
                    File.Copy(@"C:\Windows\System32\bootux.dll", tempfldr + @"\files\WinReMount\Windows\System32\bootux.dll", true);
                    File.Copy(@"C:\Windows\System32\rstrui.exe", tempfldr + @"\files\WinReMount\Windows\System32\rstrui.exe", true);
                    File.Copy(tempfldr + @"\files\winpeshl.exe", tempfldr + @"\files\WinReMount\Windows\System32\winpeshl.exe", true);
                    File.Copy(@"C:\Windows\System32\themeui.dll", tempfldr + @"\files\WinReMount\Windows\System32\themeui.dll", true);
                    File.Copy(@"C:\Windows\System32\uxtheme.dll", tempfldr + @"\files\WinReMount\Windows\System32\uxtheme.dll", true);
                    File.Copy(tempfldr + @"\files\notepad.exe.mui", tempfldr + @"\files\WinReMount\Windows\en-us\notepad.exe.mui", true);
                    File.Copy(tempfldr + @"\files\winpeshl.exe.mui", tempfldr + @"\files\WinReMount\Windows\System32\en-us\winpeshl.exe.mui", true);
                    File.Copy(@"C:\Windows\System32\en-us\bootux.dll.mui", tempfldr + @"\files\WinReMount\Windows\System32\en-us\bootux.dll.mui", true);
                    File.Copy(@"C:\Windows\Resources\themes\rectify11\aero.msstyles", tempfldr + @"\files\WinreMount\Windows\Resources\themes\aero\aero.msstyles", true);

                    //for installing segvar fonts in winre
                    await Task.Run(() => PatcherHelper.RunAsyncCommands("reg.exe", "load " + @"HKLM\tempreg" + " " + tempfldr + @"\files\WinReMount\Windows\System32\config\SOFTWARE", @"C:\Windows\System32"));
                    await Task.Run(() => PatcherHelper.RunAsyncCommands("reg.exe", "import " + tempfldr + @"\files\winre.reg", @"C:\Windows\system32"));
                    await Task.Run(() => PatcherHelper.RunAsyncCommands("reg.exe", "unload " + @"HKLM\tempreg", @"C:\Windows\System32"));

                    //Adding segoe ui variable fonts to WinRE
                    File.Copy(tempfldr + @"\files\segvar\SegoeUI-VF.ttf", tempfldr + @"\files\WinReMount\Windows\Fonts\SegoeUI-VF.ttf", true);
                    File.Copy(tempfldr + @"\files\segvar\Segoe-UI-Variable-Static-Display-Semibold.ttf", tempfldr + @"\files\WinReMount\Windows\Fonts\Segoe-UI-Variable-Static-Display-Semibold.ttf", true);
                    File.Copy(tempfldr + @"\files\segvar\Segoe-UI-Variable-Static-Small-Semilight.ttf", tempfldr + @"\files\WinReMount\Windows\Fonts\Segoe-UI-Variable-Static-Small-Semilight.ttf", true);
                    File.Copy(tempfldr + @"\files\segvar\Segoe-UI-Variable-Static-Small.ttf", tempfldr + @"\files\WinReMount\Windows\Fonts\Segoe-UI-Variable-Static-Small.ttf", true);
                    File.Copy(tempfldr + @"\files\segvar\Segoe-UI-Variable-Static-Text-Light.ttf", tempfldr + @"\files\WinReMount\Windows\Fonts\Segoe-UI-Variable-Static-Text-Light.ttf", true);
                    File.Copy(tempfldr + @"\files\segvar\Segoe-UI-Variable-Static-Text-Semibold.ttf", tempfldr + @"\files\WinReMount\Windows\Fonts\Segoe-UI-Variable-Static-Text-Semibold.ttf", true);

                    Wizard.SetProgressText("Unmounting WinRE");
                    //unmounting image
                    await Task.Run(() => PatcherHelper.RunAsyncCommands("dism.exe", "/unmount-image /mountdir:" + tempfldr + @"\files\WinReMount" + " /commit", @"C:\Windows\System32"));
                    Wizard.SetProgressText("Setting WinRE path");

                    //This is to make sure that our changes are actually saved in WinRE.
                    Directory.Delete(@"C:\Recovery", true);
                    await Task.Run(() => PatcherHelper.RunAsyncCommands("reagentc.exe", "/disable", @"C:\Windows\System32"));
                    await Task.Run(() => PatcherHelper.RunAsyncCommands("reagentc.exe", "/setreimage /path " + @"C:\Windows\System32\Recovery", @"C:\Windows\System32"));
                    await Task.Run(() => PatcherHelper.RunAsyncCommands("reagentc.exe", "/enable", @"C:\Windows\System32"));
                }


                Wizard.SetProgress(99);
                Wizard.SetProgressText("Installing other features");
                if (options.ShouldInstallWinver)
                {   //for some reason, %windir% doesnt work, so, using C:\Windows instead
                    PatcherHelper.TakeOwnership(@"C:\Windows\System32\winver.exe", false);
                    PatcherHelper.GrantFullControl(@"C:\Windows\System32\winver.exe", "Everyone", false);
                    File.Delete(@"C:\Windows\System32\winver.exe");
                    File.Copy(tempfldr + @"\files\winver.exe", @"C:\Windows\System32\winver.exe", true);
                }
                if (options.ShouldInstallWallpaper)
                {
                    if (Directory.Exists(@"C:\Windows\Web\Wallpaper\Rectify11"))
                        Directory.Delete(@"C:\Windows\Web\Wallpaper\Rectify11", true);
                    Directory.Move(tempfldr + @"\files\rectify11_wallpapers", @"C:\Windows\Web\Wallpaper\Rectify11");
                }
                var basee = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
                var themes = basee.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\RunOnce", RegistryKeyPermissionCheck.ReadWriteSubTree);
                if (themes != null)
                {
                    if (themeOptions.Light)
                        themes.SetValue("Rectify11", @"C:\Windows\Resources\Themes\lightrectified.theme", RegistryValueKind.String);
                    else if (themeOptions.Dark)
                        themes.SetValue("Rectify11", @"C:\Windows\Resources\Themes\darkrectified.theme", RegistryValueKind.String);
                    else if (themeOptions.Black)
                        themes.SetValue("Rectify11", @"C:\Windows\Resources\Themes\blacknonhighcontrastribbon.theme", RegistryValueKind.String);
                }
                basee.Close();

                if (options.ShouldInstallASDF)
                {
                    File.Copy(tempfldr + @"\files\AccentColorizer.exe", @"C:\Windows\AccentColorizer.exe", true);
                }
                Wizard.CompleteInstaller(RectifyInstallerWizardCompleteInstallerEnum.Success, IsInstalling, "");
                Directory.Delete(tempfldr + @"\files", true);
                File.Delete(tempfldr + @"\files.7z");
                File.Delete(tempfldr + @"\7za.exe");
                return;
            }
            catch (Exception ex)
            {
                Wizard.CompleteInstaller(RectifyInstallerWizardCompleteInstallerEnum.Fail, IsInstalling, ex.ToString());
            }
        }
        public void Uninstall(IRectifyInstalllerUninstallOptions options)
        {
            IsInstalling = false;
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

                Wizard.SetProgressText("Restoring old wallpapers and Winver");
                Wizard.SetProgress(0);

                if (options.RestoreWallpapers)
                {
                    if (Directory.Exists(@"C:\Windows\Web\Wallpaper\Rectify11"))
                    {
                        Directory.Delete(@"C:\Windows\Web\Wallpaper\Rectify11", true);
                    }
                }
                File.Copy(@"C:\Windows\Rectify11\files\winver.bak.exe", @"C:\Windows\System32\winver.exe", true);
                if (Directory.Exists(@"C:\Windows\MicaForEveryone"))
                {
                    Directory.Delete(@"C:\Windows\MicaForEveryone", true);
                }
                if (options.RemoveThemesAndThemeTool)
                {
                    if (Directory.Exists(@"C:\Windows\Resources\themes\rectify11"))
                    {
                        Directory.Delete(@"C:\Windows\Resources\themes\rectify11");
                    }
                    if (File.Exists(@"C:\Windows\Resources\theme\lightrectified.theme") && File.Exists(@"C:\Windows\Resources\theme\darkrectified.theme") && File.Exists(@"C:\Windows\Resources\theme\darkcolorized.theme") && File.Exists(@"C:\Windows\Resources\theme\black.theme") && File.Exists(@"C:\Windows\Resources\theme\blacknonhighcontrastribbon.theme"))
                    {
                        File.Delete(@"C:\Windows\Resources\theme\lightrectified.theme");
                        File.Delete(@"C:\Windows\Resources\theme\darkrectified.theme");
                        File.Delete(@"C:\Windows\Resources\theme\darkcolorized.theme");
                        File.Delete(@"C:\Windows\Resources\theme\black.theme");
                        File.Delete(@"C:\Windows\Resources\theme\blacknonhighcontrastribbon.theme");
                    }
                    var basee = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
                    var themes = basee.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\RunOnce", RegistryKeyPermissionCheck.ReadWriteSubTree);
                    if (themes != null)
                    {
                        themes.SetValue("revert", @"C:\Windows\Resources\Themes\aero.theme", RegistryValueKind.String);
                    }
                }
                if (Directory.Exists(@"C:\Windows\contextmenus"))
                {
                    Directory.Delete(@"C:\Windows\contextmenus", true);
                }
                Wizard.SetProgress(99);
                Wizard.SetProgressText("Removing old backups");
                //Directory.Delete(@"C:\Windows\Rectify11", true);

                InstallStatus.IsRectify11Installed = false;
                Wizard.CompleteInstaller(RectifyInstallerWizardCompleteInstallerEnum.Success, IsInstalling, "");
                return;
            }
            catch (Exception ex)
            {
                Wizard.CompleteInstaller(RectifyInstallerWizardCompleteInstallerEnum.Fail, IsInstalling, ex.ToString());
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
                    Wizard.CompleteInstaller(RectifyInstallerWizardCompleteInstallerEnum.Fail, IsInstalling, "CreateHardLinkW() failed: " + new Win32Exception().Message);
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
                        Wizard.CompleteInstaller(RectifyInstallerWizardCompleteInstallerEnum.Fail, IsInstalling, "MoveFileEx() failed: " + new Win32Exception().Message);
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
        private static List<Package> FindPackage(string name)
        {
            List<Package> p = new ();
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
