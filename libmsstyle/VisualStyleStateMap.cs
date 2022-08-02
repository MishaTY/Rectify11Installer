using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libmsstyle
{
    public class VisualStyleStateEntry
    {
        public VisualStyleStateEntry(int value, string name)
        {
            Value = value;
            Name = name;
        }

        public int Value;
        public string Name;
    }

    public class VisualStyleStates
    {
        public static readonly List<VisualStyleStateEntry> STATES_COMMON_DEFAULT = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_AEROWIZARD_HEADERAREA = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "NOMARGIN"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_PUSHBUTTON = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "NORMAL"),
            new VisualStyleStateEntry(2, "HOT"),
            new VisualStyleStateEntry(3, "PRESSED"),
            new VisualStyleStateEntry(4, "DISABLED"),
            new VisualStyleStateEntry(5, "DEFAULTED"),
            new VisualStyleStateEntry(6, "DEFAULTED_ANIMATING")
        };

        public static readonly List<VisualStyleStateEntry> STATES_RADIOBUTTON = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "UNCHECKEDNORMAL"),
            new VisualStyleStateEntry(2, "UNCHECKEDHOT"),
            new VisualStyleStateEntry(3, "UNCHECKEDPRESSED"),
            new VisualStyleStateEntry(4, "UNCHECKEDDISABLED"),
            new VisualStyleStateEntry(5, "CHECKEDNORMAL"),
            new VisualStyleStateEntry(6, "CHECKEDHOT"),
            new VisualStyleStateEntry(7, "CHECKEDPRESSED"),
            new VisualStyleStateEntry(8, "CHECKEDDISABLED"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_CHARTVIEW_LINE = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "ACTIVE"),
            new VisualStyleStateEntry(2, "IDLE"),
            new VisualStyleStateEntry(3, "ERROR"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_CHECKBOX = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "UNCHECKEDNORMAL"),
            new VisualStyleStateEntry(2, "UNCHECKEDHOT"),
            new VisualStyleStateEntry(3, "UNCHECKEDPRESSED"),
            new VisualStyleStateEntry(4, "UNCHECKEDDISABLED"),
            new VisualStyleStateEntry(5, "CHECKEDNORMAL"),
            new VisualStyleStateEntry(6, "CHECKEDHOT"),
            new VisualStyleStateEntry(7, "CHECKEDPRESSED"),
            new VisualStyleStateEntry(8, "CHECKEDDISABLED"),
            new VisualStyleStateEntry(9, "MIXEDNORMAL"),
            new VisualStyleStateEntry(10, "MIXEDHOT"),
            new VisualStyleStateEntry(11, "MIXEDPRESSED"),
            new VisualStyleStateEntry(12, "MIXEDDISABLED"),
            new VisualStyleStateEntry(13, "IMPLICITNORMAL"),
            new VisualStyleStateEntry(14, "IMPLICITHOT"),
            new VisualStyleStateEntry(15, "IMPLICITPRESSED"),
            new VisualStyleStateEntry(16, "IMPLICITDISABLED"),
            new VisualStyleStateEntry(17, "EXCLUDEDNORMAL"),
            new VisualStyleStateEntry(18, "EXCLUDEDHOT"),
            new VisualStyleStateEntry(19, "EXCLUDEDPRESSED"),
            new VisualStyleStateEntry(20, "EXCLUDEDDISABLED"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_GROUPBOX = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "NORMAL"),
            new VisualStyleStateEntry(2, "DISABLED"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_COMMANDLINK = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "NORMAL"),
            new VisualStyleStateEntry(2, "HOT"),
            new VisualStyleStateEntry(3, "PRESSED"),
            new VisualStyleStateEntry(4, "DISABLED"),
            new VisualStyleStateEntry(5, "DEFAULTED"),
            new VisualStyleStateEntry(6, "DEFAULTED_ANIMATING")
        };

        public static readonly List<VisualStyleStateEntry> STATES_COMMANDLINKGLYPHS = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "NORMAL"),
            new VisualStyleStateEntry(2, "HOT"),
            new VisualStyleStateEntry(3, "PRESSED"),
            new VisualStyleStateEntry(4, "DISABLED"),
            new VisualStyleStateEntry(5, "DEFAULTED"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_COMMANDMODULE_SPLITBUTTON = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "NORMAL"),
            new VisualStyleStateEntry(2, "HOT"),
            new VisualStyleStateEntry(3, "PRESSED"),
            new VisualStyleStateEntry(4, "KEYFOCUSED"),
            new VisualStyleStateEntry(5, "NEARHOT"),
            new VisualStyleStateEntry(6, "DISABLED")
        };

        public static readonly List<VisualStyleStateEntry> STATES_COMMANDMODULE_LIBRARYPANE_GEN = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "NORMAL"),
            new VisualStyleStateEntry(2, "HOT")
        };

        public static readonly List<VisualStyleStateEntry> STATES_CONTROLPANEL_CONTENTPANE = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "STANDALONE"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_COPYCLOSEBTN = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "NORMAL"),
            new VisualStyleStateEntry(2, "HOT"),
            new VisualStyleStateEntry(3, "PRESSED"),
            new VisualStyleStateEntry(4, "DISABLEDPRESSED"),
            new VisualStyleStateEntry(5, "DISABLED"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_CB_STYLE = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "NORMAL"),
            new VisualStyleStateEntry(2, "HOT"),
            new VisualStyleStateEntry(3, "PRESSED"),
            new VisualStyleStateEntry(4, "DISABLED"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_CB_DROPDOWNLR = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "NORMAL"),
            new VisualStyleStateEntry(2, "HOT"),
            new VisualStyleStateEntry(3, "PRESSED"),
            new VisualStyleStateEntry(4, "DISABLED"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_CB_TRANSPARENTBG = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "NORMAL"),
            new VisualStyleStateEntry(2, "HOT"),
            new VisualStyleStateEntry(3, "DISABLED"),
            new VisualStyleStateEntry(4, "FOCUSED"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_CB_BORDER = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "NORMAL"),
            new VisualStyleStateEntry(2, "HOT"),
            new VisualStyleStateEntry(3, "FOCUSED"),
            new VisualStyleStateEntry(4, "DISABLED"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_CB_READONLY = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "NORMAL"),
            new VisualStyleStateEntry(2, "HOT"),
            new VisualStyleStateEntry(3, "PRESSED"),
            new VisualStyleStateEntry(4, "DISABLED"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_CB_CUEBANNER = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "NORMAL"),
            new VisualStyleStateEntry(2, "HOT"),
            new VisualStyleStateEntry(3, "PRESSED"),
            new VisualStyleStateEntry(4, "DISABLED"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_TAB = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "NORMAL"),
            new VisualStyleStateEntry(2, "HOT"),
            new VisualStyleStateEntry(3, "SELECTED"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_LINK_HELP = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "NORMAL"),
            new VisualStyleStateEntry(2, "HOT"),
            new VisualStyleStateEntry(3, "PRESSED"),
            new VisualStyleStateEntry(4, "DISABLED"),

        };

        public static readonly List<VisualStyleStateEntry> STATES_LINK_TASK = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "NORMAL"),
            new VisualStyleStateEntry(2, "HOT"),
            new VisualStyleStateEntry(3, "PRESSED"),
            new VisualStyleStateEntry(4, "DISABLED"),
            new VisualStyleStateEntry(5, "PAGE"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_LINK_CONTENT = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "NORMAL"),
            new VisualStyleStateEntry(2, "HOT"),
            new VisualStyleStateEntry(3, "PRESSED"),
            new VisualStyleStateEntry(4, "DISABLED"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_LINK_SECTIONTITLE = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "NORMAL"),
            new VisualStyleStateEntry(2, "HOT"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_DATE_TEXT = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "NORMAL"),
            new VisualStyleStateEntry(2, "DISABLED"),
            new VisualStyleStateEntry(3, "SELECTED"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_DATE_BORDER = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "NORMAL"),
            new VisualStyleStateEntry(2, "HOT"),
            new VisualStyleStateEntry(3, "FOCUSED"),
            new VisualStyleStateEntry(4, "DISABLED"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_DATE_CALENDERBUTTONRIGHT = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "NORMAL"),
            new VisualStyleStateEntry(2, "HOT"),
            new VisualStyleStateEntry(3, "PRESSED"),
            new VisualStyleStateEntry(4, "DISABLED"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_DND_GENERAL = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "HIGHLIGHT"),
            new VisualStyleStateEntry(2, "NOHIGHLIGHT"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_EDITTEXT = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "NORMAL"),
            new VisualStyleStateEntry(2, "HOT"),
            new VisualStyleStateEntry(3, "SELECTED"),
            new VisualStyleStateEntry(4, "DISABLED"),
            new VisualStyleStateEntry(5, "FOCUSED"),
            new VisualStyleStateEntry(6, "READONLY"),
            new VisualStyleStateEntry(7, "ASSIST"),
            new VisualStyleStateEntry(8, "CUEBANNER"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_EDITTEXT_BG = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "NORMAL"),
            new VisualStyleStateEntry(2, "HOT"),
            new VisualStyleStateEntry(3, "DISABLED"),
            new VisualStyleStateEntry(4, "FOCUSED"),
            new VisualStyleStateEntry(5, "READONLY"),
            new VisualStyleStateEntry(6, "ASSIST"),

        };

        public static readonly List<VisualStyleStateEntry> STATES_EDITTEXT_BGWITHBORDER = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "NORMAL"),
            new VisualStyleStateEntry(2, "HOT"),
            new VisualStyleStateEntry(3, "DISABLED"),
            new VisualStyleStateEntry(4, "FOCUSED"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_EDITTEXT_GENERAL = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "NORMAL"),
            new VisualStyleStateEntry(2, "HOT"),
            new VisualStyleStateEntry(3, "FOCUSED"),
            new VisualStyleStateEntry(4, "DISABLED"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_EXPLORERBAR_HDRPIN = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "NORMAL"),
            new VisualStyleStateEntry(2, "HOT"),
            new VisualStyleStateEntry(3, "PRESSED"),
            new VisualStyleStateEntry(4, "SELECTEDNORMAL"),
            new VisualStyleStateEntry(5, "SELECTEDHOT"),
            new VisualStyleStateEntry(6, "SELECTEDPRESSED"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_EXPLORERBAR_GENERAL = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "NORMAL"),
            new VisualStyleStateEntry(2, "HOT"),
            new VisualStyleStateEntry(3, "PRESSED"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_FLYOUT_LABEL = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "NORMAL"),
            new VisualStyleStateEntry(2, "SELECTED"),
            new VisualStyleStateEntry(3, "EMPHASIZED"),
            new VisualStyleStateEntry(4, "DISABLED"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_FLYOUT_LINK = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "NORMAL"),
            new VisualStyleStateEntry(2, "HOVER"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_FLYOUT_BODY = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "NORMAL"),
            new VisualStyleStateEntry(2, "EMPHASIZED"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_FLYOUT_HEADER = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "NORMAL"),
            new VisualStyleStateEntry(2, "HOVER"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_HEADER_ITEMSTATES = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "NORMAL"),
            new VisualStyleStateEntry(2, "HOT"),
            new VisualStyleStateEntry(3, "PRESSED"),
            new VisualStyleStateEntry(4, "SORTEDNORMAL"),
            new VisualStyleStateEntry(5, "SORTEDHOT"),
            new VisualStyleStateEntry(6, "SORTEDPRESSED"),
            new VisualStyleStateEntry(7, "ICONNORMAL"),
            new VisualStyleStateEntry(8, "ICONHOT"),
            new VisualStyleStateEntry(9, "ICONPRESSED"),
            new VisualStyleStateEntry(10, "ICONSORTEDNORMAL"),
            new VisualStyleStateEntry(11, "ICONSORTEDHOT"),
            new VisualStyleStateEntry(12, "ICONSORTEDPRESSED"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_HEADER_LEFT_AND_RIGHT = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "NORMAL"),
            new VisualStyleStateEntry(2, "HOT"),
            new VisualStyleStateEntry(3, "PRESSED"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_HEADERSORTARROWSTATES = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "SORTEDUP"),
            new VisualStyleStateEntry(2, "SORTEDDOWN"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_HEADERDROPDOWNSTATES = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "NORMAL"),
            new VisualStyleStateEntry(2, "SOFTHOT"),
            new VisualStyleStateEntry(3, "HOT"),

        };

        public static readonly List<VisualStyleStateEntry> STATES_HEADERDROPDOWNFILTERSTATES = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "NORMAL"),
            new VisualStyleStateEntry(2, "SOFTHOT"),
            new VisualStyleStateEntry(3, "HOT"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_HEADEROVERFLOWSTATES = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "NORMAL"),
            new VisualStyleStateEntry(2, "HOT"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_ITEMSVIEW_SEARCHHIT = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "START"),
            new VisualStyleStateEntry(2, "FINAL"),
            new VisualStyleStateEntry(3, "STARTSELECTED"),
            new VisualStyleStateEntry(4, "FINALSELECTED"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_ITEMSVIEW_FOCUSRECT = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "NORMAL"),
            new VisualStyleStateEntry(2, "HOVER"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_ITEMSVIEW_PROPERTY = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "SUBPROPERTY"),
            new VisualStyleStateEntry(2, "FILENAMEPROPERTY"),
            new VisualStyleStateEntry(3, "FILENAMESELECTEDPROPERTY"),
            new VisualStyleStateEntry(4, "SUBPROPERTYSELECTED"),
            new VisualStyleStateEntry(5, "FILENAMECOMPRESSEDPROPERTY"),
            new VisualStyleStateEntry(6, "FILENAMESELECTEDCOMPRESSEDPROPERTY"),
            new VisualStyleStateEntry(7, "FILENAMEENCRYPTEDPROPERTY"),
            new VisualStyleStateEntry(8, "FILENAMESELECTEDENCRYPTEDPROPERTY"),
            new VisualStyleStateEntry(9, "FILENAMEDISCONNECTEDPROPERTY"),
            new VisualStyleStateEntry(10, "FILENAMESELECTEDDISCONNECTEDPROPERTY"),
            new VisualStyleStateEntry(11, "CONFLICTTILETEXT"),
            new VisualStyleStateEntry(12, "CONFLICTTILETEXTFOCUSED"),
            new VisualStyleStateEntry(13, "PROGRESSBAR"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_LISTBOX_SCROLL = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "NORMAL"),
            new VisualStyleStateEntry(2, "FOCUSED"),
            new VisualStyleStateEntry(3, "HOT"),
            new VisualStyleStateEntry(4, "DISABLED"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_LISTBOX_ITEMS = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "HOT"),
            new VisualStyleStateEntry(2, "HOTSELECTED"),
            new VisualStyleStateEntry(3, "SELECTED"),
            new VisualStyleStateEntry(4, "SELECTEDNOTFOCUS"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_LISTVIEW_ITEMS = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "NORMAL"),
            new VisualStyleStateEntry(2, "HOT"),
            new VisualStyleStateEntry(3, "SELECTED"),
            new VisualStyleStateEntry(4, "DISABLED"),
            new VisualStyleStateEntry(5, "SELECTEDNOTFOCUS"),
            new VisualStyleStateEntry(6, "HOTSELECTED"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_LISTVIEW_GROUPHEADER_GENERAL = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "OPEN"),
            new VisualStyleStateEntry(2, "OPENHOT"),
            new VisualStyleStateEntry(3, "OPENSELECTED"),
            new VisualStyleStateEntry(4, "OPENSELECTEDHOT"),
            new VisualStyleStateEntry(5, "OPENSELECTEDNOTFOCUSED"),
            new VisualStyleStateEntry(6, "OPENSELECTEDNOTFOCUSEDHOT"),
            new VisualStyleStateEntry(7, "OPENMIXEDSELECTION"),
            new VisualStyleStateEntry(8, "OPENMIXEDSELECTIONHOT"),
            new VisualStyleStateEntry(9, "CLOSE"),
            new VisualStyleStateEntry(10, "CLOSEHOT"),
            new VisualStyleStateEntry(11, "CLOSESELECTED"),
            new VisualStyleStateEntry(12, "CLOSESELECTEDHOT"),
            new VisualStyleStateEntry(13, "CLOSESELECTEDNOTFOCUSED"),
            new VisualStyleStateEntry(14, "CLOSESELECTEDNOTFOCUSEDHOT"),
            new VisualStyleStateEntry(15, "CLOSEMIXEDSELECTION"),
            new VisualStyleStateEntry(16, "CLOSEMIXEDSELECTIONHOT"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_LISTVIEW_EXPCOLLAPSE = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "NORMAL"),
            new VisualStyleStateEntry(2, "HOVER"),
            new VisualStyleStateEntry(3, "PUSHED"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_MENU_BARBG = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "ACTIVE"),
            new VisualStyleStateEntry(2, "INACTIVE"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_MENU_BARITEM = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "NORMAL"),
            new VisualStyleStateEntry(2, "HOT"),
            new VisualStyleStateEntry(3, "PUSHED"),
            new VisualStyleStateEntry(4, "DISABLED"),
            new VisualStyleStateEntry(5, "DISABLEDHOT"),
            new VisualStyleStateEntry(6, "DISABLEDPUSHED"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_MENU_POPCHECK = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "CHECKMARKNORMAL"),
            new VisualStyleStateEntry(2, "CHECKMARKDISABLED"),
            new VisualStyleStateEntry(3, "BULLETNORMAL"),
            new VisualStyleStateEntry(4, "BULLETDISABLED"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_MENU_POPCHECKBG = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "DISABLED"),
            new VisualStyleStateEntry(2, "NORMAL"),
            new VisualStyleStateEntry(3, "BITMAP"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_MENU_POPITEMS = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "NORMAL"),
            new VisualStyleStateEntry(2, "HOT"),
            new VisualStyleStateEntry(3, "DISABLED"),
            new VisualStyleStateEntry(4, "DISABLEDHOT"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_MENU_SYSTEM_GENERAL = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "NORMAL"),
            new VisualStyleStateEntry(2, "DISABLED"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_MONTHCAL_CELL = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "HOT"),
            new VisualStyleStateEntry(2, "HASSTATE"),
            new VisualStyleStateEntry(3, "HASSTATEHOT"),
            new VisualStyleStateEntry(4, "TODAY"),
            new VisualStyleStateEntry(5, "TODAYSELECTED"),
            new VisualStyleStateEntry(6, "SELECTED"),
            new VisualStyleStateEntry(7, "SELECTEDHOT"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_GENERAL = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "BB_NORMAL"),
            new VisualStyleStateEntry(2, "BB_HOT"),
            new VisualStyleStateEntry(3, "BB_PRESSED"),
            new VisualStyleStateEntry(4, "BB_DISABLED"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_PROGRESS_TRANSPARENT_GENERAL = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "NORMAL"),
            new VisualStyleStateEntry(2, "PARTIAL"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_PROGRESS_FILL_GENERAL = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "NORMAL"),
            new VisualStyleStateEntry(2, "ERROR"),
            new VisualStyleStateEntry(3, "PAUSED"),
            new VisualStyleStateEntry(4, "PARTIAL"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_REBAR_GENERAL = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "NORMAL"),
            new VisualStyleStateEntry(2, "HOT"),
            new VisualStyleStateEntry(3, "PRESSED"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_SCROLLBAR_ARROWBTN = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "UPNORMAL"),
            new VisualStyleStateEntry(2, "UPHOT"),
            new VisualStyleStateEntry(3, "UPPRESSED"),
            new VisualStyleStateEntry(4, "UPDISABLED"),
            new VisualStyleStateEntry(5, "DOWNNORMAL"),
            new VisualStyleStateEntry(6, "DOWNHOT"),
            new VisualStyleStateEntry(7, "DOWNPRESSED"),
            new VisualStyleStateEntry(8, "DOWNDISABLED"),
            new VisualStyleStateEntry(9, "LEFTNORMAL"),
            new VisualStyleStateEntry(10, "LEFTHOT"),
            new VisualStyleStateEntry(11, "LEFTPRESSED"),
            new VisualStyleStateEntry(12, "LEFTDISABLED"),
            new VisualStyleStateEntry(13, "RIGHTNORMAL"),
            new VisualStyleStateEntry(14, "RIGHTHOT"),
            new VisualStyleStateEntry(15, "RIGHTPRESSED"),
            new VisualStyleStateEntry(16, "RIGHTDISABLED"),
            new VisualStyleStateEntry(17, "UPHOVER"),
            new VisualStyleStateEntry(18, "DOWNHOVER"),
            new VisualStyleStateEntry(19, "LEFTHOVER"),
            new VisualStyleStateEntry(20, "RIGHTHOVER"),

        };

        public static readonly List<VisualStyleStateEntry> STATES_SCROLLBAR_STYLE = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "NORMAL"),
            new VisualStyleStateEntry(2, "HOT"),
            new VisualStyleStateEntry(3, "PRESSED"),
            new VisualStyleStateEntry(4, "DISABLED"),
            new VisualStyleStateEntry(5, "HOVER"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_SCROLLBAR_SIZEBOX = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "RIGHTALIGN"),
            new VisualStyleStateEntry(2, "LEFTALIGN"),
            new VisualStyleStateEntry(3, "TOPRIGHTALIGN"),
            new VisualStyleStateEntry(4, "TOPLEFTALIGN"),
            new VisualStyleStateEntry(5, "HALFBOTTOMRIGHTALIGN"),
            new VisualStyleStateEntry(6, "HALFBOTTOMLEFTALIGN"),
            new VisualStyleStateEntry(7, "HALFTOPRIGHTALIGN"),
            new VisualStyleStateEntry(8, "HALFTOPLEFTALIGN"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_SPIN_GENERAL = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "Normal"),
            new VisualStyleStateEntry(2, "Hot"),
            new VisualStyleStateEntry(3, "Pressed"),
            new VisualStyleStateEntry(4, "Disabled"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_TABITEM_GENERAL = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "NORMAL"),
            new VisualStyleStateEntry(2, "HOT"),
            new VisualStyleStateEntry(3, "SELECTED"),
            new VisualStyleStateEntry(4, "DISABLED"),
            new VisualStyleStateEntry(5, "FOCUSED"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_TASKDLG_EXPANDOBUTTON = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "NORMAL"),
            new VisualStyleStateEntry(2, "HOVER"),
            new VisualStyleStateEntry(3, "PRESSED"),
            new VisualStyleStateEntry(4, "EXPANDEDNORMAL"),
            new VisualStyleStateEntry(5, "EXPANDEDHOVER"),
            new VisualStyleStateEntry(6, "EXPANDEDPRESSED"),
            new VisualStyleStateEntry(7, "NORMALDISABLED"),
            new VisualStyleStateEntry(8, "EXPANDEDDISABLED"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_TEXTSTYLE_HLINK = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "HYPERLINK_NORMAL"),
            new VisualStyleStateEntry(2, "HYPERLINK_HOT"),
            new VisualStyleStateEntry(3, "HYPERLINK_PRESSED"),
            new VisualStyleStateEntry(4, "HYPERLINK_DISABLED"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_TEXTSTYLE_CTRLLABEL = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "CONTROLLABEL_NORMAL"),
            new VisualStyleStateEntry(2, "CONTROLLABEL_DISABLED"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_TOOLBARSTYLE = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "NORMAL"),
            new VisualStyleStateEntry(2, "HOT"),
            new VisualStyleStateEntry(3, "PRESSED"),
            new VisualStyleStateEntry(4, "DISABLED"),
            new VisualStyleStateEntry(5, "CHECKED"),
            new VisualStyleStateEntry(6, "HOTCHECKED"),
            new VisualStyleStateEntry(7, "NEARHOT"),
            new VisualStyleStateEntry(8, "OTHERSIDEHOT"),

        };

        public static readonly List<VisualStyleStateEntry> STATES_TOOLTIP_CLOSE = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "NORMAL"),
            new VisualStyleStateEntry(2, "HOT"),
            new VisualStyleStateEntry(3, "PRESSED"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_TOOLTIP_BALLOON_AND_STANDARD = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "NORMAL"),
            new VisualStyleStateEntry(2, "LINK"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_TOOLTIP_BALLOONSTEM = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "POINTINGUPLEFTWALL"),
            new VisualStyleStateEntry(2, "POINTINGUPCENTERED"),
            new VisualStyleStateEntry(3, "POINTINGUPRIGHTWALL"),
            new VisualStyleStateEntry(4, "POINTINGDOWNRIGHTWALL"),
            new VisualStyleStateEntry(5, "POINTINGDOWNCENTERED"),
            new VisualStyleStateEntry(6, "POINTINGDOWNLEFTWALL"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_TOOLTIP_WRENCH = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "NORMAL"),
            new VisualStyleStateEntry(2, "HOT"),
            new VisualStyleStateEntry(3, "PRESSED"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_TRACKBAR_GENERAL = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "NORMAL"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_TRACKBAR_THUMB_GEN = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "NORMAL"),
            new VisualStyleStateEntry(2, "HOT"),
            new VisualStyleStateEntry(3, "PRESSED"),
            new VisualStyleStateEntry(4, "FOCUSED"),
            new VisualStyleStateEntry(5, "DISABLED"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_TREEVIEW_ITEM = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "NORMAL"),
            new VisualStyleStateEntry(2, "HOT"),
            new VisualStyleStateEntry(3, "SELECTED"),
            new VisualStyleStateEntry(4, "DISABLED"),
            new VisualStyleStateEntry(5, "SELECTEDNOTFOCUS"),
            new VisualStyleStateEntry(6, "HOTSELECTED"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_TREEVIEW_GLYPH = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "CLOSED"),
            new VisualStyleStateEntry(2, "OPENED"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_USERTILE_HOVERBACKGROUND = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "NORMAL"),
            new VisualStyleStateEntry(2, "HOT"),
            new VisualStyleStateEntry(3, "PRESSED"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_GRIPPER = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "NORMAL"),
            new VisualStyleStateEntry(2, "CENTERED"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_WINDOW_FRAME_GEN = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "ACTIVE"),
            new VisualStyleStateEntry(2, "INACTIVE"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_WINDOW_CAPTION_GEN = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "ACTIVE"),
            new VisualStyleStateEntry(2, "INACTIVE"),
            new VisualStyleStateEntry(3, "DISABLED"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_WINDOW_BTN_AND_THUMB = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "NORMAL"),
            new VisualStyleStateEntry(2, "HOT"),
            new VisualStyleStateEntry(3, "PUSHED"),
            new VisualStyleStateEntry(4, "DISABLED"),
        };

        public static readonly List<VisualStyleStateEntry> STATES_WINDOW_CAPTION_SMALL = new List<VisualStyleStateEntry>()
        {
            new VisualStyleStateEntry(0, "Common"),
            new VisualStyleStateEntry(1, "ACTIVE"),
            new VisualStyleStateEntry(2, "INACTIVE"),
            new VisualStyleStateEntry(3, "DISABLED"),
        };
    }
}
