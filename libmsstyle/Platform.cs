using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libmsstyle
{
    public enum Platform
    {
        Vista,
        Win7,
        Win8,
        Win81,
        Win10,
        Win11
    }

    public static class PlatformExtensions
    {
        public static string ToDisplayString(this Platform p)
        {
            switch (p)
            {
                case Platform.Vista:
                    return "Windows Vista";
                case Platform.Win7:
                    return "Windows 7";
                case Platform.Win8:
                    return "Windows 8";
                case Platform.Win81:
                    return "Windows 8.1";
                case Platform.Win10:
                    return "Windows 10";
                case Platform.Win11:
                    return "Windows 11";
                default:
                    return "Unknown";
            }
        }
    }
}
