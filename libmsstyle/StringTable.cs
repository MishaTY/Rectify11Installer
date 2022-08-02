using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace libmsstyle
{
    public class StringTable
    {
        public static Dictionary<int, string> FilterFonts(Dictionary<int, string> table)
        {
            var fonts = new Dictionary<int, string>();
            foreach(var entry in table)
            {
                var elem = entry.Value.Split(new char[] { ',' });
                if (elem.Length < 2)
                {
                    continue;
                }

                int fontSize;
                if(!Int32.TryParse(elem[1], out fontSize))
                {
                    continue;
                }

                var lower = entry.Value.ToLower();
                if (lower.Contains("bold") ||
                   lower.Contains("italic") ||
                   lower.Contains("underline") ||
                   lower.Contains("quality:"))
                {
                    fonts.Add(entry.Key, entry.Value);
                }
            }

            return fonts;
        }
    }
}
