using System;
using System.Runtime.InteropServices;

namespace libmsstyle
{
    internal class Win32Api
    {
        [DllImport("kernel32.dll", EntryPoint = "FindResourceW", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr FindResource(IntPtr hModule, string pName, string pType);

        [DllImport("kernel32.dll", EntryPoint = "FindResourceW", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr FindResource(IntPtr hModule, uint pName, string pType);

        [DllImport("kernel32.dll", EntryPoint = "FindResourceExW", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr FindResourceEx(IntPtr hModule, string lpType, uint lpName, ushort wLanguage);

        [DllImport("kernel32.dll", EntryPoint = "FindResourceExW", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr FindResourceEx(IntPtr hModule, uint lpType, uint lpName, ushort wLanguage);

        [DllImport("kernel32.dll", EntryPoint = "SizeofResource", SetLastError = true)]
        public static extern uint SizeofResource(IntPtr hModule, IntPtr hResource);

        [DllImport("kernel32.dll", EntryPoint = "LoadResource", SetLastError = true)]
        public static extern IntPtr LoadResource(IntPtr hModule, IntPtr hResource);

        [DllImport("kernel32.dll", EntryPoint = "LockResource")]
        public static extern IntPtr LockResource(IntPtr hGlobal);


        [DllImport("kernel32.dll", EntryPoint = "BeginUpdateResourceW", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr BeginUpdateResource(string pFileName, bool bDeleteExistingResources);

        [DllImport("kernel32.dll", EntryPoint = "UpdateResourceW", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool UpdateResource(IntPtr hUpdate, uint lpType, uint lpName, ushort wLanguage, byte[] lpData, uint cbData);

        [DllImport("kernel32.dll", EntryPoint = "UpdateResourceW", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool UpdateResource(IntPtr hUpdate, string lpType, uint lpName, ushort wLanguage, byte[] lpData, uint cbData);

        [DllImport("kernel32.dll", EntryPoint = "UpdateResourceW", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool UpdateResource(IntPtr hUpdate, string lpType, string lpName, ushort wLanguage, byte[] lpData, uint cbData);


        [DllImport("kernel32.dll", EntryPoint = "EndUpdateResourceW", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool EndUpdateResource(IntPtr hUpdate, bool fDiscard);

        public const uint RT_BITMAP = 2;
        public const uint RT_STRING = 6;
        public const uint RT_VERSION = 16;

        public const ushort LANG_NEUTRAL = 0;
        public const ushort LANG_EN_US = 1033;

        [System.Flags]
        public enum EnumResourceFlags : uint
        {
            None = 0,
            RESOURCE_ENUM_LN = 0x0001,
            RESOURCE_ENUM_MUI = 0x0002,
            RESOURCE_ENUM_MUI_SYSTEM = 0x0004,
            RESOURCE_ENUM_VALIDATE = 0x0008,
        }

        public delegate bool EnumResLangDelegate(IntPtr hModule, IntPtr lpszType, IntPtr lpszName, ushort wIDLanguage, IntPtr lParam);

        [DllImport("kernel32.dll", EntryPoint = "EnumResourceLanguagesExW", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool EnumResourceLanguagesEx(IntPtr hModule, string lpType, string lpName, [MarshalAs(UnmanagedType.FunctionPtr)] EnumResLangDelegate lpEnumFunc, IntPtr lParam, EnumResourceFlags dwFlags, ushort langId);


        public delegate bool EnumResNameDelegate(IntPtr hModule, IntPtr lpType, IntPtr lpName, IntPtr lParam);

        [DllImport("kernel32.dll", EntryPoint = "EnumResourceNamesExW", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool EnumResourceNamesEx(IntPtr hModule, uint lpType, [MarshalAs(UnmanagedType.FunctionPtr)] EnumResNameDelegate lpEnumFunc, IntPtr lParam, EnumResourceFlags dwFlags, ushort langId);


        [System.Flags]
        public enum LoadLibraryFlags : uint
        {
            None = 0,
            DONT_RESOLVE_DLL_REFERENCES = 0x00000001,
            LOAD_IGNORE_CODE_AUTHZ_LEVEL = 0x00000010,
            LOAD_LIBRARY_AS_DATAFILE = 0x00000002,
            LOAD_LIBRARY_AS_DATAFILE_EXCLUSIVE = 0x00000040,
            LOAD_LIBRARY_AS_IMAGE_RESOURCE = 0x00000020,
            LOAD_LIBRARY_SEARCH_APPLICATION_DIR = 0x00000200,
            LOAD_LIBRARY_SEARCH_DEFAULT_DIRS = 0x00001000,
            LOAD_LIBRARY_SEARCH_DLL_LOAD_DIR = 0x00000100,
            LOAD_LIBRARY_SEARCH_SYSTEM32 = 0x00000800,
            LOAD_LIBRARY_SEARCH_USER_DIRS = 0x00000400,
            LOAD_WITH_ALTERED_SEARCH_PATH = 0x00000008
        }

        [DllImport("kernel32.dll", EntryPoint = "LoadLibraryExW", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern IntPtr LoadLibraryEx(string lpFileName, IntPtr hReservedNull, LoadLibraryFlags dwFlags);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool FreeLibrary(IntPtr hModule);

    }
}
