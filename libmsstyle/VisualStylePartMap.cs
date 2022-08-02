using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libmsstyle
{
    public class VisualStylePartEntry
    {
        public VisualStylePartEntry(int id, string name, List<VisualStyleStateEntry> states)
        {
            Id = id;
            Name = name;
            States = states;
        }

        public int Id;
        public string Name;
        public List<VisualStyleStateEntry> States;
    }

    public class VisualStyleParts
    {
        public static readonly List<VisualStylePartEntry> PARTS_ADDRESSBAND = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "BACKGROUND", VisualStyleStates.STATES_EDITTEXT_BG ), // reuse states
        };

        public static readonly List<VisualStylePartEntry> PARTS_BARRIERPAGE = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "PANEBACKGROUND", VisualStyleStates.STATES_COMMON_DEFAULT ),
        };

        public static readonly List<VisualStylePartEntry> PARTS_BREADCRUMBBAR = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "OVERFLOWCHEVRON", VisualStyleStates.STATES_COMMON_DEFAULT ),
        };

        public static readonly List<VisualStylePartEntry> PARTS_BUTTON = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "PUSHBUTTON", VisualStyleStates.STATES_PUSHBUTTON ),
            new VisualStylePartEntry(2, "RADIOBUTTON", VisualStyleStates.STATES_RADIOBUTTON ),
            new VisualStylePartEntry(3, "CHECKBOX", VisualStyleStates.STATES_CHECKBOX ),
            new VisualStylePartEntry(4, "GROUPBOX", VisualStyleStates.STATES_GROUPBOX ),
            new VisualStylePartEntry(5, "USERBUTTON", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(6, "COMMANDLINK", VisualStyleStates.STATES_COMMANDLINK ),
            new VisualStylePartEntry(7, "COMMANDLINKGLYPH", VisualStyleStates.STATES_COMMANDLINKGLYPHS ),
            new VisualStylePartEntry(8, "RADIOBUTTON_LITE", VisualStyleStates.STATES_RADIOBUTTON ),
            new VisualStylePartEntry(9, "CHECKBOX_LITE", VisualStyleStates.STATES_CHECKBOX ),
            new VisualStylePartEntry(10, "GROUPBOX_LITE", VisualStyleStates.STATES_GROUPBOX ),
        };

        public static readonly List<VisualStylePartEntry> PARTS_CLOCK = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_PUSHBUTTON ),
            new VisualStylePartEntry(1, "TIME", VisualStyleStates.STATES_PUSHBUTTON ),
        };

        public static readonly List<VisualStylePartEntry> PARTS_CHARTVIEW = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "CPU_BACKGROUND", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(2, "CPU_BORDER", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(3, "CPU_GRID", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(4, "CPU_LINE1", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(5, "CPU_LINE1FILL", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(6, "CPU_LINE2", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(7, "CPU_LINE2FILL", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(8, "MEMORY_BACKGROUND", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(9, "MEMORY_BORDER", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(10, "MEMORY_GRID", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(11, "MEMORY_LINE1", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(12, "MEMORY_LINE1FILL", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(13, "MEMORY_LINE2", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(14, "MEMORY_LINE2FILL", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(15, "DISK_BACKGROUND", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(16, "DISK_BORDER", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(17, "DISK_GRID", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(18, "DISK_LINE1", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(19, "DISK_LINE1FILL", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(20, "DISK_LINE2", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(21, "DISK_LINE2FILL", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(22, "NETWORK_BACKGROUND", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(23, "NETWORK_BORDER", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(24, "NETWORK_GRID", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(25, "NETWORK_LINE1", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(26, "NETWORK_LINE1FILL", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(27, "NETWORK_LINE2", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(28, "NETWORK_LINE2FILL", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(29, "COPY_BORDER", VisualStyleStates.STATES_CHARTVIEW_LINE ),
            new VisualStylePartEntry(30, "COPY_GRID", VisualStyleStates.STATES_CHARTVIEW_LINE ),
            new VisualStylePartEntry(31, "COPY_LINE1", VisualStyleStates.STATES_CHARTVIEW_LINE ),
            new VisualStylePartEntry(32, "COPY_LINE1FILL", VisualStyleStates.STATES_CHARTVIEW_LINE ),
            new VisualStylePartEntry(33, "COPY_LINE2", VisualStyleStates.STATES_CHARTVIEW_LINE ),
            new VisualStylePartEntry(34, "COPY_LINE2FILL", VisualStyleStates.STATES_CHARTVIEW_LINE ),
            new VisualStylePartEntry(35, "CPU_SCALELINE", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(36, "CPU_SCALELINETEXT", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(37, "MEMORY_SCALELINE", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(38, "MEMORY_SCALELINETEXT", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(39, "DISK_SCALELINE", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(40, "DISK_SCALELINETEXT", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(41, "NETWORK_SCALELINE", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(42, "NETWORK_SCALELINETEXT", VisualStyleStates.STATES_COMMON_DEFAULT ),
        };

        public static readonly List<VisualStylePartEntry> PARTS_COMMANDMODULE_WINVista = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "MODULEBACKGROUND", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(2, "TASKBUTTON", VisualStyleStates.STATES_COMMANDMODULE_SPLITBUTTON ),
            new VisualStylePartEntry(3, "SPLITBUTTONLEFT", VisualStyleStates.STATES_COMMANDMODULE_SPLITBUTTON ),
            new VisualStylePartEntry(4, "SPLITBUTTONRIGHT", VisualStyleStates.STATES_COMMANDMODULE_SPLITBUTTON ),
            new VisualStylePartEntry(5, "MENUGLYPH", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(6, "OVERFLOWGLYPH", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(7, "LIBRARYPANEMENUGLYPH", VisualStyleStates.STATES_COMMANDMODULE_LIBRARYPANE_GEN ),
            new VisualStylePartEntry(8, "LIBRARYPANETOPVIEW", VisualStyleStates.STATES_COMMANDMODULE_LIBRARYPANE_GEN ),
            new VisualStylePartEntry(9, "LIBRARYPANEIDENTIFIER", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(10, "LIBRARYPANEBACKGROUND", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(11, "LIBRARYPANEOVERLAY", VisualStyleStates.STATES_COMMON_DEFAULT ),
        };

        public static readonly List<VisualStylePartEntry> PARTS_COMMANDMODULE_WIN7 = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "MODULEBACKGROUND", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(2, "MODULEBACKGROUNDCOLORS", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(3, "TASKBUTTON", VisualStyleStates.STATES_COMMANDMODULE_SPLITBUTTON ),
            new VisualStylePartEntry(4, "SPLITBUTTONLEFT", VisualStyleStates.STATES_COMMANDMODULE_SPLITBUTTON ),
            new VisualStylePartEntry(5, "SPLITBUTTONRIGHT", VisualStyleStates.STATES_COMMANDMODULE_SPLITBUTTON ),
            new VisualStylePartEntry(6, "MENUGLYPH", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(7, "OVERFLOWGLYPH", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(8, "LIBRARYPANEMENUGLYPH", VisualStyleStates.STATES_COMMANDMODULE_LIBRARYPANE_GEN ),
            new VisualStylePartEntry(9, "LIBRARYPANETOPVIEW", VisualStyleStates.STATES_COMMANDMODULE_LIBRARYPANE_GEN ),
            new VisualStylePartEntry(10, "LIBRARYPANEIDENTIFIER", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(11, "LIBRARYPANEBACKGROUND", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(12, "LIBRARYPANEOVERLAY", VisualStyleStates.STATES_COMMON_DEFAULT ),
        };

        public static readonly List<VisualStylePartEntry> PARTS_COMMANDMODULE_WIN8 = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "MODULEBACKGROUND", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(2, "MODULEBACKGROUNDCOLORS", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(3, "TASKBUTTON", VisualStyleStates.STATES_COMMANDMODULE_SPLITBUTTON ),
            new VisualStylePartEntry(4, "SPLITBUTTONLEFT", VisualStyleStates.STATES_COMMANDMODULE_SPLITBUTTON ),
            new VisualStylePartEntry(5, "SPLITBUTTONRIGHT", VisualStyleStates.STATES_COMMANDMODULE_SPLITBUTTON ),
            new VisualStylePartEntry(6, "MENUGLYPH", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(7, "OVERFLOWGLYPH", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(8, "LIBRARYPANEMENUGLYPH", VisualStyleStates.STATES_COMMANDMODULE_LIBRARYPANE_GEN ),
            new VisualStylePartEntry(9, "LIBRARYPANETOPVIEW", VisualStyleStates.STATES_COMMANDMODULE_LIBRARYPANE_GEN ),
            new VisualStylePartEntry(10, "LIBRARYPANEBACKGROUND", VisualStyleStates.STATES_COMMON_DEFAULT ),
        };

        public static readonly List<VisualStylePartEntry> PARTS_COMMUNICATIONS = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "TAB", VisualStyleStates.STATES_TAB ),
        };

        public static readonly List<VisualStylePartEntry> PARTS_COMBOBOX = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "DROPDOWNBUTTON", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(2, "BACKGROUND", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(3, "TRANSPARENTBACKGROUND", VisualStyleStates.STATES_CB_TRANSPARENTBG ),
            new VisualStylePartEntry(4, "BORDER", VisualStyleStates.STATES_CB_BORDER ),
            new VisualStylePartEntry(5, "READONLY", VisualStyleStates.STATES_CB_READONLY ),
            new VisualStylePartEntry(6, "DROPDOWNBUTTONRIGHT", VisualStyleStates.STATES_CB_DROPDOWNLR ),
            new VisualStylePartEntry(7, "DROPDOWNBUTTONLEFT", VisualStyleStates.STATES_CB_DROPDOWNLR ),
            new VisualStylePartEntry(8, "CUEBANNER", VisualStyleStates.STATES_CB_CUEBANNER ),
        };

        public static readonly List<VisualStylePartEntry> PARTS_CONTROLPANEL = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "NAVIGATIONPANE", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(2, "CONTENTPANE", VisualStyleStates.STATES_CONTROLPANEL_CONTENTPANE ),
            new VisualStylePartEntry(3, "NAVPANELLABEL", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(4, "CONTENTPANELLABEL", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(5, "TITLE", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(6, "BODYTEXT", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(7, "HELPLINK", VisualStyleStates.STATES_LINK_HELP ),
            new VisualStylePartEntry(8, "TASKLIST", VisualStyleStates.STATES_LINK_TASK ),
            new VisualStylePartEntry(9, "GROUPTEXT", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(10, "CONTENTLINK", VisualStyleStates.STATES_LINK_CONTENT ),
            new VisualStylePartEntry(11, "SECTIONTITLELINK", VisualStyleStates.STATES_LINK_SECTIONTITLE ),
            new VisualStylePartEntry(12, "LARGECOMMANDAREA", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(13, "SMALLCOMMANDAREA", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(14, "BUTTON", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(15, "MESSAGETEXT", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(16, "NAVIGATIONPANELINE", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(17, "CONTENTPANELINE", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(18, "BANNERAREA", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(19, "BODYTITLE", VisualStyleStates.STATES_COMMON_DEFAULT ),
        };

        public static readonly List<VisualStylePartEntry> PARTS_COPYCLOSE = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "COPYCLOSEBTN", VisualStyleStates.STATES_COPYCLOSEBTN ),
        };

        public static readonly List<VisualStylePartEntry> PARTS_DROPLIST = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "MENUBUTTON", VisualStyleStates.STATES_COMMON_DEFAULT ),
        };

        public static readonly List<VisualStylePartEntry> PARTS_EMPTYMARKUP = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "MARKUPTEXT", VisualStyleStates.STATES_COMMON_DEFAULT ),
        };

        public static readonly List<VisualStylePartEntry> PARTS_EXPLORERBAR = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "HEADERBACKGROUND", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(2, "HEADERCLOSE", VisualStyleStates.STATES_EXPLORERBAR_GENERAL ),
            new VisualStylePartEntry(3, "HEADERPIN", VisualStyleStates.STATES_EXPLORERBAR_HDRPIN ),
            new VisualStylePartEntry(4, "IEBARMENU", VisualStyleStates.STATES_EXPLORERBAR_GENERAL ),
            new VisualStylePartEntry(5, "NORMALGROUPBACKGROUND", VisualStyleStates.STATES_EXPLORERBAR_GENERAL ),
            new VisualStylePartEntry(6, "NORMALGROUPCOLLAPSE", VisualStyleStates.STATES_EXPLORERBAR_GENERAL ),
            new VisualStylePartEntry(7, "NORMALGROUPEXPAND", VisualStyleStates.STATES_EXPLORERBAR_GENERAL ),
            new VisualStylePartEntry(8, "NORMALGROUPHEAD", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(9, "SPECIALGROUPBACKGROUND", VisualStyleStates.STATES_EXPLORERBAR_GENERAL ),
            new VisualStylePartEntry(10, "SPECIALGROUPCOLLAPSE", VisualStyleStates.STATES_EXPLORERBAR_GENERAL ),
            new VisualStylePartEntry(11, "SPECIALGROUPEXPAND", VisualStyleStates.STATES_EXPLORERBAR_GENERAL ),
            new VisualStylePartEntry(12, "SPECIALGROUPHEAD", VisualStyleStates.STATES_COMMON_DEFAULT ),
        };

        public static readonly List<VisualStylePartEntry> PARTS_INFOBAR = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "BACKGROUND", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(2, "FOREGROUND", VisualStyleStates.STATES_COMMON_DEFAULT ), // W10
        };

        public static readonly List<VisualStylePartEntry> PARTS_ITEMSVIEW = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "SEARCHHIT", VisualStyleStates.STATES_ITEMSVIEW_SEARCHHIT ),
            new VisualStylePartEntry(2, "SUBSETBUTTON", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(3, "FOCUSRECT", VisualStyleStates.STATES_ITEMSVIEW_FOCUSRECT ),
            new VisualStylePartEntry(4, "PROPERTY", VisualStyleStates.STATES_ITEMSVIEW_PROPERTY ),
            new VisualStylePartEntry(5, "EMPTYTEXT", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(6, "FOCUSRECTINNER", VisualStyleStates.STATES_ITEMSVIEW_FOCUSRECT ), // W10
        };

        public static readonly List<VisualStylePartEntry> PARTS_LISTBOX = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "BORDER_HSCROLL", VisualStyleStates.STATES_LISTBOX_SCROLL ),
            new VisualStylePartEntry(2, "BORDER_HVSCROLL", VisualStyleStates.STATES_LISTBOX_SCROLL ),
            new VisualStylePartEntry(3, "BORDER_NOSCROLL", VisualStyleStates.STATES_LISTBOX_SCROLL ),
            new VisualStylePartEntry(4, "BORDER_VSCROLL", VisualStyleStates.STATES_LISTBOX_SCROLL ),
            new VisualStylePartEntry(5, "ITEM", VisualStyleStates.STATES_LISTBOX_ITEMS ),
        };

        public static readonly List<VisualStylePartEntry> PARTS_LISTVIEW = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "LISTITEM", VisualStyleStates.STATES_LISTVIEW_ITEMS ),
            new VisualStylePartEntry(2, "LISTGROUP", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(3, "LISTDETAIL", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(4, "LISTSORTEDDETAIL", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(5, "EMPTYTEXT", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(6, "GROUPHEADER", VisualStyleStates.STATES_LISTVIEW_GROUPHEADER_GENERAL ),
            new VisualStylePartEntry(7, "GROUPHEADERLINE", VisualStyleStates.STATES_LISTVIEW_GROUPHEADER_GENERAL ),
            new VisualStylePartEntry(8, "EXPANDBUTTON", VisualStyleStates.STATES_LISTVIEW_EXPCOLLAPSE ),
            new VisualStylePartEntry(9, "COLLAPSEBUTTON", VisualStyleStates.STATES_LISTVIEW_EXPCOLLAPSE ),
            new VisualStylePartEntry(10, "COLUMNDETAIL", VisualStyleStates.STATES_COMMON_DEFAULT ),
        };

        public static readonly List<VisualStylePartEntry> PARTS_LINK = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "HyperLink", VisualStyleStates.STATES_TOOLTIP_BALLOON_AND_STANDARD ), // reuse states
        };

        public static readonly List<VisualStylePartEntry> PARTS_MENU = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "MENUITEM", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(2, "MENUDROPDOWN", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(3, "MENUBARITEM", VisualStyleStates.STATES_MENU_BARITEM ),
            new VisualStylePartEntry(4, "MENUBARDROPDOWN", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(5, "CHEVRON", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(6, "SEPARATOR", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(7, "BARBACKGROUND", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(8, "BARITEM", VisualStyleStates.STATES_MENU_BARITEM ),
            new VisualStylePartEntry(9, "POPUPBACKGROUND", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(10, "POPUPBORDERS", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(11, "POPUPCHECK", VisualStyleStates.STATES_MENU_POPCHECK ),
            new VisualStylePartEntry(12, "POPUPCHECKBACKGROUND", VisualStyleStates.STATES_MENU_POPCHECKBG ),
            new VisualStylePartEntry(13, "POPUPGUTTER", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(14, "POPUPITEM", VisualStyleStates.STATES_MENU_POPITEMS ),
            new VisualStylePartEntry(15, "POPUPSEPARATOR", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(16, "POPUPSUBMENU", VisualStyleStates.STATES_MENU_SYSTEM_GENERAL ),
            new VisualStylePartEntry(17, "SYSTEMCLOSE", VisualStyleStates.STATES_MENU_SYSTEM_GENERAL ),
            new VisualStylePartEntry(18, "SYSTEMMAXIMIZE", VisualStyleStates.STATES_MENU_SYSTEM_GENERAL ),
            new VisualStylePartEntry(19, "SYSTEMMINIMIZE", VisualStyleStates.STATES_MENU_SYSTEM_GENERAL ),
            new VisualStylePartEntry(20, "SYSTEMRESTORE", VisualStyleStates.STATES_MENU_SYSTEM_GENERAL ),
        };

        public static readonly List<VisualStylePartEntry> PARTS_NAVIGATION = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "BACKBUTTON", VisualStyleStates.STATES_PUSHBUTTON ), // reuse button states
            new VisualStylePartEntry(2, "FORWARDBUTTON", VisualStyleStates.STATES_PUSHBUTTON ),
            new VisualStylePartEntry(3, "MENUBUTTON", VisualStyleStates.STATES_PUSHBUTTON ),
        };

        public static readonly List<VisualStylePartEntry> PARTS_TREEVIEW = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "TREEITEM", VisualStyleStates.STATES_TREEVIEW_ITEM ),
            new VisualStylePartEntry(2, "GLYPH", VisualStyleStates.STATES_TREEVIEW_GLYPH ),
            new VisualStylePartEntry(3, "BRANCH", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(4, "HOTGLYPH", VisualStyleStates.STATES_TREEVIEW_GLYPH ),
        };

        public static readonly List<VisualStylePartEntry> PARTS_WINDOW = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "CAPTION", VisualStyleStates.STATES_WINDOW_CAPTION_GEN ),
            new VisualStylePartEntry(2, "SMALLCAPTION", VisualStyleStates.STATES_WINDOW_CAPTION_GEN ),
            new VisualStylePartEntry(3, "MINCAPTION", VisualStyleStates.STATES_WINDOW_CAPTION_GEN ),
            new VisualStylePartEntry(4, "SMALLMINCAPTION", VisualStyleStates.STATES_WINDOW_CAPTION_GEN ),
            new VisualStylePartEntry(5, "MAXCAPTION", VisualStyleStates.STATES_WINDOW_CAPTION_GEN ),
            new VisualStylePartEntry(6, "SMALLMAXCAPTION", VisualStyleStates.STATES_WINDOW_CAPTION_GEN ),
            new VisualStylePartEntry(7, "FRAMELEFT", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(8, "FRAMERIGHT", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(9, "FRAMEBOTTOM", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(10, "SMALLFRAMELEFT", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(11, "SMALLFRAMERIGHT", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(12, "SMALLFRAMEBOTTOM", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(13, "SYSBUTTON", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(14, "MDISYSBUTTON", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(15, "MINBUTTON", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(16, "MDIMINBUTTON", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(17, "MAXBUTTON", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(18, "CLOSEBUTTON", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(19, "SMALLCLOSEBUTTON", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(20, "MDICLOSEBUTTON", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(21, "RESTOREBUTTON", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(22, "MDIRESTOREBUTTON", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(23, "HELPBUTTON", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(24, "MDIHELPBUTTON", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(25, "HORZSCROLL", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(26, "HORZTHUMB", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(27, "VERTSCROLL", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(28, "VERTTHUMB", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(29, "DIALOG", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(30, "CAPTIONSIZINGTEMPLATE", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(31, "SMALLCAPTIONSIZINGTEMPLATE", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(32, "FRAMELEFTSIZINGTEMPLATE", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(33, "SMALLFRAMELEFTSIZINGTEMPLATE", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(34, "FRAMERIGHTSIZINGTEMPLATE", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(35, "SMALLFRAMERIGHTSIZINGTEMPLATE", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(36, "FRAMEBOTTOMSIZINGTEMPLATE", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(37, "SMALLFRAMEBOTTOMSIZINGTEMPLATE", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(38, "FRAME", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(39, "BORDER", VisualStyleStates.STATES_COMMON_DEFAULT ),
        };

        public static readonly List<VisualStylePartEntry> PARTS_DWMPEN = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "PENBARREL", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(2, "PENHOLD", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(3, "PENRIGHTTAP", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(4, "PENTAP", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(5, "PENDOUBLETAP", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(6, "FLICKSCROLLUP", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(7, "FLICKSCROLLDOWN", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(8, "FLICKDRAGUP", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(9, "FLICKDRAGDOWN", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(10, "FLICKFORWARD", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(11, "FLICKBACKWARD", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(12, "FLICKCUT", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(13, "FLICKCOPY", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(14, "FLICKPASTE", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(15, "FLICKUNDO", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(16, "FLICKREDO", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(17, "FLICKPRINT", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(18, "FLICKDELETE", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(19, "FLICKOPEN", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(20, "FLICKSAVE", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(21, "FLICKMODIFIERKEY", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(22, "FLICKSHIFTKEY", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(23, "FLICKWINKEY", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(24, "FLICKGENERICKEY", VisualStyleStates.STATES_COMMON_DEFAULT ),
        };

        public static readonly List<VisualStylePartEntry> PARTS_DWMTOUCH = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "TOUCHDRAG", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(2, "TOUCHCONTACT", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(3, "TETHER", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(4, "TEXTHANDLEBLACK", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(5, "TEXTHANDLEWHITE", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(6, "TOUCHDOUBLECONTACT", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(7, "TOUCHCONTACTPRESENTATIONMODE", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(8, "INDIRECTTOUCH", VisualStyleStates.STATES_COMMON_DEFAULT ),
        };

        // Uses custom naming.
        public static readonly List<VisualStylePartEntry> PARTS_DWMWINDOW_WIN7 = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "FRAMEBOTTOM", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(2, "FRAMEBOTTOMSHADOW", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(3, "RESTOREBUTTON", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(4, "RESTOREBUTTONINACTIVE", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(5, "MINBUTTON", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(6, "MINBUTTONINACTIVE", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(7, "CLOSEBUTTON", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(8, "CLOSEBUTTONINACTIVE", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(9, "CLOSEBUTTON_ONLY", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(10, "CLOSEBUTTON_ONLY", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(11, "CLOSEBUTTONGLOW", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(12, "CLOSEBUTTON_GLYPH_96", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(13, "CLOSEBUTTON_GLYPH_120", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(14, "CLOSEBUTTON_GLYPH_144", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(15, "CLOSEBUTTON_GLYPH_192", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(16, "MINMAXBUTTONGLOW", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(17, "HELPBUTTON_GLYPH_96", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(18, "HELPBUTTON_GLYPH_120", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(19, "HELPBUTTON_GLYPH_144", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(20, "HELPBUTTON_GLYPH_192", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(21, "MAXBUTTON_GLYPH_96", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(22, "MAXBUTTON_GLYPH_120", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(23, "MAXBUTTON_GLYPH_144", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(24, "MAXBUTTON_GLYPH_192", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(25, "MINBUTTON_GLYPH_96", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(26, "MINBUTTON_GLYPH_120", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(27, "MINBUTTON_GLYPH_144", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(28, "MINBUTTON_GLYPH_192", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(29, "RESTOREBUTTON_GLYPH_96", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(30, "RESTOREBUTTON_GLYPH_120", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(31, "RESTOREBUTTON_GLYPH_144", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(32, "RESTOREBUTTON_GLYPH_192", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(33, "FRAMELEFT", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(34, "FRAMELEFT_EFFECT", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(35, "FRAMELEFTSHADOW", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(36, "FRAMEBOTTOMFADE", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(37, "FRAMELEFTFADE", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(38, "FRAMERIGHTFADE", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(39, "FRAMETOPFADE", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(40, "REFLECTIONS", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(41, "FRAMERIGHT", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(42, "FRAMERIGHTSHADOW", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(43, "SIDEHIGHLIGHT", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(44, "TOOLFRAMEBOTTOM", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(45, "TOOLCLOSEBUTTON", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(46, "TOOLCLOSEBUTTON_INACTIVE", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(47, "TOOLCLOSEBUTTONGLOW", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(48, "TOOLCLOSEBUTTON_GLYPH_96", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(49, "TOOLCLOSEBUTTON_GLYPH_120", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(50, "TOOLCLOSEBUTTON_GLYPH_144", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(51, "TOOLCLOSEBUTTON_GLYPH_192", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(52, "TOOLFRAMELEFT", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(53, "TOOLFRAMERIGHT", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(54, "TOOLFRAMETOP", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(55, "TEXTGLOW", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(56, "FRAMETOP", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(57, "FRAMETOPSHADOW", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(58, "FRAMETOP_NOSHADOW", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(59, "FRAMEBOTTOM_NOSHADOW", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(60, "FRAMELEFT_PEEK", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(61, "FRAMERIGHT_PEEK", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(62, "FRAMETOP_PEEK", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(63, "FRAMEBOTTOM_PEEK", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(64, "TOOLFRAMELEFT_PEEK", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(65, "TOOLFRAMERIGHT_PEEK", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(66, "TOOLFRAMETOP_PEEK", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(67, "TOOLFRAMEBOTTOM_PEEK", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(68, "SPINNER", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(69, "SNAPINDICATOR", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(70, "FRAMETOP_SELECTED", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(71, "FRAMEBOTTOM_SELECTED", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
        };

        // Incomplete and maybe incorrect list of parts for Win 8.1, derived from W7
        // and guesswork?? Can't remember. Uses custom naming.. TODO: consult PDBs
        public static readonly List<VisualStylePartEntry> PARTS_DWMWINDOW_WIN81 = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "FRAMEBOTTOM", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(2, "FRAMEBOTTOMSHADOW", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(3, "RESTOREBUTTON", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(4, "RESTOREBUTTONINACTIVE", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(5, "MINBUTTON", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(6, "MINBUTTONINACTIVE", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(7, "CLOSEBUTTON", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(8, "CLOSEBUTTONINACTIVE", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(9, "CLOSEBUTTON_ONLY", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(10, "CLOSEBUTTON_ONLY_INACTIVE", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(11, "Part 11", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(12, "CLOSEBUTTON_96", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(13, "CLOSEBUTTON_120", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(14, "CLOSEBUTTON_144", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(15, "CLOSEBUTTON_192", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(16, "HELPBUTTON_96", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(17, "HELPBUTTON_120", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(18, "HELPBUTTON_144", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(19, "HELPBUTTON_192", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(20, "MAXBUTTON_96", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(21, "MAXBUTTON_120", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(22, "MAXBUTTON_144", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(23, "MAXBUTTON_192", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(24, "MINBUTTON_96", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(25, "MINBUTTON_120", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(26, "MINBUTTON_144", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(27, "MINBUTTON_192", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(28, "RESTOREBUTTON_96", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(29, "RESTOREBUTTON_120", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(30, "RESTOREBUTTON_144", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(31, "RESTOREBUTTON_192", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(32, "FRAMELEFT", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(33, "FRAMELEFTSHADOW", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(34, "FRAMERIGHT", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(35, "FRAMERIGHTSHADOW", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(36, "TOOLFRAMEBOTTOM", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(37, "TOOLCLOSE", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(38, "TOOLCLOSEINACTIVE", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(39, "TOOLCLOSEGLYPH_96", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(40, "TOOLCLOSEGLYPH_120", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(41, "TOOLCLOSEGLYPH_144", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(42, "TOOLCLOSEGLYPH_192", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(43, "TOOLFRAMELEFT", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(44, "TOOLFRAMERIGHT", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(45, "TOOLFRAMETOP", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(46, "TEXTGLOW", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(47, "FRAMETOP", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(48, "FRAMETOPSHADOW", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(49, "FRAMETOP_NOSHADOW", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(50, "FRAMEBOTTOM_NOSHADOW", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(51, "FRAMELEFT_PEEK", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(52, "FRAMERIGHT_PEEK", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(53, "FRAMETOP_PEEK", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(54, "FRAMEBOTTOM_PEEK", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(55, "TOOLFRAMELEFT_PEEK", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(56, "TOOLFRAMERIGHT_PEEK", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(57, "TOOLFRAMETOP_PEEK", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(58, "TOOLFRAMEBOTTOM_PEEK", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(59, "SPINNER", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(60, "SNAPINDICATOR", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(61, "FRAMETOP_NOSHADOW_PEEK", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(62, "FRAMEBOTTOM_NOSHADOW_PEEK", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(63, "FRAMEBACKGROUND_PEEK", VisualStyleStates.STATES_WINDOW_FRAME_GEN)
        };

        // Definitive parts for W10, using the real names from the PDBs
        // States are generic and might not match every part.
        public static readonly List<VisualStylePartEntry> PARTS_DWMWINDOW_WIN10 = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "BOTTOMFRAME", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(2, "BOTTOMSHADOW", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(3, "BUTTONACTIVECAPTION", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(4, "BUTTONINACTIVECAPTION", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(5, "BUTTONACTIVECAPTIONEND", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(6, "BUTTONINACTIVECAPTIONEND", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(7, "BUTTONACTIVECLOSE", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(8, "BUTTONINACTIVECLOSE", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(9, "BUTTONACTIVECLOSEALONE", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(10, "BUTTONINACTIVECLOSEALONE", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(11, "BUTTONCLOSEGLYPH96", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(12, "BUTTONCLOSEGLYPH120", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(13, "BUTTONCLOSEGLYPH144", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(14, "BUTTONCLOSEGLYPH192", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(15, "BUTTONHELPGLYPH96", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(16, "BUTTONHELPGLYPH120", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(17, "BUTTONHELPGLYPH144", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(18, "BUTTONHELPGLYPH192", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(19, "BUTTONMAXGLYPH96", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(20, "BUTTONMAXGLYPH120", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(21, "BUTTONMAXGLYPH144", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(22, "BUTTONMAXGLYPH192", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(23, "BUTTONMINGLYPH96", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(24, "BUTTONMINGLYPH120", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(25, "BUTTONMINGLYPH144", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(26, "BUTTONMINGLYPH192", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(27, "BUTTONRESTOREGLYPH96", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(28, "BUTTONRESTOREGLYPH120", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(29, "BUTTONRESTOREGLYPH144", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(30, "BUTTONRESTOREGLYPH192", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(31, "LEFTFRAME", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(32, "LEFTSHADOW", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(33, "RIGHTFRAME", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(34, "RIGHTSHADOW", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(35, "SMALLBOTTOMFRAME", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(36, "SMALLBUTTONACTIVECLOSE", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(37, "SMALLBUTTONINACTIVECLOSE", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(38, "SMALLBUTTONCLOSEGLYPH96", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(39, "SMALLBUTTONCLOSEGLYPH120", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(40, "SMALLBUTTONCLOSEGLYPH144", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(41, "SMALLBUTTONCLOSEGLYPH192", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(42, "SMALLLEFTFRAME", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(43, "SMALLRIGHTFRAME", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(44, "SMALLTOPFRAME", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(45, "TEXTGLOW", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(46, "TOPFRAME", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(47, "TOPSHADOW", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(48, "TOPFRAMENOSHADOW", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(49, "BOTTOMFRAMENOSHADOW", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(50, "LEFTFRAMESQUEEGEE", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(51, "RIGHTFRAMESQUEEGEE", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(52, "TOPFRAMESQUEEGEE", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(53, "BOTTOMFRAMESQUEEGEE", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(54, "SMALLLEFTFRAMESQUEEGEE", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(55, "SMALLRIGHTFRAMESQUEEGEE", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(56, "SMALLTOPFRAMESQUEEGEE", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(57, "SMALLBOTTOMFRAMESQUEEGEE", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(58, "BITMAPPENDING", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(59, "RIPPLE", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(60, "TOPFRAMESQUEEGEENOSHADOW", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(61, "BOTTOMFRAMESQUEEGEENOSHADOW", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(62, "SQUEEGEEREFLECTIONMAP", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(63, "THUMBNAILBORDER", VisualStyleStates.STATES_WINDOW_FRAME_GEN ),
            new VisualStylePartEntry(64, "BUTTONCLOSEGLYPH96DARK", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(65, "BUTTONCLOSEGLYPH120DARK", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(66, "BUTTONCLOSEGLYPH144DARK", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(67, "BUTTONCLOSEGLYPH192DARK", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(68, "BUTTONHELPGLYPH96DARK", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(69, "BUTTONHELPGLYPH120DARK", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(70, "BUTTONHELPGLYPH144DARK", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(71, "BUTTONHELPGLYPH192DARK", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(72, "BUTTONMAXGLYPH96DARK", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(73, "BUTTONMAXGLYPH120DARK", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(74, "BUTTONMAXGLYPH144DARK", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(75, "BUTTONMAXGLYPH192DARK", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(76, "BUTTONMINGLYPH96DARK", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(77, "BUTTONMINGLYPH120DARK", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(78, "BUTTONMINGLYPH144DARK", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(79, "BUTTONMINGLYPH192DARK", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(80, "BUTTONRESTOREGLYPH96DARK", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(81, "BUTTONRESTOREGLYPH120DARK", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(82, "BUTTONRESTOREGLYPH144DARK", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(83, "BUTTONRESTOREGLYPH192DARK", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(84, "SMALLBUTTONCLOSEGLYPH96DARK", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(85, "SMALLBUTTONCLOSEGLYPH120DARK", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(86, "SMALLBUTTONCLOSEGLYPH144DARK", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(87, "SMALLBUTTONCLOSEGLYPH192DARK", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(88, "BUTTONACTIVECAPTIONDARK", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(89, "BUTTONINACTIVECAPTIONDARK", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(90, "BUTTONACTIVECAPTIONENDDARK", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
            new VisualStylePartEntry(91, "BUTTONINACTIVECAPTIONENDDARK", VisualStyleStates.STATES_WINDOW_BTN_AND_THUMB ),
        };

        public static readonly List<VisualStylePartEntry> PARTS_EDIT = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "EDITTEXT", VisualStyleStates.STATES_EDITTEXT ),
            new VisualStylePartEntry(2, "CARET", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(3, "BACKGROUND", VisualStyleStates.STATES_EDITTEXT_BG ),
            new VisualStylePartEntry(4, "PASSWORD", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(5, "BACKGROUNDWITHBORDER", VisualStyleStates.STATES_EDITTEXT_BGWITHBORDER ),
            new VisualStylePartEntry(6, "EDITBORDER_NOSCROLL", VisualStyleStates.STATES_EDITTEXT_GENERAL ),
            new VisualStylePartEntry(7, "EDITBORDER_HSCROLL", VisualStyleStates.STATES_EDITTEXT_GENERAL ),
            new VisualStylePartEntry(8, "EDITBORDER_VSCROL", VisualStyleStates.STATES_EDITTEXT_GENERAL ),
            new VisualStylePartEntry(9, "EDITBORDER_HVSCROLL", VisualStyleStates.STATES_EDITTEXT_GENERAL ),
        };

        public static readonly List<VisualStylePartEntry> PARTS_TASKDIALOG = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "PRIMARYPANEL", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(2, "MAININSTRUCTIONPANE", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(3, "MAINICON", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(4, "CONTENTPANE", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(5, "CONTENTICON", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(6, "EXPANDEDCONTENT", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(7, "COMMANDLINKPANE", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(8, "SECONDARYPANEL", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(9, "CONTROLPANE", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(10, "BUTTONSECTION", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(11, "BUTTONWRAPPER", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(12, "EXPANDOTEXT", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(13, "EXPANDOBUTTON", VisualStyleStates.STATES_TASKDLG_EXPANDOBUTTON ),
            new VisualStylePartEntry(14, "VERIFICATIONTEXT", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(15, "FOOTNOTEPANE", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(16, "FOOTNOTEAREA", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(17, "FOOTNOTESEPARATOR", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(18, "EXPANDEDFOOTERAREA", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(19, "PROGRESSBAR", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(20, "IMAGEALIGNMENT", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(21, "RADIOBUTTONPANE", VisualStyleStates.STATES_COMMON_DEFAULT ),
        };

        public static readonly List<VisualStylePartEntry> PARTS_HEADER = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "HEADERITEM", VisualStyleStates.STATES_HEADER_ITEMSTATES ),
            new VisualStylePartEntry(2, "HEADERITEMLEFT", VisualStyleStates.STATES_HEADER_LEFT_AND_RIGHT ),
            new VisualStylePartEntry(3, "HEADERITEMRIGHT", VisualStyleStates.STATES_HEADER_LEFT_AND_RIGHT ),
            new VisualStylePartEntry(4, "HEADERSORTARROW", VisualStyleStates.STATES_HEADERSORTARROWSTATES ),
            new VisualStylePartEntry(5, "HEADERDROPDOWN", VisualStyleStates.STATES_HEADERDROPDOWNSTATES ),
            new VisualStylePartEntry(6, "HEADERDROPDOWNFILTER", VisualStyleStates.STATES_HEADERDROPDOWNFILTERSTATES ),
            new VisualStylePartEntry(7, "HEADEROVERFLOW", VisualStyleStates.STATES_HEADEROVERFLOWSTATES ),
        };

        public static readonly List<VisualStylePartEntry> PARTS_READINGPANE = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "BACKGROUNDCOLORS", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(2, "LABEL", VisualStyleStates.STATES_COMMON_DEFAULT ),
        };

        public static readonly List<VisualStylePartEntry> PARTS_REBAR = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "GRIPPER", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(2, "GRIPPERVERT", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(3, "BAND", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(4, "CHEVRON", VisualStyleStates.STATES_REBAR_GENERAL ),
            new VisualStylePartEntry(5, "CHEVRONVERT", VisualStyleStates.STATES_REBAR_GENERAL ),
            new VisualStylePartEntry(6, "BACKGROUND", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(7, "SPLITTER", VisualStyleStates.STATES_REBAR_GENERAL ),
            new VisualStylePartEntry(8, "SPLITTERVERT", VisualStyleStates.STATES_REBAR_GENERAL ),
        };

        public static readonly List<VisualStylePartEntry> PARTS_AEROWIZARD = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "TITLEBAR", VisualStyleStates.STATES_WINDOW_FRAME_GEN ), // reuse
            new VisualStylePartEntry(2, "HEADERAREA", VisualStyleStates.STATES_AEROWIZARD_HEADERAREA ),
            new VisualStylePartEntry(3, "CONTENTAREA", VisualStyleStates.STATES_AEROWIZARD_HEADERAREA ),
            new VisualStylePartEntry(4, "COMMANDAREA", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(5, "BUTTON", VisualStyleStates.STATES_COMMON_DEFAULT ),
        };

        public static readonly List<VisualStylePartEntry> PARTS_PAUSE = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "PAUSEBUTTON", VisualStyleStates.STATES_COMMON_DEFAULT ),
        };

        public static readonly List<VisualStylePartEntry> PARTS_PROGRESS = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "BAR", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(2, "BARVERT", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(3, "CHUNK", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(4, "CHUNKVERT", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(5, "FILL", VisualStyleStates.STATES_PROGRESS_FILL_GENERAL ),
            new VisualStylePartEntry(6, "FILLVERT", VisualStyleStates.STATES_PROGRESS_FILL_GENERAL ),
            new VisualStylePartEntry(7, "PULSEOVERLAY", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(8, "MOVEOVERLAY", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(9, "PULSEOVERLAYVERT", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(10, "MOVEOVERLAYVERT", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(11, "TRANSPARENTBAR", VisualStyleStates.STATES_PROGRESS_TRANSPARENT_GENERAL ),
            new VisualStylePartEntry(12, "TRANSPARENTBARVERT", VisualStyleStates.STATES_PROGRESS_TRANSPARENT_GENERAL ),
        };

        public static readonly List<VisualStylePartEntry> PARTS_PROPERTREE = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "FOLDERSHEADER", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(2, "BACKGROUND", VisualStyleStates.STATES_COMMON_DEFAULT ),
        };

        public static readonly List<VisualStylePartEntry> PARTS_PREVIEWPANE = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "PREVIEWBACKGROUND", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(2, "EDITPROPERTIES", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(3, "NAVPANESIZER", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(4, "READINGPANESIZER", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(5, "TITLE", VisualStyleStates.STATES_PROGRESS_FILL_GENERAL ),
            new VisualStylePartEntry(6, "LABEL", VisualStyleStates.STATES_PROGRESS_FILL_GENERAL ),
            new VisualStylePartEntry(7, "VALUE", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(8, "LABELCID", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(9, "VALUECID", VisualStyleStates.STATES_COMMON_DEFAULT )
        };

        public static readonly List<VisualStylePartEntry> PARTS_TRACKBAR = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "TRACK", VisualStyleStates.STATES_TRACKBAR_GENERAL ),
            new VisualStylePartEntry(2, "TRACKVERT", VisualStyleStates.STATES_TRACKBAR_GENERAL ),
            new VisualStylePartEntry(3, "THUMB", VisualStyleStates.STATES_TRACKBAR_THUMB_GEN ),
            new VisualStylePartEntry(4, "THUMBBOTTOM", VisualStyleStates.STATES_TRACKBAR_THUMB_GEN ),
            new VisualStylePartEntry(5, "THUMBTOP", VisualStyleStates.STATES_TRACKBAR_THUMB_GEN ),
            new VisualStylePartEntry(6, "THUMBVERT", VisualStyleStates.STATES_TRACKBAR_THUMB_GEN ),
            new VisualStylePartEntry(7, "THUMBLEFT", VisualStyleStates.STATES_TRACKBAR_THUMB_GEN ),
            new VisualStylePartEntry(8, "THUMBRIGHT", VisualStyleStates.STATES_TRACKBAR_THUMB_GEN ),
            new VisualStylePartEntry(9, "TICS", VisualStyleStates.STATES_TRACKBAR_GENERAL ),
            new VisualStylePartEntry(10, "TICSVERT", VisualStyleStates.STATES_TRACKBAR_GENERAL ),
        };

        public static readonly List<VisualStylePartEntry> PARTS_TAB = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "TABITEM", VisualStyleStates.STATES_TABITEM_GENERAL ),
            new VisualStylePartEntry(2, "TABITEMLEFTEDGE", VisualStyleStates.STATES_TABITEM_GENERAL ),
            new VisualStylePartEntry(3, "TABITEMRIGHTEDGE", VisualStyleStates.STATES_TABITEM_GENERAL ),
            new VisualStylePartEntry(4, "TABITEMBOTHEDGE", VisualStyleStates.STATES_TABITEM_GENERAL ),
            new VisualStylePartEntry(5, "TOPTABITEM", VisualStyleStates.STATES_TABITEM_GENERAL ),
            new VisualStylePartEntry(6, "TOPTABITEMLEFTEDGE", VisualStyleStates.STATES_TABITEM_GENERAL ),
            new VisualStylePartEntry(7, "TOPTABITEMRIGHTEDGE", VisualStyleStates.STATES_TABITEM_GENERAL ),
            new VisualStylePartEntry(8, "TOPTABITEMBOTHEDGE", VisualStyleStates.STATES_TABITEM_GENERAL ),
            new VisualStylePartEntry(9, "PANE", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(10, "BODY", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(11, "AEROWIZARDBODY", VisualStyleStates.STATES_COMMON_DEFAULT ),
        };

        public static readonly List<VisualStylePartEntry> PARTS_TOOLTIP = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "STANDARD", VisualStyleStates.STATES_TOOLTIP_BALLOON_AND_STANDARD ),
            new VisualStylePartEntry(2, "STANDARDTITLE", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(3, "BALLOON", VisualStyleStates.STATES_TOOLTIP_BALLOON_AND_STANDARD ),
            new VisualStylePartEntry(4, "BALLOONTITLE", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(5, "CLOSE", VisualStyleStates.STATES_TOOLTIP_CLOSE ),
            new VisualStylePartEntry(6, "BALLOONSTEM", VisualStyleStates.STATES_TOOLTIP_BALLOONSTEM ),
            new VisualStylePartEntry(7, "WRENCH", VisualStyleStates.STATES_TOOLTIP_WRENCH ),
        };

        public static readonly List<VisualStylePartEntry> PARTS_TOOLBAR = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_TOOLBARSTYLE ),
            new VisualStylePartEntry(1, "BUTTON", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(2, "DROPDOWNBUTTON", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(3, "SPLITBUTTON", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(4, "SPLITBUTTONDROPDOWN", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(5, "SEPARATOR", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(6, "SEPARATORVERT", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(7, "DROPDOWNBUTTONGLYPH", VisualStyleStates.STATES_COMMON_DEFAULT ),
        };

        public static readonly List<VisualStylePartEntry> PARTS_TASKBARPEARL = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "PEARLICON", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(2, "TABLETMODEPEARLICON", VisualStyleStates.STATES_COMMON_DEFAULT ),
        };

        public static readonly List<VisualStylePartEntry> PARTS_TASKBARSHOWDESKTOP = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "SHOWDESKTOPTHEME", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(2, "DIVIDERLINE", VisualStyleStates.STATES_COMMON_DEFAULT ),
        };

        public static readonly List<VisualStylePartEntry> PARTS_TASKBAND = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "GROUPCONTENT", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(2, "FLASHBUTTON", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(3, "FLASHBUTTONGROUPMENU", VisualStyleStates.STATES_COMMON_DEFAULT ),
        };

        public static readonly List<VisualStylePartEntry> PARTS_TASKBAND2 = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "BARTOP", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(2, "BARBOTTOM", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(3, "BARRIGHT", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(4, "BARLEFT", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(5, "TASKITEM", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(6, "TASKITEMLEFT", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(7, "TASKITEMCENTER", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(8, "TASKITEMRIGHT", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(9, "PROGRESSITEM", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(10, "PROGRESSITEMINDETERMINATE", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(11, "PROGRESSITEMERROR", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(12, "PROGRESSITEMPAUSED", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(13, "TASKITEMGROUP", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(14, "TASKITEMGROUPSELECTED", VisualStyleStates.STATES_COMMON_DEFAULT ),
        };

        public static readonly List<VisualStylePartEntry> PARTS_TASKBANDEXUI = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "BACKGROUND", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(2, "BACKGROUNDSHADOW", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(3, "THUMBRECT", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(4, "WINDOWTEXT", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(5, "SHADOW", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(6, "ACTIVERECT", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(7, "PREVACTIVERECT", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(8, "THUMBBARBUTTONSINGLE", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(9, "THUMBBARBUTTONLEFT", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(10, "THUMBBARBUTTONMIDDLE", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(11, "THUMBBARBUTTONRIGHT", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(12, "CLOSEBUTTON", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(13, "ARROWBUTTON", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(14, "THUMBSHADOWRIGHT", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(15, "THUMBSHADOWBOTTOM", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(16, "WINDOWBORDER", VisualStyleStates.STATES_COMMON_DEFAULT ),
        };

        public static readonly List<VisualStylePartEntry> PARTS_TASKMANAGER = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "ROW", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(2, "COLUMNDIVIDER", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(3, "HEATMAP_COLOR0", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(4, "HEATMAP_COLOR1", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(5, "HEATMAP_COLOR2", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(6, "HEATMAP_COLOR3", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(7, "HEATMAP_COLOR4", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(8, "HEATMAP_COLOR5", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(9, "HEATMAP_COLOR6", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(10, "HEATMAP_COLOR7", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(11, "HEATMAP_COLOR8", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(12, "HEATMAP_CONTENTIONMARKER", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(13, "HEATMAP_TEXT", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(14, "RESOURCE_TITLE", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(15, "RESOURCE_SUBTITLE", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(16, "GROUPLABEL", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(17, "STATICLABEL", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(18, "STATICDATA", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(19, "DYNAMICDATA", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(20, "MEMORYBAR_AVAILABLE", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(21, "MEMORYBAR_INUSE", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(22, "MEMORYBAR_MODIFIED", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(23, "MEMORYBAR_INUSE_SEPARATOR", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(24, "COLUMNHEADERTEXT", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(25, "CPU_HEATMAP_TEXT", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(26, "CPU_HEATMAP_COLOR0", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(27, "CPU_HEATMAP_COLOR1", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(28, "CPU_HEATMAP_COLOR2", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(29, "CPU_HEATMAP_COLOR3", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(30, "CPU_HEATMAP_COLOR4", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(31, "CPU_HEATMAP_COLOR5", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(32, "CPU_HEATMAP_PARKED0", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(33, "CPU_HEATMAP_PARKED1", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(34, "CPU_HEATMAP_PARKED2", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(35, "CPU_HEATMAP_PARKED3", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(36, "CPU_HEATMAP_PARKED4", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(37, "CPU_HEATMAP_PARKED5", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(38, "CPU_HEATMAP_GRID_BORDER", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(39, "CPU_HEATMAP_BLOCK_BORDER_R", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(40, "CPU_HEATMAP_BLOCK_BORDER_B", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(41, "COLHEADER_DIVIDER_COLOR1", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(42, "COLHEADER_DIVIDER_COLOR2", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(43, "CONTENTION_COLUMN_HEADER", VisualStyleStates.STATES_HEADEROVERFLOWSTATES ), // reuse
            new VisualStylePartEntry(44, "CHARTLEGEND", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(45, "COLUMNDIVIDERSELECTED", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(46, "COLUMNDIVIDERHOT", VisualStyleStates.STATES_COMMON_DEFAULT ),
        };

        public static readonly List<VisualStylePartEntry> PARTS_TEXTSELECTIONGRIPPER = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "GRIPPER", VisualStyleStates.STATES_COMMON_DEFAULT ),
        };

        public static readonly List<VisualStylePartEntry> PARTS_TEXTGLOW = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "BACKGROUND", VisualStyleStates.STATES_COMMON_DEFAULT ),
        };

        public static readonly List<VisualStylePartEntry> PARTS_TEXTSTYLE = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "MAININSTRUCTION", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(2, "INSTRUCTION", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(3, "BODYTITLE", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(4, "BODYTEXT", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(5, "SECONDARYTEXT", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(6, "HYPERLINKTEXT", VisualStyleStates.STATES_TEXTSTYLE_HLINK ),
            new VisualStylePartEntry(7, "EXPANDED", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(8, "LABEL", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(9, "CONTROLLABEL", VisualStyleStates.STATES_TEXTSTYLE_CTRLLABEL ),
        };

        public static readonly List<VisualStylePartEntry> PARTS_TRAYNOTIFY = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "BACKGROUND", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(2, "ANIMBACKGROUND", VisualStyleStates.STATES_COMMON_DEFAULT ),
        };

        public static readonly List<VisualStylePartEntry> PARTS_TRYHARDER = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "BUTTON", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(2, "VERTICAL", VisualStyleStates.STATES_COMMON_DEFAULT ),
        };

        public static readonly List<VisualStylePartEntry> PARTS_SPIN = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "UP", VisualStyleStates.STATES_SPIN_GENERAL ),
            new VisualStylePartEntry(2, "DOWN", VisualStyleStates.STATES_SPIN_GENERAL ),
            new VisualStylePartEntry(3, "UPHORZ", VisualStyleStates.STATES_SPIN_GENERAL ),
            new VisualStylePartEntry(4, "DOWNHORZ", VisualStyleStates.STATES_SPIN_GENERAL ),
        };

        public static readonly List<VisualStylePartEntry> PARTS_SEARCHBOX = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "BACKGROUND", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(2, "CLEARBUTTON", VisualStyleStates.STATES_PUSHBUTTON ), //W10
            new VisualStylePartEntry(3, "SEARCHBUTTON", VisualStyleStates.STATES_PUSHBUTTON ), //W10
        };

        public static readonly List<VisualStylePartEntry> PARTS_SEARCHHOME = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "BACKGROUND", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(2, "LINE", VisualStyleStates.STATES_COMMON_DEFAULT ),
        };

        public static readonly List<VisualStylePartEntry> PARTS_SCROLLBAR = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_SCROLLBAR_STYLE ),
            new VisualStylePartEntry(1, "ARROWBTN", VisualStyleStates.STATES_SCROLLBAR_ARROWBTN ),
            new VisualStylePartEntry(2, "THUMBBTNHORZ", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(3, "THUMBBTNVERT", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(4, "LOWERTRACKHORZ", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(5, "UPPERTRACKHORZ", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(6, "LOWERTRACKVERT", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(7, "UPPERTRACKVERT", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(8, "GRIPPERHORZ", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(9, "GRIPPERVERT", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(10, "SIZEBOX", VisualStyleStates.STATES_SCROLLBAR_SIZEBOX ),
        };

        public static readonly List<VisualStylePartEntry> PARTS_STATIC = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "TEXT", VisualStyleStates.STATES_COMMON_DEFAULT ),
        };

        public static readonly List<VisualStylePartEntry> PARTS_STATUS = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "PANE", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(2, "GRIPPERPANE", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(3, "GRIPPER", VisualStyleStates.STATES_COMMON_DEFAULT ),
        };

        public static readonly List<VisualStylePartEntry> PARTS_FLYOUT = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "HEADER", VisualStyleStates.STATES_FLYOUT_HEADER ),
            new VisualStylePartEntry(2, "BODY", VisualStyleStates.STATES_FLYOUT_BODY ),
            new VisualStylePartEntry(3, "LABEL", VisualStyleStates.STATES_FLYOUT_LABEL ),
            new VisualStylePartEntry(4, "LINK", VisualStyleStates.STATES_FLYOUT_LINK ),
            new VisualStylePartEntry(5, "DIVIDER", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(6, "WINDOW", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(7, "LINKAREA", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(8, "LINKHEADER", VisualStyleStates.STATES_FLYOUT_HEADER ),
        };

        public static readonly List<VisualStylePartEntry> PARTS_DRAGDROP = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "COPY", VisualStyleStates.STATES_DND_GENERAL ),
            new VisualStylePartEntry(2, "MOVE", VisualStyleStates.STATES_DND_GENERAL ),
            new VisualStylePartEntry(3, "UPDATEMETADATA", VisualStyleStates.STATES_DND_GENERAL ),
            new VisualStylePartEntry(4, "CREATELINK", VisualStyleStates.STATES_DND_GENERAL ),
            new VisualStylePartEntry(5, "WARNING", VisualStyleStates.STATES_DND_GENERAL ),
            new VisualStylePartEntry(6, "NONE", VisualStyleStates.STATES_DND_GENERAL ),
            new VisualStylePartEntry(7, "IMAGEBG", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(8, "TEXTBG", VisualStyleStates.STATES_COMMON_DEFAULT ),
        };

        public static readonly List<VisualStylePartEntry> PARTS_DATEPICKER = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "DATETEXT", VisualStyleStates.STATES_DATE_TEXT ),
            new VisualStylePartEntry(2, "DATEBORDER", VisualStyleStates.STATES_DATE_BORDER ),
            new VisualStylePartEntry(3, "SHOWCALENDARBUTTONRIGHT", VisualStyleStates.STATES_DATE_CALENDERBUTTONRIGHT ),
        };

        public static readonly List<VisualStylePartEntry> PARTS_TASKBAR = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "BACKGROUNDBOTTOM", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(2, "BACKGROUNDRIGHT", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(3, "BACKGROUNDTOP", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(4, "BACKGROUNDLEFT", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(5, "SIZINGBARBOTTOM", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(6, "SIZINGBARRIGHT", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(7, "SIZINGBARTOP", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(8, "SIZINGBARLEFT", VisualStyleStates.STATES_COMMON_DEFAULT ),
        };

        public static readonly List<VisualStylePartEntry> PARTS_STARTPANEL = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "USERPANE", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(2, "MOREPROGRAMS", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(3, "MOREPROGRAMSARROW", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(4, "PROGRAMLIST", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(5, "PROGRAMLISTSEPARATOR", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(6, "PLACELIST", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(7, "PLACELISTSEPARATOR", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(8, "LOGOFF", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(9, "LOGOFFBUTTONS", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(10, "USERPICTURE", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(11, "PREVIEW", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(12, "MOREPROGRAMSTAB", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(13, "NSCHOST", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(14, "SOFTWAREEXPLORER", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(15, "OPENBOX", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(16, "SEARCHVIEW", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(17, "MOREPROGRAMSARROWBACK", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(18, "TOPMATCH", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(19, "LOGOFFSPLITBUTTONDROPDOWN", VisualStyleStates.STATES_COMMON_DEFAULT ),
        };

        public static readonly List<VisualStylePartEntry> PARTS_STARTPANELPRIV = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "USERPANE", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(2, "MOREPROGRAMS", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(3, "MOREPROGRAMSDEST", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(4, "MOREPROGRAMSARROW", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(5, "FLYOUTARROW", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(6, "PROGRAMLIST", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(7, "PROGRAMLIST2", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(8, "PROGRAMLISTSEPARATOR", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(9, "PLACESLIST", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(10, "DESTLIST", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(11, "PLACESLISTSEPARATOR", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(12, "DESTINATIONMENUTOP", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(13, "DESTINATIONMENUBOTTOM", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(14, "LOGOFFBACKGROUND", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(15, "LOGOFFDESTBACKGROUND", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(16, "MOREPROGRAMSTAB", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(17, "NSCHOST", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(18, "OPENBOX", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(19, "OPENBOXDEST", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(20, "SEARCHVIEW", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(21, "MOREPROGRAMSARROWBACK", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(22, "TOPMATCH", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(23, "LOGOFFSPLITBUTTONDROPDOWN", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(24, "LOGOFFSPLITBUTTONDROPDOWNDEST", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(25, "PINICON", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(26, "SMALLPINOFFSET", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(27, "LARGEPINOFFSET", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(28, "LEFTMFUBUTTON", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(29, "FULLMFUBUTTON", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(30, "CENTERMFUBUTTON", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(31, "RIGHTMFUBUTTON", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(32, "FULLPLACESBUTTON", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(33, "LEFTPLACESBUTTON", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(34, "CENTERPLACESBUTTON", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(35, "RIGHTPLACESBUTTON", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(36, "SPECIALFOLDERSBUTTON", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(37, "LOGOFFSPLITBUTTON", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(38, "LOGOFFSPLITBUTTONDEST", VisualStyleStates.STATES_COMMON_DEFAULT ),
        };

        public static readonly List<VisualStylePartEntry> PARTS_MONTHCAL = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "BACKGROUND", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(2, "BORDERS", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(3, "GRIDBACKGROUND", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(4, "COLHEADERSPLITTER", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(5, "GRIDCELLBACKGROUND", VisualStyleStates.STATES_MONTHCAL_CELL ),
            new VisualStylePartEntry(6, "GRIDCELL", VisualStyleStates.STATES_MONTHCAL_CELL ),
            new VisualStylePartEntry(7, "GRIDCELLUPPER", VisualStyleStates.STATES_MONTHCAL_CELL ),
            new VisualStylePartEntry(8, "TRAILINGGRIDCELL", VisualStyleStates.STATES_MONTHCAL_CELL ),
            new VisualStylePartEntry(9, "TRAILINGGRIDCELLUPPER", VisualStyleStates.STATES_MONTHCAL_CELL ),
            new VisualStylePartEntry(10, "NAVNEXT", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(11, "NAVPREV", VisualStyleStates.STATES_COMMON_DEFAULT ),
        };

        public static readonly List<VisualStylePartEntry> PARTS_USERTILE = new List<VisualStylePartEntry>()
        {
            new VisualStylePartEntry(0, "Common Properties", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(1, "STROKEBACKGROUND", VisualStyleStates.STATES_COMMON_DEFAULT ),
            new VisualStylePartEntry(2, "HOVERBACKGROUND", VisualStyleStates.STATES_COMMON_DEFAULT ),
        };

        public static List<VisualStylePartEntry> Find(string className, Platform platform)
        {
            //
            // TODO: Use base class map (BCMAP) instead of relying on the naming
            //

            if (className.Contains("Toolbar"))   // Toolbar is often inherited, so find it first. It also has to be caught before "Button", 
            {                                   // because otherwise the SearchButton::Toolbar class would use the Button parts instead of the toolbar ones.
                return VisualStyleParts.PARTS_TOOLBAR;
            }
            else if (className.Contains("::Header")) // match inherited..
            {
                return VisualStyleParts.PARTS_HEADER;
            }
            else if (className.Contains("Button"))
            {
                return VisualStyleParts.PARTS_BUTTON;
            }
            else if (className.Contains("Edit"))
            {
                return VisualStyleParts.PARTS_EDIT;
            }
            else if (className.Contains("AddressBand"))
            {
                return VisualStyleParts.PARTS_ADDRESSBAND;
            }
            else if (className.Contains("BarrierPage"))
            {
                return VisualStyleParts.PARTS_BARRIERPAGE;
            }
            else if (className.Contains("BreadcrumbBar"))
            {
                return VisualStyleParts.PARTS_BREADCRUMBBAR;
            }
            else if (className.Contains("ReadingPane"))
            {
                return VisualStyleParts.PARTS_READINGPANE;
            }
            else if (className.Contains("Rebar"))
            {
                return VisualStyleParts.PARTS_REBAR;
            }
            else if (className.Contains("::Clock"))
            {
                return VisualStyleParts.PARTS_CLOCK;
            }
            else if (className.Contains("ChartView"))
            {
                return VisualStyleParts.PARTS_CHARTVIEW;
            }
            else if (className.Contains("CommandModule"))
            {
                switch (platform)
                {
                    case Platform.Vista:
                        {
                            return VisualStyleParts.PARTS_COMMANDMODULE_WINVista;
                        }
                    case Platform.Win7:
                        {
                            return VisualStyleParts.PARTS_COMMANDMODULE_WIN7;
                        }
                    case Platform.Win81:
                    case Platform.Win10:
                    case Platform.Win11:
                        {
                            return VisualStyleParts.PARTS_COMMANDMODULE_WIN8;
                        }
                    default:
                        {
                            return VisualStyleParts.PARTS_COMMANDMODULE_WIN8;
                        }
                }
            }
            else if (className.Contains("CommunicationsStyle"))
            {
                return VisualStyleParts.PARTS_COMMUNICATIONS;
            }
            else if (className.Contains("Combobox") || className.Contains("ComboBox"))
            {
                return VisualStyleParts.PARTS_COMBOBOX;
            }
            else if (className.Contains("ControlPanel"))
            {
                return VisualStyleParts.PARTS_CONTROLPANEL;
            }
            else if (className.Contains("CopyClose"))
            {
                return VisualStyleParts.PARTS_COPYCLOSE;
            }
            else if (className.Contains("DropListControl"))
            {
                return VisualStyleParts.PARTS_DROPLIST;
            }
            else if (className.Contains("EmptyMarkup"))
            {
                return VisualStyleParts.PARTS_EMPTYMARKUP;
            }
            else if (className.Contains("ExplorerBar"))
            {
                return VisualStyleParts.PARTS_EXPLORERBAR;
            }
            else if (className.Contains("Listbox"))
            {
                return VisualStyleParts.PARTS_LISTBOX;
            }
            else if (className.Contains("ListView"))
            {
                return VisualStyleParts.PARTS_LISTVIEW;
            }
            else if (className.Contains("InfoBar"))
            {
                return VisualStyleParts.PARTS_INFOBAR;
            }
            else if (className.Contains("ItemsView")) // after listview since it inherits..
            {
                return VisualStyleParts.PARTS_ITEMSVIEW;
            }
            else if (className.Contains("Link"))
            {
                return VisualStyleParts.PARTS_LINK;
            }
            else if (className.Contains("Menu"))
            {
                return VisualStyleParts.PARTS_MENU;
            }
            else if (className.Contains("Navigation"))
            {
                return VisualStyleParts.PARTS_NAVIGATION;
            }
            else if (className.Contains("TreeView"))
            {
                return VisualStyleParts.PARTS_TREEVIEW;
            }
            else if (className.Contains("DWMPen"))
            {
                return VisualStyleParts.PARTS_DWMPEN;
            }
            else if (className.Contains("DWMTouch"))
            {
                return VisualStyleParts.PARTS_DWMTOUCH;
            }
            else if (className.Contains("DWMWindow"))
            {
                switch (platform)
                {
                    case Platform.Win7:
                        {
                            return VisualStyleParts.PARTS_DWMWINDOW_WIN7;
                        }
                    case Platform.Win81:
                        {
                            return VisualStyleParts.PARTS_DWMWINDOW_WIN81;
                        }
                    case Platform.Win10:
                    case Platform.Win11:
                        {
                            return VisualStyleParts.PARTS_DWMWINDOW_WIN10;
                        }
                    default:
                        {
                            return VisualStyleParts.PARTS_DWMWINDOW_WIN10;
                        }
                }
            }
            else if (className.Contains("Window"))
            {
                return VisualStyleParts.PARTS_WINDOW;
            }
            else if (className.Contains("TaskDialog"))
            {
                return VisualStyleParts.PARTS_TASKDIALOG;
            }
            else if (className.Contains("Header"))
            {
                return VisualStyleParts.PARTS_HEADER;
            }
            else if (className.Contains("AeroWizard"))
            {
                return VisualStyleParts.PARTS_AEROWIZARD;
            }
            else if (className.Contains("Pause"))
            {
                return VisualStyleParts.PARTS_PAUSE;
            }
            else if (className.Contains("Progress"))
            {
                return VisualStyleParts.PARTS_PROGRESS;
            }
            else if (className.Contains("ProperTree"))
            {
                return VisualStyleParts.PARTS_PROPERTREE;
            }
            else if (className.Contains("PreviewPane"))
            {
                return VisualStyleParts.PARTS_PREVIEWPANE;
            }
            else if (className.Contains("TrackBar"))
            {
                return VisualStyleParts.PARTS_TRACKBAR;
            }
            else if (className.Contains("Tab"))
            {
                return VisualStyleParts.PARTS_TAB;
            }
            else if (className.Contains("ToolTip") || className.Contains("Tooltip")) // overcome inconsistencies in the naming
            {
                return VisualStyleParts.PARTS_TOOLTIP;
            }
            else if (className.Contains("TaskBar"))
            {
                return VisualStyleParts.PARTS_TASKBAR;
            }
            else if (className.Contains("TextGlow"))
            {
                return VisualStyleParts.PARTS_TEXTGLOW;
            }
            else if (className.Contains("TextStyle"))
            {
                return VisualStyleParts.PARTS_TEXTSTYLE;
            }
            else if (className.Contains("TextSelectionGripper"))
            {
                return VisualStyleParts.PARTS_TEXTSELECTIONGRIPPER;
            }
            else if (className.Contains("::TrayNotify"))
            {
                return VisualStyleParts.PARTS_TRAYNOTIFY;
            }
            else if (className.Contains("TryHarder"))
            {
                return VisualStyleParts.PARTS_TRYHARDER;
            }
            else if (className.Contains("SearchBox") || className.Contains("Searchbox")) // matches HelpSearchBox as well, thats ok
            {
                return VisualStyleParts.PARTS_SEARCHBOX;
            }
            else if (className.Contains("SearchHome"))
            {
                return VisualStyleParts.PARTS_SEARCHHOME;
            }
            else if (className.Contains("Spin"))
            {
                return VisualStyleParts.PARTS_SPIN;
            }
            else if (className.Contains("ScrollBar") || className.Contains("Scrollbar")) // overcome inconsistencies in the naming
            {
                return VisualStyleParts.PARTS_SCROLLBAR;
            }
            else if (className.Contains("Static"))
            {
                return VisualStyleParts.PARTS_STATIC;
            }
            else if (className.Contains("Status"))
            {
                return VisualStyleParts.PARTS_STATUS;
            }
            else if (className.Contains("TaskbarPearl"))
            {
                return VisualStyleParts.PARTS_TASKBARPEARL;
            }
            else if (className.Contains("TaskbarShowDesktop"))
            {
                return VisualStyleParts.PARTS_TASKBARSHOWDESKTOP;
            }
            else if (className.Contains("TaskbandExtendedUI"))
            {
                return VisualStyleParts.PARTS_TASKBANDEXUI;
            }
            else if (className.Contains("TaskBand2"))
            {
                return VisualStyleParts.PARTS_TASKBAND2;
            }
            else if (className.Contains("TaskBand"))
            {
                return VisualStyleParts.PARTS_TASKBAND;
            }
            else if (className.Contains("TaskManager"))
            {
                return VisualStyleParts.PARTS_TASKMANAGER;
            }
            else if (className.Contains("Flyout"))
            {
                return VisualStyleParts.PARTS_FLYOUT;
            }
            else if (className.Contains("DragDrop"))
            {
                return VisualStyleParts.PARTS_DRAGDROP;
            }
            else if (className.Contains("DatePicker"))
            {
                return VisualStyleParts.PARTS_DATEPICKER;
            }
            else if (className.Contains("StartPanelPriv"))
            {
                return VisualStyleParts.PARTS_STARTPANELPRIV;
            }
            else if (className.Contains("StartPanel"))
            {
                return VisualStyleParts.PARTS_STARTPANEL;
            }
            else if (className.Contains("MonthCal"))
            {
                return VisualStyleParts.PARTS_MONTHCAL;
            }
            else if (className.Contains("UserTile"))
            {
                return VisualStyleParts.PARTS_USERTILE;
            }
            else
            {
                return new List<VisualStylePartEntry>();
            }
        }
    }
}
