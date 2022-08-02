namespace Rectify11Installer.Core
{
    public enum PackageArch
    {
        Amd64,
        Wow64
    }
    public class PatchDef
    {
        /// <summary>
        /// The package name. Ex: microsoft-windows-usercpl
        /// </summary>
        public string WinSxSPackageName { get; set; }
        /// <summary>
        /// The package arch
        /// </summary>
        public PackageArch WinSxSPackageArch { get; set; }
        /// <summary>
        /// The name of the DLL in the package to be patched. Example: usercpl.dll.mun
        /// </summary>
        public string DllName { get; set; }
        /// <summary>
        /// The path where the hardlink by default points to. Example: C:\windows\systemresources\usercpl.dll.mun
        /// </summary>
        public string Systempath { get; set; }
        /// <summary>
        /// What the patcher should do
        /// </summary>
        public PatchInstruction[] PatchInstructions { get; set; }
        /// <summary>
        /// Skip this patch when safe mode option is selected?
        /// </summary>
        public bool DisableOnSafeMode { get; set; }

        /// <summary>
        /// Represents a patch
        /// </summary>
        /// <param name="packageName">The package name. Ex: microsoft-windows-usercpl</param>
        /// <param name="packageArch">The package arch</param>
        /// <param name="dllToPatch">The name of the DLL in the package to be patched. Example: usercpl.dll.mun</param>
        public PatchDef(string packageName, PackageArch packageArch, string SystemPath, PatchInstruction[] instructions, bool DisableOnSafeMode)
        {
            this.WinSxSPackageName = packageName;
            this.WinSxSPackageArch = packageArch;
            this.DllName = Path.GetFileName(SystemPath);
            this.Systempath = SystemPath;
            this.PatchInstructions = instructions;
            this.DisableOnSafeMode = DisableOnSafeMode;
        }
    }
    public class PatchInstruction
    {
        /// <summary>
        /// ResourceHacker action
        /// </summary>
        public string Action { get; set; }
        /// <summary>
        /// ResourceHacker resource ico
        /// </summary>
        public string Resource { get; set; }
        public string GroupAndLocation { get; set; }
        public PatchInstruction(string action, string resource, string type)
        {
            this.Action = action;
            this.Resource = resource;
            this.GroupAndLocation = type;
        }
    }
    public class Package
    {
        public string Path { get; set; }
        public PackageArch Arch { get; set; }
        public Package(string Path, PackageArch Arch)
        {
            this.Path = Path;
            this.Arch = Arch;
        }
    }
}
