using Microsoft.Win32;
using System.Diagnostics;
using System.Text;

namespace Rectify11Installer.Pages
{
    public partial class EulaPage : WizardPage
    {
        public EulaPage()
        {
            InitializeComponent();
            var eula = new StringBuilder();
            eula.Append(@"{\rtf1\ansi");
            eula.Append(@"\pard");
            eula.Append(@"{\pntext\f0 1.\tab}{\*\pn\pnlvlbody\pnf0\pnindent0\pnstart1\pndec{\pntxta.}}");
            eula.Append(@"\fi-360\li360\f0\fs20 This software is provided 'as-is', without any express or implied warranty. In NO event will the author be held liable for any damages arising from the use of this software.\par");
            eula.Append(@"{\pntext\f0 2.\tab}Rectify11 is free to use by anyone, but you cannot sell it. You cannot bundle this product as a part of another product without written permission from the author.\par");
            eula.Append(@"{\pntext\f0 3.\tab}You cannot claim that you made the software.\par");
            eula.Append(@"{\pntext\f0 4.\tab}This notice may not be removed or altered from any distribution.\par");
            eula.Append(@"\pard\par\par");
            eula.Append(@"Copyright \'a9 Microsoft Corporation and the Rectify11 Team\par");
            eula.Append(@"{\pntext\f0 Note:\space} We are NOT affilated with Microsoft Corporation in ANY way. This is a community made project.\par");
            eula.Append('}');
            richTextBoxEx1.Rtf = eula.ToString();
            SystemEvents.UserPreferenceChanged += SystemEvents_UserPreferenceChanged;
            if (Theme.IsUsingDarkMode)
            {
                richTextBoxEx1.BackColor = Color.Black;
                richTextBoxEx1.ForeColor = Color.White;
            }
            else
            {
                richTextBoxEx1.BackColor = Color.White;
                richTextBoxEx1.ForeColor = Color.Red;
            }
        }

        private void SystemEvents_UserPreferenceChanged(object sender, UserPreferenceChangedEventArgs e)
        {
            switch (e.Category)
            {
                case UserPreferenceCategory.General:
                    if (Theme.IsUsingDarkMode)
                    {
                        richTextBoxEx1.BackColor = Color.Black;
                        richTextBoxEx1.ForeColor = Color.White;
                    }
                    else
                    {
                        richTextBoxEx1.BackColor = Color.White;
                        richTextBoxEx1.ForeColor = Color.Black;
                    }
                    break;
            }
        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            if (e.LinkText != null)
                Process.Start(new ProcessStartInfo() { FileName=e.LinkText, UseShellExecute=true});
        }
    }
}
