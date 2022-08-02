using Microsoft.Win32;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Rectify11Installer.Core
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
        internal static extern int RegFlushKey(IntPtr hKey);

        //const uint HKEY_CLASSES_ROOT = 0x80000000;
        //const uint HKEY_CURRENT_USER = 0x80000001;
        const uint HKEY_LOCAL_MACHINE = 0x80000002;
        //const uint HKEY_USERS = 0x80000003;

        public static void CommitRegistry()
        {
            IntPtr hkeyLocalMachine = new(unchecked((int)HKEY_LOCAL_MACHINE));
            _ = RegFlushKey(hkeyLocalMachine);
        }

        public static void RebootSystem()
        {
            Privileges.EnablePrivilege(SecurityEntity.SE_SHUTDOWN_NAME);
            InitiateSystemShutdownEx(null, null, 0, true, true, ShutdownReason.SHTDN_REASON_MAJOR_NONE);
        }

        [DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool InitiateSystemShutdownEx(
    string? lpMachineName,
    string? lpMessage,
    uint dwTimeout,
    bool bForceAppsClosed,
    bool bRebootAfterShutdown,
    ShutdownReason dwReason);

        [Flags]
        public enum ShutdownReason : uint
        {
            // Microsoft major reasons.
            SHTDN_REASON_MAJOR_OTHER = 0x00000000,
            SHTDN_REASON_MAJOR_NONE = 0x00000000,
            SHTDN_REASON_MAJOR_HARDWARE = 0x00010000,
            SHTDN_REASON_MAJOR_OPERATINGSYSTEM = 0x00020000,
            SHTDN_REASON_MAJOR_SOFTWARE = 0x00030000,
            SHTDN_REASON_MAJOR_APPLICATION = 0x00040000,
            SHTDN_REASON_MAJOR_SYSTEM = 0x00050000,
            SHTDN_REASON_MAJOR_POWER = 0x00060000,
            SHTDN_REASON_MAJOR_LEGACY_API = 0x00070000,

            // Microsoft minor reasons.
            SHTDN_REASON_MINOR_OTHER = 0x00000000,
            SHTDN_REASON_MINOR_NONE = 0x000000ff,
            SHTDN_REASON_MINOR_MAINTENANCE = 0x00000001,
            SHTDN_REASON_MINOR_INSTALLATION = 0x00000002,
            SHTDN_REASON_MINOR_UPGRADE = 0x00000003,
            SHTDN_REASON_MINOR_RECONFIG = 0x00000004,
            SHTDN_REASON_MINOR_HUNG = 0x00000005,
            SHTDN_REASON_MINOR_UNSTABLE = 0x00000006,
            SHTDN_REASON_MINOR_DISK = 0x00000007,
            SHTDN_REASON_MINOR_PROCESSOR = 0x00000008,
            SHTDN_REASON_MINOR_NETWORKCARD = 0x00000000,
            SHTDN_REASON_MINOR_POWER_SUPPLY = 0x0000000a,
            SHTDN_REASON_MINOR_CORDUNPLUGGED = 0x0000000b,
            SHTDN_REASON_MINOR_ENVIRONMENT = 0x0000000c,
            SHTDN_REASON_MINOR_HARDWARE_DRIVER = 0x0000000d,
            SHTDN_REASON_MINOR_OTHERDRIVER = 0x0000000e,
            SHTDN_REASON_MINOR_BLUESCREEN = 0x0000000F,
            SHTDN_REASON_MINOR_SERVICEPACK = 0x00000010,
            SHTDN_REASON_MINOR_HOTFIX = 0x00000011,
            SHTDN_REASON_MINOR_SECURITYFIX = 0x00000012,
            SHTDN_REASON_MINOR_SECURITY = 0x00000013,
            SHTDN_REASON_MINOR_NETWORK_CONNECTIVITY = 0x00000014,
            SHTDN_REASON_MINOR_WMI = 0x00000015,
            SHTDN_REASON_MINOR_SERVICEPACK_UNINSTALL = 0x00000016,
            SHTDN_REASON_MINOR_HOTFIX_UNINSTALL = 0x00000017,
            SHTDN_REASON_MINOR_SECURITYFIX_UNINSTALL = 0x00000018,
            SHTDN_REASON_MINOR_MMC = 0x00000019,
            SHTDN_REASON_MINOR_TERMSRV = 0x00000020,

            // Flags that end up in the event log code.
            SHTDN_REASON_FLAG_USER_DEFINED = 0x40000000,
            SHTDN_REASON_FLAG_PLANNED = 0x80000000,
            SHTDN_REASON_UNKNOWN = SHTDN_REASON_MINOR_NONE,
            SHTDN_REASON_LEGACY_API = (SHTDN_REASON_MAJOR_LEGACY_API | SHTDN_REASON_FLAG_PLANNED),

            // This mask cuts out UI flags.
            SHTDN_REASON_VALID_BIT_MASK = 0xc0ffffff
        }
    }
    //Needed code:
    public static class Privileges
    {
        public static void EnablePrivilege(SecurityEntity securityEntity)
        {
            if (!Enum.IsDefined(typeof(SecurityEntity), securityEntity))
                throw new InvalidEnumArgumentException("securityEntity", (int)securityEntity, typeof(SecurityEntity));

            var securityEntityValue = GetSecurityEntityValue(securityEntity);
            try
            {
                var locallyUniqueIdentifier = new NativeMethods.LUID();

                if (NativeMethods.LookupPrivilegeValue(null, securityEntityValue, ref locallyUniqueIdentifier))
                {
                    var TOKEN_PRIVILEGES = new NativeMethods.TOKEN_PRIVILEGES
                    {
                        PrivilegeCount = 1,
                        Attributes = NativeMethods.SE_PRIVILEGE_ENABLED,
                        Luid = locallyUniqueIdentifier
                    };

                    var tokenHandle = IntPtr.Zero;
                    try
                    {
                        var currentProcess = NativeMethods.GetCurrentProcess();
                        if (NativeMethods.OpenProcessToken(currentProcess, NativeMethods.TOKEN_ADJUST_PRIVILEGES | NativeMethods.TOKEN_QUERY, out tokenHandle))
                        {
                            if (NativeMethods.AdjustTokenPrivileges(tokenHandle, false,
                                                ref TOKEN_PRIVILEGES,
               1024, IntPtr.Zero, IntPtr.Zero))
                            {
                                var lastError = Marshal.GetLastWin32Error();
                                if (lastError == NativeMethods.ERROR_NOT_ALL_ASSIGNED)
                                {
                                    var win32Exception = new Win32Exception();
                                    throw new InvalidOperationException("AdjustTokenPrivileges failed.", win32Exception);
                                }
                            }
                            else
                            {
                                var win32Exception = new Win32Exception();
                                throw new InvalidOperationException("AdjustTokenPrivileges failed.", win32Exception);
                            }
                        }
                        else
                        {
                            var win32Exception = new Win32Exception();

                            var exceptionMessage = string.Format(CultureInfo.InvariantCulture,
                                                "OpenProcessToken failed. CurrentProcess: {0}",
                                                currentProcess.ToInt32());

                            throw new InvalidOperationException(exceptionMessage, win32Exception);
                        }
                    }
                    finally
                    {
                        if (tokenHandle != IntPtr.Zero)
                            NativeMethods.CloseHandle(tokenHandle);
                    }
                }
                else
                {
                    var win32Exception = new Win32Exception();

                    var exceptionMessage = string.Format(CultureInfo.InvariantCulture,
                                        "LookupPrivilegeValue failed. SecurityEntityValue: {0}",
                                        securityEntityValue);

                    throw new InvalidOperationException(exceptionMessage, win32Exception);
                }
            }
            catch (Exception e)
            {
                var exceptionMessage = string.Format(CultureInfo.InvariantCulture,
                                 "GrandPrivilege failed. SecurityEntity: {0}",
                                 securityEntityValue);

                throw new InvalidOperationException(exceptionMessage, e);
            }
        }

        /// <summary>
        /// Gets the security entity value.
        /// </summary>
        /// <param name="securityEntity">The security entity.</param>
        private static string GetSecurityEntityValue(SecurityEntity securityEntity)
        {
            return securityEntity switch
            {
                SecurityEntity.SE_ASSIGNPRIMARYTOKEN_NAME => "SeAssignPrimaryTokenPrivilege",
                SecurityEntity.SE_AUDIT_NAME => "SeAuditPrivilege",
                SecurityEntity.SE_BACKUP_NAME => "SeBackupPrivilege",
                SecurityEntity.SE_CHANGE_NOTIFY_NAME => "SeChangeNotifyPrivilege",
                SecurityEntity.SE_CREATE_GLOBAL_NAME => "SeCreateGlobalPrivilege",
                SecurityEntity.SE_CREATE_PAGEFILE_NAME => "SeCreatePagefilePrivilege",
                SecurityEntity.SE_CREATE_PERMANENT_NAME => "SeCreatePermanentPrivilege",
                SecurityEntity.SE_CREATE_SYMBOLIC_LINK_NAME => "SeCreateSymbolicLinkPrivilege",
                SecurityEntity.SE_CREATE_TOKEN_NAME => "SeCreateTokenPrivilege",
                SecurityEntity.SE_DEBUG_NAME => "SeDebugPrivilege",
                SecurityEntity.SE_ENABLE_DELEGATION_NAME => "SeEnableDelegationPrivilege",
                SecurityEntity.SE_IMPERSONATE_NAME => "SeImpersonatePrivilege",
                SecurityEntity.SE_INC_BASE_PRIORITY_NAME => "SeIncreaseBasePriorityPrivilege",
                SecurityEntity.SE_INCREASE_QUOTA_NAME => "SeIncreaseQuotaPrivilege",
                SecurityEntity.SE_INC_WORKING_SET_NAME => "SeIncreaseWorkingSetPrivilege",
                SecurityEntity.SE_LOAD_DRIVER_NAME => "SeLoadDriverPrivilege",
                SecurityEntity.SE_LOCK_MEMORY_NAME => "SeLockMemoryPrivilege",
                SecurityEntity.SE_MACHINE_ACCOUNT_NAME => "SeMachineAccountPrivilege",
                SecurityEntity.SE_MANAGE_VOLUME_NAME => "SeManageVolumePrivilege",
                SecurityEntity.SE_PROF_SINGLE_PROCESS_NAME => "SeProfileSingleProcessPrivilege",
                SecurityEntity.SE_RELABEL_NAME => "SeRelabelPrivilege",
                SecurityEntity.SE_REMOTE_SHUTDOWN_NAME => "SeRemoteShutdownPrivilege",
                SecurityEntity.SE_RESTORE_NAME => "SeRestorePrivilege",
                SecurityEntity.SE_SECURITY_NAME => "SeSecurityPrivilege",
                SecurityEntity.SE_SHUTDOWN_NAME => "SeShutdownPrivilege",
                SecurityEntity.SE_SYNC_AGENT_NAME => "SeSyncAgentPrivilege",
                SecurityEntity.SE_SYSTEM_ENVIRONMENT_NAME => "SeSystemEnvironmentPrivilege",
                SecurityEntity.SE_SYSTEM_PROFILE_NAME => "SeSystemProfilePrivilege",
                SecurityEntity.SE_SYSTEMTIME_NAME => "SeSystemtimePrivilege",
                SecurityEntity.SE_TAKE_OWNERSHIP_NAME => "SeTakeOwnershipPrivilege",
                SecurityEntity.SE_TCB_NAME => "SeTcbPrivilege",
                SecurityEntity.SE_TIME_ZONE_NAME => "SeTimeZonePrivilege",
                SecurityEntity.SE_TRUSTED_CREDMAN_ACCESS_NAME => "SeTrustedCredManAccessPrivilege",
                SecurityEntity.SE_UNDOCK_NAME => "SeUndockPrivilege",
                _ => throw new ArgumentOutOfRangeException(typeof(SecurityEntity).Name),
            };
        }
    }

    public enum SecurityEntity
    {
        SE_CREATE_TOKEN_NAME,
        SE_ASSIGNPRIMARYTOKEN_NAME,
        SE_LOCK_MEMORY_NAME,
        SE_INCREASE_QUOTA_NAME,
        SE_UNSOLICITED_INPUT_NAME,
        SE_MACHINE_ACCOUNT_NAME,
        SE_TCB_NAME,
        SE_SECURITY_NAME,
        SE_TAKE_OWNERSHIP_NAME,
        SE_LOAD_DRIVER_NAME,
        SE_SYSTEM_PROFILE_NAME,
        SE_SYSTEMTIME_NAME,
        SE_PROF_SINGLE_PROCESS_NAME,
        SE_INC_BASE_PRIORITY_NAME,
        SE_CREATE_PAGEFILE_NAME,
        SE_CREATE_PERMANENT_NAME,
        SE_BACKUP_NAME,
        SE_RESTORE_NAME,
        SE_SHUTDOWN_NAME,
        SE_DEBUG_NAME,
        SE_AUDIT_NAME,
        SE_SYSTEM_ENVIRONMENT_NAME,
        SE_CHANGE_NOTIFY_NAME,
        SE_REMOTE_SHUTDOWN_NAME,
        SE_UNDOCK_NAME,
        SE_SYNC_AGENT_NAME,
        SE_ENABLE_DELEGATION_NAME,
        SE_MANAGE_VOLUME_NAME,
        SE_IMPERSONATE_NAME,
        SE_CREATE_GLOBAL_NAME,
        SE_CREATE_SYMBOLIC_LINK_NAME,
        SE_INC_WORKING_SET_NAME,
        SE_RELABEL_NAME,
        SE_TIME_ZONE_NAME,
        SE_TRUSTED_CREDMAN_ACCESS_NAME
    }

    internal static class NativeMethods
    {
        [DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool LookupPrivilegeValue(string? lpsystemname, string lpname, [MarshalAs(UnmanagedType.Struct)] ref LUID lpLuid);

        [DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool AdjustTokenPrivileges(IntPtr tokenhandle,
                                 [MarshalAs(UnmanagedType.Bool)] bool disableAllPrivileges,
                                 [MarshalAs(UnmanagedType.Struct)] ref TOKEN_PRIVILEGES newstate,
                                 uint bufferlength, IntPtr previousState, IntPtr returnlength);

        internal const int SE_PRIVILEGE_ENABLED = 0x00000002;

        internal const int ERROR_NOT_ALL_ASSIGNED = 1300;

        internal const uint STANDARD_RIGHTS_REQUIRED = 0x000F0000;
        internal const uint STANDARD_RIGHTS_READ = 0x00020000;
        internal const uint TOKEN_ASSIGN_PRIMARY = 0x0001;
        internal const uint TOKEN_DUPLICATE = 0x0002;
        internal const uint TOKEN_IMPERSONATE = 0x0004;
        internal const uint TOKEN_QUERY = 0x0008;
        internal const uint TOKEN_QUERY_SOURCE = 0x0010;
        internal const uint TOKEN_ADJUST_PRIVILEGES = 0x0020;
        internal const uint TOKEN_ADJUST_GROUPS = 0x0040;
        internal const uint TOKEN_ADJUST_DEFAULT = 0x0080;
        internal const uint TOKEN_ADJUST_SESSIONID = 0x0100;
        internal const uint TOKEN_READ = (STANDARD_RIGHTS_READ | TOKEN_QUERY);
        internal const uint TOKEN_ALL_ACCESS = (STANDARD_RIGHTS_REQUIRED |
                            TOKEN_ASSIGN_PRIMARY |
                            TOKEN_DUPLICATE |
                            TOKEN_IMPERSONATE |
                            TOKEN_QUERY |
                            TOKEN_QUERY_SOURCE |
                            TOKEN_ADJUST_PRIVILEGES |
                            TOKEN_ADJUST_GROUPS |
                            TOKEN_ADJUST_DEFAULT |
                            TOKEN_ADJUST_SESSIONID);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern IntPtr GetCurrentProcess();

        [DllImport("Advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool OpenProcessToken(IntPtr processHandle,
                            uint desiredAccesss,
                            out IntPtr tokenHandle);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern Boolean CloseHandle(IntPtr hObject);

        [StructLayout(LayoutKind.Sequential)]
        internal struct LUID
        {
            internal Int32 LowPart;
            internal UInt32 HighPart;
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct TOKEN_PRIVILEGES
        {
            internal Int32 PrivilegeCount;
            internal LUID Luid;
            internal Int32 Attributes;
        }
    }
}