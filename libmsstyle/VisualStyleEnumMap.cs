using System.Collections.Generic;

namespace libmsstyle
{
    public class VisualStyleEnumEntry
    {
        public VisualStyleEnumEntry(int value, string name)
        {
            Value = value;
            Name = name;
        }

        public int Value;
        public string Name;

        public override string ToString()
        {
            return Name;
        }
    }

    public class VisualStyleEnums
    {
        public static readonly List<VisualStyleEnumEntry> ENUM_BGTYPE = new List<VisualStyleEnumEntry>()
        {
            new VisualStyleEnumEntry(0, "IMAGEFILE" ),
            new VisualStyleEnumEntry(1, "BORDERFILL" ),
            new VisualStyleEnumEntry(2, "NONE" )
        };

        public static readonly List<VisualStyleEnumEntry> ENUM_IMAGELAYOUT = new List<VisualStyleEnumEntry>()
        {
            new VisualStyleEnumEntry(0, "VERTICAL" ),
            new VisualStyleEnumEntry(1, "HORIZONTAL" )
        };

        public static readonly List<VisualStyleEnumEntry> ENUM_BORDERTYPE = new List<VisualStyleEnumEntry>()
        {
            new VisualStyleEnumEntry(0, "RECT" ),
            new VisualStyleEnumEntry(1, "ROUNDRECT" ),
            new VisualStyleEnumEntry(2, "ELLIPSE" )
        };

        public static readonly List<VisualStyleEnumEntry> ENUM_FILLTYPE = new List<VisualStyleEnumEntry>()
        {
            new VisualStyleEnumEntry(0, "SOLID" ),
            new VisualStyleEnumEntry(1, "VERTGRADIENT" ),
            new VisualStyleEnumEntry(2, "HORIZONTALGRADIENT" ),
            new VisualStyleEnumEntry(3, "RADIALGRADIENT" ),
            new VisualStyleEnumEntry(4, "TILEIMAGE" )
        };

        public static readonly List<VisualStyleEnumEntry> ENUM_SIZINGTYPE = new List<VisualStyleEnumEntry>()
        {
            new VisualStyleEnumEntry(0, "TRUESIZE" ),
            new VisualStyleEnumEntry(1, "STRETCH" ),
            new VisualStyleEnumEntry(2, "TILE" )
        };

        public static readonly List<VisualStyleEnumEntry> ENUM_ALIGNMENT_H = new List<VisualStyleEnumEntry>()
        {
            new VisualStyleEnumEntry(0, "LEFT" ),
            new VisualStyleEnumEntry(1, "CENTER" ),
            new VisualStyleEnumEntry(2, "RIGHT" )
        };

        public static readonly List<VisualStyleEnumEntry> ENUM_ALIGNMENT_V = new List<VisualStyleEnumEntry>()
        {
            new VisualStyleEnumEntry(0, "TOP" ),
            new VisualStyleEnumEntry(1, "CENTER" ),
            new VisualStyleEnumEntry(2, "BOTTOM" )
        };

        public static readonly List<VisualStyleEnumEntry> ENUM_OFFSET = new List<VisualStyleEnumEntry>()
        {
            new VisualStyleEnumEntry(0, "TOPLEFT" ),
            new VisualStyleEnumEntry(1, "TOPRIGHT" ),
            new VisualStyleEnumEntry(2, "TOPMIDDLE" ),
            new VisualStyleEnumEntry(3, "BOTTOMLEFT" ),
            new VisualStyleEnumEntry(4, "BOTTOMRIGHT" ),
            new VisualStyleEnumEntry(5, "BOTTOMMIDDLE" ),
            new VisualStyleEnumEntry(6, "MIDDLERIGHT" ),
            new VisualStyleEnumEntry(7, "LEFTOFCAPTION" ),
            new VisualStyleEnumEntry(8, "RIGHTOFCAPTION" ),
            new VisualStyleEnumEntry(9, "LEFTOFLASTBUTTON" ),
            new VisualStyleEnumEntry(10, "RIGHTOFLASTBUTTON" ),
            new VisualStyleEnumEntry(11, "ABOVELASTBUTTON" ),
            new VisualStyleEnumEntry(12, "BELOWLASTBUTTON" )
        };

        public static readonly List<VisualStyleEnumEntry> ENUM_ICONEFFECT = new List<VisualStyleEnumEntry>()
        {
            new VisualStyleEnumEntry(0, "NONE" ),
            new VisualStyleEnumEntry(1, "GLOW" ),
            new VisualStyleEnumEntry(2, "SHADOW" ),
            new VisualStyleEnumEntry(3, "PULSE" ),
            new VisualStyleEnumEntry(4, "ALPHA" )
        };

        public static readonly List<VisualStyleEnumEntry> ENUM_TEXTSHADOW = new List<VisualStyleEnumEntry>()
        {
            new VisualStyleEnumEntry(0, "NONE" ),
            new VisualStyleEnumEntry(1, "SINGLE" ),
            new VisualStyleEnumEntry(2, "CONTINUOUS" )
        };

        public static readonly List<VisualStyleEnumEntry> ENUM_GLYPHTYPE = new List<VisualStyleEnumEntry>()
        {
            new VisualStyleEnumEntry(0, "NONE" ),
            new VisualStyleEnumEntry(1, "IMAGEGLYPH" ),
            new VisualStyleEnumEntry(2, "FONTGLYPH" )
        };

        public static readonly List<VisualStyleEnumEntry> ENUM_IMAGESELECT = new List<VisualStyleEnumEntry>()
        {
            new VisualStyleEnumEntry(0, "NONE" ),
            new VisualStyleEnumEntry(1, "SIZE" ),
            new VisualStyleEnumEntry(2, "DPI" )
        };

        public static readonly List<VisualStyleEnumEntry> ENUM_TRUESIZESCALING = new List<VisualStyleEnumEntry>()
        {
            new VisualStyleEnumEntry(0, "NONE" ),
            new VisualStyleEnumEntry(1, "SIZE" ),
            new VisualStyleEnumEntry(2, "DPI" )
        };

        public static readonly List<VisualStyleEnumEntry> ENUM_GLYPHFONTSCALING = new List<VisualStyleEnumEntry>()
        {
            new VisualStyleEnumEntry(0, "NONE" ),
            new VisualStyleEnumEntry(1, "SIZE" ),
            new VisualStyleEnumEntry(2, "DPI" )
        };

        public static readonly List<VisualStyleEnumEntry> ENUM_HIGHCONTRASTTYPE = new List<VisualStyleEnumEntry>()
        {
            new VisualStyleEnumEntry(0, "ACTIVECAPTION" ),
            new VisualStyleEnumEntry(1, "CAPTIONTEXT" ),
            new VisualStyleEnumEntry(2, "BTNFACE" ),
            new VisualStyleEnumEntry(3, "BTNTEXT" ),
            new VisualStyleEnumEntry(4, "DESKTOP" ),
            new VisualStyleEnumEntry(5, "GRAYTEXT" ),
            new VisualStyleEnumEntry(6, "HOTLIGHT" ),
            new VisualStyleEnumEntry(7, "INACTIVECAPTION" ),
            new VisualStyleEnumEntry(8, "INACTIVECAPTIONTEXT" ),
            new VisualStyleEnumEntry(9, "HIGHLIGHT" ),
            new VisualStyleEnumEntry(10, "HIGHLIGHTTEXT" ),
            new VisualStyleEnumEntry(11, "WINDOW" ),
            new VisualStyleEnumEntry(12, "WINDOWTEXT" )
        };

        public static List<VisualStyleEnumEntry> Find(int nameID)
        {
            if (nameID == (int)IDENTIFIER.BGTYPE)
            {
                return VisualStyleEnums.ENUM_BGTYPE;
            }
            else if (nameID == (int)IDENTIFIER.BORDERTYPE)
            {
                return VisualStyleEnums.ENUM_BORDERTYPE;
            }
            else if (nameID == (int)IDENTIFIER.FILLTYPE)
            {
                return VisualStyleEnums.ENUM_FILLTYPE;
            }
            else if (nameID == (int)IDENTIFIER.SIZINGTYPE)
            {
                return VisualStyleEnums.ENUM_SIZINGTYPE;
            }
            else if (nameID == (int)IDENTIFIER.HALIGN)
            {
                return VisualStyleEnums.ENUM_ALIGNMENT_H;
            }
            else if (nameID == (int)IDENTIFIER.CONTENTALIGNMENT)
            {
                return VisualStyleEnums.ENUM_ALIGNMENT_H;
            }
            else if (nameID == (int)IDENTIFIER.VALIGN)
            {
                return VisualStyleEnums.ENUM_ALIGNMENT_V;
            }
            else if (nameID == (int)IDENTIFIER.OFFSETTYPE)
            {
                return VisualStyleEnums.ENUM_OFFSET;
            }
            else if (nameID == (int)IDENTIFIER.ICONEFFECT)
            {
                return VisualStyleEnums.ENUM_ICONEFFECT;
            }
            else if(nameID == (int)IDENTIFIER.TEXTSHADOWTYPE)
            {
                return VisualStyleEnums.ENUM_TEXTSHADOW;
            }
            else if (nameID == (int)IDENTIFIER.IMAGELAYOUT)
            {
                return VisualStyleEnums.ENUM_IMAGELAYOUT;
            }
            else if (nameID == (int)IDENTIFIER.GLYPHTYPE)
            {
                return VisualStyleEnums.ENUM_GLYPHTYPE;
            }
            else if (nameID == (int)IDENTIFIER.IMAGESELECTTYPE)
            {
                return VisualStyleEnums.ENUM_IMAGESELECT;
            }
            else if (nameID == (int)IDENTIFIER.GLYPHFONTSIZINGTYPE)
            {
                return VisualStyleEnums.ENUM_GLYPHFONTSCALING;
            }
            else if (nameID == (int)IDENTIFIER.TRUESIZESCALINGTYPE)
            {
                return VisualStyleEnums.ENUM_TRUESIZESCALING;
            }
            else if (nameID >= (int)IDENTIFIER.UNKNOWN_5110_HC &&
                     nameID <= (int)IDENTIFIER.UNKNOWN_5122_HC)
            {
                return VisualStyleEnums.ENUM_HIGHCONTRASTTYPE;
            }
            else
            {
                return null;
            }
        }
    }
}