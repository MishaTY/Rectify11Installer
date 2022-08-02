using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libmsstyle
{
    public class PropertyInfo
    {
        private string m_name;
        private int m_typeId;
        private string m_desc;

        public PropertyInfo(string name, int typeId, string desc)
        {
            m_name = name;
            m_typeId = typeId;
            m_desc = desc;
        }

        public string Name => m_name;
        public int TypeId => m_typeId;
        public string Description => m_desc;

        public override string ToString()
        {
            return m_name;
        }
    }

    public class VisualStyleProperties
    {
        public static readonly Dictionary<int, PropertyInfo> PROPERTY_INFO_MAP = new Dictionary<int, PropertyInfo>()
        {
            // BASIC TYPES
            { 2, new PropertyInfo("DIBDATA", 2, "" )},
            { 8, new PropertyInfo("GLYPHDIBDATA", 8, "") },
            { 200, new PropertyInfo("ENUM", 200, "" )},
            { 201, new PropertyInfo("STRING", 201, "" )},
            { 202, new PropertyInfo("INT", 202, "" )},
            { 203, new PropertyInfo("BOOL", 203, "" )},
            { 204, new PropertyInfo("COLOR", 204, "" )},
            { 205, new PropertyInfo("MARGINS", 205, "" )},
            { 206, new PropertyInfo("FILENAME", 206, "" )},
            { 207, new PropertyInfo("SIZE", 207, "" )},
            { 208, new PropertyInfo("POSITION", 208, "" )},
            { 209, new PropertyInfo("RECT", 209, "" )},
            { 210, new PropertyInfo("FONT", 210, "Generic font property." )},
            { 211, new PropertyInfo("INTLIST", 211, "" )},
            { 212, new PropertyInfo("HBITMAP", 212, "" )},
            { 213, new PropertyInfo("IMAGEATLAS", 213, "" )}, // DISKSTREAM
            { 214, new PropertyInfo("STREAM", 214, "" )},
            { 215, new PropertyInfo("BITMAPREF", 215, "" )},
            { 216, new PropertyInfo("FLOAT", 216, "" )},
            { 217, new PropertyInfo("FLOATLIST", 217, "" )},

            { 240, new PropertyInfo("SIMPLIFIEDIMAGETYPE", 240, "" )},
            { 241, new PropertyInfo("HIGHCONTRASTCOLORTYPE", 241, "" )}, // integer-like
            { 242, new PropertyInfo("BITMAPIMAGETYPE", 242, "" )},
            { 243, new PropertyInfo("COMPOSEDIMAGETYPE", 243, "" )}, // some id property

            // STRING
            { 401, new PropertyInfo("COLORSCHEMES", 201, "" )}, // begin propery names
            { 402, new PropertyInfo("SIZES", 201, "" )},
            // INT
            { 403, new PropertyInfo("CHARSET", 202, "" )},
            // STRING
            { 600, new PropertyInfo("NAME", 201, "" )},
            { 601, new PropertyInfo("DISPLAYNAME", 201, "" )},
            { 602, new PropertyInfo("TOOLTIP", 201, "" )},
            { 603, new PropertyInfo("COMPANY", 201, "" )},
            { 604, new PropertyInfo("AUTHOR", 201, "" )},
            { 605, new PropertyInfo("COPYRIGHT", 201, "" )},
            { 606, new PropertyInfo("URL", 201, "" )},
            { 607, new PropertyInfo("VERSION", 201, "" )},
            { 608, new PropertyInfo("DESCRIPTION", 201, "" )},
            // FONT
            { 801, new PropertyInfo("CAPTIONFONT", 210, "" )},
            { 802, new PropertyInfo("SMALLCAPTIONFONT", 210, "" )},
            { 803, new PropertyInfo("MENUFONT", 210, "" )},
            { 804, new PropertyInfo("STATUSFONT", 210, "" )},
            { 805, new PropertyInfo("MSGBOXFONT", 210, "" )},
            { 806, new PropertyInfo("ICONTITLEFONT", 210, "" )},
            { 807, new PropertyInfo("HEADING1FONT", 210, "" )},
            { 808, new PropertyInfo("HEADING2FONT", 210, "" )},
            { 809, new PropertyInfo("BODYFONT", 210, "" )},
            // BOOL
            { 1001, new PropertyInfo("FLATMENUS", 203, "" )},
            // SIZE
            { 1201, new PropertyInfo("SIZINGBORDERWIDTH", 207, "Width of a sizing border." )},
            { 1202, new PropertyInfo("SCROLLBARWIDTH", 207, "Scroll bar width." )},
            { 1203, new PropertyInfo("SCROLLBARHEIGHT", 207, "Scroll bar height." )},
            { 1204, new PropertyInfo("CAPTIONBARWIDTH", 207, "Caption bar width." )},
            { 1205, new PropertyInfo("CAPTIONBARHEIGHT", 207, "Caption bar height." )},
            { 1206, new PropertyInfo("SMCAPTIONBARWIDTH", 207, "Caption bar width." )},
            { 1207, new PropertyInfo("SMCAPTIONBARHEIGHT", 207, "Caption bar height." )},
            { 1208, new PropertyInfo("MENUBARWIDTH", 207, "Menu bar width." )},
            { 1209, new PropertyInfo("MENUBARHEIGHT", 207, "Menu bar height." )},
            { 1210, new PropertyInfo("PADDEDBORDERWIDTH", 207, "Padded border width." )},
            // INT
            { 1301, new PropertyInfo("MINCOLORDEPTH", 202, "" )},
            // STRING
            { 1401, new PropertyInfo("CSSNAME", 201, "The name of the CSS file associated with the theme specified by hTheme." )},
            { 1402, new PropertyInfo("XMLNAME", 201, "The name of the XML file associated with the theme specified by hTheme." )},
            { 1403, new PropertyInfo("LASTUPDATED", 201, "" )},
            { 1404, new PropertyInfo("ALIAS", 201, "" )},
            // COLOR
            { 1601, new PropertyInfo("SCROLLBAR", 204, "" )},
            { 1602, new PropertyInfo("BACKGROUND", 204, "" )},
            { 1603, new PropertyInfo("ACTIVECAPTION", 204, "" )},
            { 1604, new PropertyInfo("INACTIVECAPTION", 204, "" )},
            { 1605, new PropertyInfo("MENU", 204, "" )},
            { 1606, new PropertyInfo("WINDOW", 204, "" )},
            { 1607, new PropertyInfo("WINDOWFRAME", 204, "" )},
            { 1608, new PropertyInfo("MENUTEXT", 204, "" )},
            { 1609, new PropertyInfo("WINDOWTEXT", 204, "" )},
            { 1610, new PropertyInfo("CAPTIONTEXT", 204, "" )},
            { 1611, new PropertyInfo("ACTIVEBORDER", 204, "" )},
            { 1612, new PropertyInfo("INACTIVEBORDER", 204, "" )},
            { 1613, new PropertyInfo("APPWORKSPACE", 204, "" )},
            { 1614, new PropertyInfo("HIGHLIGHT", 204, "" )},
            { 1615, new PropertyInfo("HIGHLIGHTTEXT", 204, "" )},
            { 1616, new PropertyInfo("BTNFACE", 204, "" )},
            { 1617, new PropertyInfo("BTNSHADOW", 204, "" )},
            { 1618, new PropertyInfo("GRAYTEXT", 204, "" )},
            { 1619, new PropertyInfo("BTNTEXT", 204, "" )},
            { 1620, new PropertyInfo("INACTIVECAPTIONTEXT", 204, "" )},
            { 1621, new PropertyInfo("BTNHIGHLIGHT", 204, "" )},
            { 1622, new PropertyInfo("DKSHADOW3D", 204, "" )},
            { 1623, new PropertyInfo("LIGHT3D", 204, "" )},
            { 1624, new PropertyInfo("INFOTEXT", 204, "" )},
            { 1625, new PropertyInfo("INFOBK", 204, "" )},
            { 1626, new PropertyInfo("BUTTONALTERNATEFACE", 204, "" )},
            { 1627, new PropertyInfo("HOTTRACKING", 204, "" )},
            { 1628, new PropertyInfo("GRADIENTACTIVECAPTION", 204, "" )},
            { 1629, new PropertyInfo("GRADIENTINACTIVECAPTION", 204, "" )},
            { 1630, new PropertyInfo("MENUHILIGHT", 204, "" )},
            { 1631, new PropertyInfo("MENUBAR", 204, "" )},
            // INT
            { 1801, new PropertyInfo("FROMHUE1", 202, "" )},
            { 1802, new PropertyInfo("FROMHUE2", 202, "" )},
            { 1803, new PropertyInfo("FROMHUE3", 202, "" )},
            { 1804, new PropertyInfo("FROMHUE4", 202, "" )},
            { 1805, new PropertyInfo("FROMHUE5", 202, "" )},
            { 1806, new PropertyInfo("TOHUE1", 202, "" )},
            { 1807, new PropertyInfo("TOHUE2", 202, "" )},
            { 1808, new PropertyInfo("TOHUE3", 202, "" )},
            { 1809, new PropertyInfo("TOHUE4", 202, "" )},
            { 1810, new PropertyInfo("TOHUE5", 202, "" )},
            // COLOR - Weird
            { 2001, new PropertyInfo("FROMCOLOR1", 204, "" )},
            { 2002, new PropertyInfo("FROMCOLOR2", 204, "" )},
            { 2003, new PropertyInfo("FROMCOLOR3", 204, "" )},
            { 2004, new PropertyInfo("FROMCOLOR4", 204, "" )},
            { 2005, new PropertyInfo("FROMCOLOR5", 204, "" )},
            // INT - Weird
            { 2006, new PropertyInfo("TOCOLOR1", 202, "" )},
            { 2007, new PropertyInfo("TOCOLOR2", 202, "" )},
            { 2008, new PropertyInfo("TOCOLOR3", 202, "" )},
            { 2009, new PropertyInfo("TOCOLOR4", 202, "" )},
            { 2010, new PropertyInfo("TOCOLOR5", 202, "" )},
            // BOOL
            { 2201, new PropertyInfo("TRANSPARENT", 203, "" )},
            { 2202, new PropertyInfo("AUTOSIZE", 203, "TRUE if the nonclient caption area associated with the part and state vary with text width." )},
            { 2203, new PropertyInfo("BORDERONLY", 203, "TRUE if the image associated with the part and state should only have its border drawn." )},
            { 2204, new PropertyInfo("COMPOSITED", 203, "TRUE if the control associated with the part and state will handle its own compositing of images." )},
            { 2205, new PropertyInfo("BGFILL", 203, "TRUE if true-sized images associated with the part and state are to be drawn on the background fill." )},
            { 2206, new PropertyInfo("GLYPHTRANSPARENT", 203, "TRUE if the glyph associated with the part and state have transparent areas." )},
            { 2207, new PropertyInfo("GLYPHONLY", 203, "TRUE if the glyph associated with the part and state should be drawn without a background." )},
            { 2208, new PropertyInfo("ALWAYSSHOWSIZINGBAR", 203, "TRUE if the sizing bar associated with the part and state should always be shown." )},
            { 2209, new PropertyInfo("MIRRORIMAGE", 203, "TRUE if the image associated with the part and state should be flipped if the window is being viewed in right-to-left reading mode." )},
            { 2210, new PropertyInfo("UNIFORMSIZING", 203, "TRUE if the image associated with the part and state must have equal height and width. " )},
            { 2211, new PropertyInfo("INTEGRALSIZING", 203, "TRUE if the truesize image or border associated with the part and state must be sized to a factor of 2." )},
            { 2212, new PropertyInfo("SOURCEGROW", 203, "TRUE if the image associated with the part and state will scale larger in size if necessary." )},
            { 2213, new PropertyInfo("SOURCESHRINK", 203, "TRUE if the image associated with the part and state will scale smaller in size if necessary." )},
            { 2214, new PropertyInfo("DRAWBORDERS", 203, "" )},
            { 2215, new PropertyInfo("NOETCHEDEFFECT", 203, "" )},
            { 2216, new PropertyInfo("TEXTAPPLYOVERLAY", 203, "" )},
            { 2217, new PropertyInfo("TEXTGLOW", 203, "" )},
            { 2218, new PropertyInfo("TEXTITALIC", 203, "" )},
            { 2219, new PropertyInfo("COMPOSITEDOPAQUE", 203, "" )},
            { 2220, new PropertyInfo("LOCALIZEDMIRRORIMAGE", 203, "" )},
            // INT
            { 2401, new PropertyInfo("IMAGECOUNT", 202, "The number of state images present in an image file." )},
            { 2402, new PropertyInfo("ALPHALEVEL", 202, "The alpha value (0-255) used for DrawThemeIcon." )},
            { 2403, new PropertyInfo("BORDERSIZE", 202, "The thickness of the border drawn if this part uses a border fill." )},
            { 2404, new PropertyInfo("ROUNDCORNERWIDTH", 202, "The roundness (0 to 100 percent) of the part's corners." )},
            { 2405, new PropertyInfo("ROUNDCORNERHEIGHT", 202, "The roundness (0 to 100 percent) of the part's corners." )},
            { 2406, new PropertyInfo("GRADIENTRATIO1", 202, "The amount of the first gradient color (TMT_GRADIENTCOLOR1) to use in drawing the part. This value can be from 0 to 255, but this value plus the values of each of the GRADIENTRATIO values must add up to 255." )},
            { 2407, new PropertyInfo("GRADIENTRATIO2", 202, "The amount of the second gradient color (TMT_GRADIENTCOLOR2) to use in drawing the part." )},
            { 2408, new PropertyInfo("GRADIENTRATIO3", 202, "The amount of the third gradient color (TMT_GRADIENTCOLOR3) to use in drawing the part." )},
            { 2409, new PropertyInfo("GRADIENTRATIO4", 202, "The amount of the fourth gradient color (TMT_GRADIENTCOLOR4) to use in drawing the part." )},
            { 2410, new PropertyInfo("GRADIENTRATIO5", 202, "The amount of the fifth gradient color (TMT_GRADIENTCOLOR5) to use in drawing the part." )},
            { 2411, new PropertyInfo("PROGRESSCHUNKSIZE", 202, "The size of the progress control \"chunk\" shapes that define how far an operation has progressed." )},
            { 2412, new PropertyInfo("PROGRESSSPACESIZE", 202, "The total size of all of the progress control \"chunks\"." )},
            { 2413, new PropertyInfo("SATURATION", 202, "The amount of saturation (0-255) to apply to an icon drawn using DrawThemeIcon." )},
            { 2414, new PropertyInfo("TEXTBORDERSIZE", 202, "The thickness of the border drawn around text characters." )},
            { 2415, new PropertyInfo("ALPHATHRESHOLD", 202, "The minimum alpha value (0-255) that a pixel must have to be considered opaque." )},
            { 2416, new PropertyInfo("WIDTH", 202, "The width of the part." )},
            { 2417, new PropertyInfo("HEIGHT", 202, "The height of the part." )},
            { 2418, new PropertyInfo("GLYPHINDEX", 202, "The character index into the selected font that will be used for the glyph, if the part uses a font-based glyph." )},
            { 2419, new PropertyInfo("TRUESIZESTRETCHMARK", 202, "The percentage of a true-size image's original size at which the image will be stretched." )},
            { 2420, new PropertyInfo("MINDPI1", 202, "The minimum dots per inch (dpi) that the first image file was designed for." )},
            { 2421, new PropertyInfo("MINDPI2", 202, "The minimum dpi that the second image file was designed for." )},
            { 2422, new PropertyInfo("MINDPI3", 202, "The minimum dpi that the third image file was designed for." )},
            { 2423, new PropertyInfo("MINDPI4", 202, "The minimum dpi that the fourth image file was designed for." )},
            { 2424, new PropertyInfo("MINDPI5", 202, "The minimum dpi that the fifth image file was designed for." )},
            { 2425, new PropertyInfo("TEXTGLOWSIZE", 202, "" )},
            { 2426, new PropertyInfo("FRAMESPERSECOND", 202, "" )},
            { 2427, new PropertyInfo("PIXELSPERFRAME", 202, "" )},
            { 2428, new PropertyInfo("ANIMATIONDELAY", 202, "" )},
            { 2429, new PropertyInfo("GLOWINTENSITY", 202, "" )},
            { 2430, new PropertyInfo("OPACITY", 202, "" )},
            { 2431, new PropertyInfo("COLORIZATIONCOLOR", 202, "" )}, // integer misused as RGBA
            { 2432, new PropertyInfo("COLORIZATIONOPACITY", 202, "" )},
            { 2433, new PropertyInfo("MINDPI6", 202, "" )},	// since win 10
            { 2434, new PropertyInfo("MINDPI7", 202, "" )},	// since win 10
            // FONT
            { 2601, new PropertyInfo("GLYPHFONT", 210, "The font that the glyph associated with this part will be drawn with, if font-based glyphs are used." )},
            // FILENAME (ID)
            { 3001, new PropertyInfo("IMAGEFILE", 206, "The filename of the image associated with this part and state, or the base filename for multiple images associated with this part and state." )},
            { 3002, new PropertyInfo("IMAGEFILE1", 206, "The filename of the first scaled image associated with this part and state, for support of different resolutions." )},
            { 3003, new PropertyInfo("IMAGEFILE2", 206, "The filename of the second scaled image." )},
            { 3004, new PropertyInfo("IMAGEFILE3", 206, "The filename of the third scaled image." )},
            { 3005, new PropertyInfo("IMAGEFILE4", 206, "The filename of the fourth scaled image." )},
            { 3006, new PropertyInfo("IMAGEFILE5", 206, "The filename of the fifth scaled image." )},
            { 3008, new PropertyInfo("GLYPHIMAGEFILE", 206, "The filename for the glyph image associated with this part and state." )},
            { 3009, new PropertyInfo("IMAGEFILE6", 206, "The filename of the sixth scaled image. Only Win10." )},	// since win 10
            { 3010, new PropertyInfo("IMAGEFILE7", 206, "The filename of the seventh scaled image. Only Win10." )},	// since win 10
            // STRING
            { 3201, new PropertyInfo("TEXT", 201, "The text displayed by the part." )},
            { 3202, new PropertyInfo("CLASSICVALUE", 201, "" )},
            // POSITION
            { 3401, new PropertyInfo("OFFSET", 208, "The position offset from the alignment for this part. The alignment is defined by the OFFSETTYPE value." )},
            { 3402, new PropertyInfo("TEXTSHADOWOFFSET", 208, "The offset from the text at which text shadows are drawn." )},
            { 3403, new PropertyInfo("MINSIZE", 208, "The minimum size that the normal image file can be used for before moving to the next smallest image file." )},
            { 3404, new PropertyInfo("MINSIZE1", 208, "The minimum size that the first small image file can be used for." )},
            { 3405, new PropertyInfo("MINSIZE2", 208, "The minimum size that the second small image file can be used for." )},
            { 3406, new PropertyInfo("MINSIZE3", 208, "The minimum size that the third small image file can be used for." )},
            { 3407, new PropertyInfo("MINSIZE4", 208, "The minimum size that the fourth small image file can be used for." )},
            { 3408, new PropertyInfo("MINSIZE5", 208, "The minimum size that the fifth small image file can be used for." )},
            { 3409, new PropertyInfo("NORMALSIZE", 208, "The size of the normal image associated with this part." )},
            // MARGINS
            { 3601, new PropertyInfo("SIZINGMARGINS", 205, "The margins used for sizing a non-true-size image." )},
            { 3602, new PropertyInfo("CONTENTMARGINS", 205, "The margins that define where content may be placed within a part. " )},
            { 3603, new PropertyInfo("CAPTIONMARGINS", 205, "The margins that define where caption text may be placed within a part." )},
            // COLOR
            { 3801, new PropertyInfo("BORDERCOLOR", 204, "The color of the border associated with the part and state." )},
            { 3802, new PropertyInfo("FILLCOLOR", 204, "The color of the background fill associated with the part and state." )},
            { 3803, new PropertyInfo("TEXTCOLOR", 204, "The color of the text associated with this part and state." )},
            { 3804, new PropertyInfo("EDGELIGHTCOLOR", 204, "The light color of the edge associated with this part and state." )},
            { 3805, new PropertyInfo("EDGEHIGHLIGHTCOLOR", 204, "The highlight color of the edge associated with this part and state." )},
            { 3806, new PropertyInfo("EDGESHADOWCOLOR", 204, "The shadow color of the edge associated with this part and state." )},
            { 3807, new PropertyInfo("EDGEDKSHADOWCOLOR", 204, "The dark shadow color of the edge associated with this part and state." )},
            { 3808, new PropertyInfo("EDGEFILLCOLOR", 204, "The fill color of the edge associated with this part and state." )},
            { 3809, new PropertyInfo("TRANSPARENTCOLOR", 204, "The transparent color associated with this part and state. If the TMT_TRANSPARENT value for this part and state is TRUE, parts of the graphic that use this color are not drawn." )},
            { 3810, new PropertyInfo("GRADIENTCOLOR1", 204, "The first color of the gradient associated with this part and state." )},
            { 3811, new PropertyInfo("GRADIENTCOLOR2", 204, "The second color of the gradient." )},
            { 3812, new PropertyInfo("GRADIENTCOLOR3", 204, "The third color of the gradient." )},
            { 3813, new PropertyInfo("GRADIENTCOLOR4", 204, "The fourth color of the gradient." )},
            { 3814, new PropertyInfo("GRADIENTCOLOR5", 204, "The fifth color of the gradient." )},
            { 3815, new PropertyInfo("SHADOWCOLOR", 204, "The color of the shadow drawn underneath text associated with this part and state." )},
            { 3816, new PropertyInfo("GLOWCOLOR", 204, "The color of the glow produced by calling DrawThemeIcon using this part and state." )},
            { 3817, new PropertyInfo("TEXTBORDERCOLOR", 204, "The color of the text border associated with this part and state." )},
            { 3818, new PropertyInfo("TEXTSHADOWCOLOR", 204, "The color of the text shadow associated with this part and state." )},
            { 3819, new PropertyInfo("GLYPHTEXTCOLOR", 204, "The color that the font-based glyph associated with this part and state will use." )},
            { 3820, new PropertyInfo("GLYPHTRANSPARENTCOLOR", 204, "The transparent glyph color associated with this part and state. If the TMT_GLYPHTRANSPARENT value for this part and state is TRUE, parts of the glyph that use this color are not drawn." )},
            { 3821, new PropertyInfo("FILLCOLORHINT", 204, "The color used as a fill color hint for custom controls." )},
            { 3822, new PropertyInfo("BORDERCOLORHINT", 204, "The color used as a border color hint for custom controls." )},
            { 3823, new PropertyInfo("ACCENTCOLORHINT", 204, "The color used as an accent color hint for custom controls." )},
            { 3824, new PropertyInfo("TEXTCOLORHINT", 204, "" )},
            { 3825, new PropertyInfo("HEADING1TEXTCOLOR", 204, "" )},
            { 3826, new PropertyInfo("HEADING2TEXTCOLOR", 204, "" )},
            { 3827, new PropertyInfo("BODYTEXTCOLOR", 204, "" )},
            // ENUM
            { 4001, new PropertyInfo("BGTYPE", 200, "The basic drawing type for this part." )},
            { 4002, new PropertyInfo("BORDERTYPE", 200, "The type of border drawn if this part is a border fill." )},
            { 4003, new PropertyInfo("FILLTYPE", 200, "The type of fill shape drawn if this part is a border fill." )},
            { 4004, new PropertyInfo("SIZINGTYPE", 200, "The method used to size an image if this part uses an image file." )},
            { 4005, new PropertyInfo("HALIGN", 200, "The horizontal alignment if this part uses a true-size image." )},
            { 4006, new PropertyInfo("CONTENTALIGNMENT", 200, "The alignment of text in the caption associated with this part." )},
            { 4007, new PropertyInfo("VALIGN", 200, "The vertical alignment if this part uses a true-size image." )},
            { 4008, new PropertyInfo("OFFSETTYPE", 200, "The alignment of this part on the window." )},
            { 4009, new PropertyInfo("ICONEFFECT", 200, "The type of effect to be displayed when this part is drawn using DrawThemeIcon()." )},
            { 4010, new PropertyInfo("TEXTSHADOWTYPE", 200, "The type of shadow effect to draw behind text associated with this part." )},
            { 4011, new PropertyInfo("IMAGELAYOUT", 200, "The type of alignment used when multiple images are drawn." )},
            { 4012, new PropertyInfo("GLYPHTYPE", 200, "The type of glyph drawn on this part." )},
            { 4013, new PropertyInfo("IMAGESELECTTYPE", 200, "The type of method used to select between sized images for this part. " )},
            { 4014, new PropertyInfo("GLYPHFONTSIZINGTYPE", 200, "The type of method used to select between different-sized glyphs." )},
            { 4015, new PropertyInfo("TRUESIZESCALINGTYPE", 200, "The type of scaling used if this part uses a true-sized image." )},
            // BOOL
            { 5001, new PropertyInfo("USERPICTURE", 203, "" )},
            // RECT
            { 5002, new PropertyInfo("DEFAULTPANESIZE", 209, "The default size of the part." )},
            // COLOR
            { 5003, new PropertyInfo("BLENDCOLOR", 204, "The color used as a blend color." )},
            // RECT
            { 5004, new PropertyInfo("CUSTOMSPLITRECT", 209, "" )},
            { 5005, new PropertyInfo("ANIMATIONBUTTONRECT", 209, "" )},
            // INT
            { 5006, new PropertyInfo("ANIMATIONDURATION", 202, "" )},
            // Unknown props found in Win10 styles - High contrast mode related?
            { 5100, new PropertyInfo("UNKNOWN_5100_COLORLIST", 240, "" )},
            { 5101, new PropertyInfo("UNKNOWN_5101_COLORLIST", 240, "" )},
            { 5102, new PropertyInfo("UNKNOWN_5102_ENUM", 200, "" )},
            { 5103, new PropertyInfo("UNKNOWN_5103_COLORLIST", 240, "" )},
            { 5104, new PropertyInfo("UNKNOWN_5104_?", 0, "" )},
            { 5105, new PropertyInfo("UNKNOWN_5105_COLORLIST", 240, "" )},
            { 5106, new PropertyInfo("UNKNOWN_5106_?", 0, "" )},
            { 5107, new PropertyInfo("UNKNOWN_5107_MARGINS", 205, "" )},
            { 5108, new PropertyInfo("UNKNOWN_5108_?", 0, "" )},
            { 5109, new PropertyInfo("UNKNOWN_5109_?", 0, "" )},
            { 5110, new PropertyInfo("BORDERCOLOR_HIGHCONTRAST", 241, "" )},
            { 5111, new PropertyInfo("FILLCOLOR_HIGHCONTRAST", 241, "" )},
            { 5112, new PropertyInfo("TEXTCOLOR_HIGHCONTRAST", 241, "" )},
            { 5113, new PropertyInfo("UNKNOWN_5113_HC", 241, "" )},
            { 5114, new PropertyInfo("UNKNOWN_5114_HC", 241, "" )},
            { 5115, new PropertyInfo("TEXTBORDERCOLOR_HIGHCONTRAST", 241, "" )}, // ?
            { 5116, new PropertyInfo("UNKNOWN_5116_HC", 241, "" )},
            { 5117, new PropertyInfo("UNKNOWN_5117_HC", 241, "" )},
            { 5118, new PropertyInfo("HEADING1TEXTCOLOR_HIGHCONTRAST", 241, "" )},
            { 5119, new PropertyInfo("HEADING2TEXTCOLOR_HIGHCONTRAST", 241, "" )},
            { 5120, new PropertyInfo("BODYTEXTCOLOR_HIGHCONTRAST", 241, "" )},
            { 5121, new PropertyInfo("UNKNOWN_5121_HC", 241, "" )},
            { 5122, new PropertyInfo("UNKNOWN_5122_HC", 241, "" )},
            { 5128, new PropertyInfo("UNKNOWN_5128_INT", 202, "" )},
            { 5129, new PropertyInfo("UNKNOWN_5129_INT", 202, "" )},
            { 5130, new PropertyInfo("UNKNOWN_5130_INT", 202, "" )},
            { 5144, new PropertyInfo("IMAGEFILE1_LITE", 243, "" )},
            { 5145, new PropertyInfo("IMAGEFILE2_LITE", 243, "" )},
            { 5146, new PropertyInfo("IMAGEFILE3_LITE", 243, "" )},
            // INTLIST
            { 6000, new PropertyInfo("TRANSITIONDURATIONS", 211, "" )},
            // BOOL
            { 7001, new PropertyInfo("SCALEDBACKGROUND", 203, "" )},
            // DISKSTREAM
            { 8000, new PropertyInfo("ATLASIMAGE", 213, "" )},
            // STRING
            { 8001, new PropertyInfo("ATLASINPUTIMAGE", 201, "" )},
            // RECT
            { 8002, new PropertyInfo("ATLASRECT", 209, "" )},
            // Types found in AMAP
            { 20000, new PropertyInfo("ANIMATION", 241, "" )},
            { 20100, new PropertyInfo("TIMINGFUNCTION", 242, "")}
        };
    }
}
