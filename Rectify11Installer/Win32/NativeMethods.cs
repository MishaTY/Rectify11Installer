using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Rectify11Installer.Win32
{
    public unsafe class NativeMethods
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool MoveFileEx(string lpExistingFileName, string? lpNewFileName, MoveFileFlags dwFlags);

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Ansi)]
        public static extern bool CreateHardLinkA(string FileName, string ExistingFileName, IntPtr reserved);

        [DllImport("gdi32.dll", EntryPoint = "SelectObject")]
        public static extern IntPtr SelectObject([In] IntPtr hdc, [In] IntPtr hgdiobj);

        [DllImport("gdi32.dll")]
        public static extern IntPtr CreateDIBSection(IntPtr hdc, BITMAPINFO pbmi, uint iUsage, out int* ppvBits, IntPtr hSection, uint dwOffset);

        [DllImport("gdi32.dll")]
        public static extern bool BitBlt(IntPtr hdc, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, uint dwRop);

        [DllImport("gdi32.dll", ExactSpelling = true, SetLastError = true)]
        public static extern IntPtr CreateCompatibleDC(IntPtr hDC);

        public static void Reboot()
        {
            IntPtr tokenHandle = IntPtr.Zero;

            try
            {
                // get process token
                if (!OpenProcessToken(Process.GetCurrentProcess().Handle,
                    TOKEN_QUERY | TOKEN_ADJUST_PRIVILEGES,
                    out tokenHandle))
                {
                    throw new Win32Exception(Marshal.GetLastWin32Error(),
                        "Failed to open process token handle");
                }

                // lookup the shutdown privilege
                TOKEN_PRIVILEGES tokenPrivs = new TOKEN_PRIVILEGES();
                tokenPrivs.PrivilegeCount = 1;
                tokenPrivs.Privileges = new LUID_AND_ATTRIBUTES[1];
                tokenPrivs.Privileges[0].Attributes = SE_PRIVILEGE_ENABLED;

                if (!LookupPrivilegeValue(null,
                    SE_SHUTDOWN_NAME,
                    out tokenPrivs.Privileges[0].Luid))
                {
                    throw new Win32Exception(Marshal.GetLastWin32Error(),
                        "Failed to open lookup shutdown privilege");
                }

                // add the shutdown privilege to the process token
                if (!AdjustTokenPrivileges(tokenHandle,
                    false,
                    ref tokenPrivs,
                    0,
                    IntPtr.Zero,
                    IntPtr.Zero))
                {
                    throw new Win32Exception(Marshal.GetLastWin32Error(),
                        "Failed to adjust process token privileges");
                }

                // reboot
                if (!ExitWindowsEx(ExitWindows.Reboot,
                    ShutdownReason.MajorOther | ShutdownReason.MinorOther | ShutdownReason.FlagPlanned))
                {
                    throw new Win32Exception(Marshal.GetLastWin32Error(),
                        "Failed to reboot system");
                }
            }
            finally
            {
                // close the process token
                if (tokenHandle != IntPtr.Zero)
                {
                    CloseHandle(tokenHandle);
                }
            }
        }
        [Flags]
        private enum ExitWindows : uint
        {
            // ONE of the following five:
            LogOff = 0x00,
            ShutDown = 0x01,
            Reboot = 0x02,
            PowerOff = 0x08,
            RestartApps = 0x40,
            // plus AT MOST ONE of the following two:
            Force = 0x04,
            ForceIfHung = 0x10,
        }

        [Flags]
        private enum ShutdownReason : uint
        {
            MajorApplication = 0x00040000,
            MajorHardware = 0x00010000,
            MajorLegacyApi = 0x00070000,
            MajorOperatingSystem = 0x00020000,
            MajorOther = 0x00000000,
            MajorPower = 0x00060000,
            MajorSoftware = 0x00030000,
            MajorSystem = 0x00050000,

            MinorBlueScreen = 0x0000000F,
            MinorCordUnplugged = 0x0000000b,
            MinorDisk = 0x00000007,
            MinorEnvironment = 0x0000000c,
            MinorHardwareDriver = 0x0000000d,
            MinorHotfix = 0x00000011,
            MinorHung = 0x00000005,
            MinorInstallation = 0x00000002,
            MinorMaintenance = 0x00000001,
            MinorMMC = 0x00000019,
            MinorNetworkConnectivity = 0x00000014,
            MinorNetworkCard = 0x00000009,
            MinorOther = 0x00000000,
            MinorOtherDriver = 0x0000000e,
            MinorPowerSupply = 0x0000000a,
            MinorProcessor = 0x00000008,
            MinorReconfig = 0x00000004,
            MinorSecurity = 0x00000013,
            MinorSecurityFix = 0x00000012,
            MinorSecurityFixUninstall = 0x00000018,
            MinorServicePack = 0x00000010,
            MinorServicePackUninstall = 0x00000016,
            MinorTermSrv = 0x00000020,
            MinorUnstable = 0x00000006,
            MinorUpgrade = 0x00000003,
            MinorWMI = 0x00000015,

            FlagUserDefined = 0x40000000,
            FlagPlanned = 0x80000000
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct LUID
        {
            public uint LowPart;
            public int HighPart;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct LUID_AND_ATTRIBUTES
        {
            public LUID Luid;
            public UInt32 Attributes;
        }

        private struct TOKEN_PRIVILEGES
        {
            public UInt32 PrivilegeCount;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
            public LUID_AND_ATTRIBUTES[] Privileges;
        }

        private const UInt32 TOKEN_QUERY = 0x0008;
        private const UInt32 TOKEN_ADJUST_PRIVILEGES = 0x0020;
        private const UInt32 SE_PRIVILEGE_ENABLED = 0x00000002;
        private const string SE_SHUTDOWN_NAME = "SeShutdownPrivilege";

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool ExitWindowsEx(ExitWindows uFlags,
            ShutdownReason dwReason);

        [DllImport("advapi32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool OpenProcessToken(IntPtr ProcessHandle,
            UInt32 DesiredAccess,
            out IntPtr TokenHandle);

        [DllImport("advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool LookupPrivilegeValue(string? lpSystemName,
            string lpName,
            out LUID lpLuid);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool CloseHandle(IntPtr hObject);

        [DllImport("advapi32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool AdjustTokenPrivileges(IntPtr TokenHandle,
            [MarshalAs(UnmanagedType.Bool)] bool DisableAllPrivileges,
            ref TOKEN_PRIVILEGES NewState,
            UInt32 Zero,
            IntPtr Null1,
            IntPtr Null2);

        [Flags]
        public enum MoveFileFlags
        {
            MOVEFILE_REPLACE_EXISTING = 0x00000001,
            MOVEFILE_COPY_ALLOWED = 0x00000002,
            MOVEFILE_DELAY_UNTIL_REBOOT = 0x00000004,
            MOVEFILE_DELAY_UNTIL_REBOOT_AND_REPLACE = 0x00000005, // idfk this doesnt work
            MOVEFILE_WRITE_THROUGH = 0x00000008,
            MOVEFILE_CREATE_HARDLINK = 0x00000010,
            MOVEFILE_FAIL_IF_NOT_TRACKABLE = 0x00000020
        }

        public enum PRODUCT_TYPE
        {
            VER_NT_WORKSTATION = 0x0000001,
            VER_NT_DOMAIN_CONTROLLER = 0x0000002,
            VER_NT_SERVER = 0x0000003,
        }

        [DllImport("uxtheme.dll", CharSet = CharSet.Unicode)]
        public extern static Int32 DrawThemeTextEx(IntPtr hTheme, IntPtr hdc, int iPartId, int iStateId, string pszText, int iCharCount, uint flags, ref RECT rect, ref DTTOPTS poptions);

        [StructLayout(LayoutKind.Sequential)]
        public struct DTTOPTS
        {
            public int dwSize;
            public int dwFlags;
            public int crText;
            public int crBorder;
            public int crShadow;
            public int iTextShadowType;
            public int ptShadowOffsetX;
            public int ptShadowOffsetY;
            public int iBorderSize;
            public int iFontPropId;
            public int iColorPropId;
            public int iStateId;
            public bool fApplyOverlay;
            public int iGlowSize;
            public IntPtr pfnDrawTextCallback;
            public IntPtr lParam;
        }

        // taken from vsstyle.h
        public const int WP_CAPTION = 1;
        public const int CS_ACTIVE = 1;
        [StructLayout(LayoutKind.Sequential)]
        public class BITMAPINFO
        {
            public int biSize;
            public int biWidth;
            public int biHeight;
            public short biPlanes;
            public short biBitCount;
            public int biCompression;
            public int biSizeImage;
            public int biXPelsPerMeter;
            public int biYPelsPerMeter;
            public int biClrUsed;
            public int biClrImportant;
            public byte bmiColors_rgbBlue;
            public byte bmiColors_rgbGreen;
            public byte bmiColors_rgbRed;
            public byte bmiColors_rgbReserved;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct DWM_BLURBEHIND
        {
            public DWM_BB dwFlags;
            public bool fEnable;
            public IntPtr hRgnBlur;
            public bool fTransitionOnMaximized;

            public DWM_BLURBEHIND(bool enabled)
            {
                fEnable = enabled ? true : false;
                hRgnBlur = IntPtr.Zero;
                fTransitionOnMaximized = false;
                dwFlags = DWM_BB.Enable;
            }

            public System.Drawing.Region Region
            {
                get { return System.Drawing.Region.FromHrgn(hRgnBlur); }
            }

            public bool TransitionOnMaximized
            {
                get { return fTransitionOnMaximized; }
                set
                {
                    fTransitionOnMaximized = value ? true : false;
                    dwFlags |= DWM_BB.TransitionMaximized;
                }
            }

            public void SetRegion(System.Drawing.Graphics graphics, System.Drawing.Region region)
            {
                hRgnBlur = region.GetHrgn(graphics);
                dwFlags |= DWM_BB.BlurRegion;
            }
        }
        [Flags]
        public enum DWM_BB
        {
            Enable = 1,
            BlurRegion = 2,
            TransitionMaximized = 4
        }
    }
}
