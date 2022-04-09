﻿using Rectify11Installer.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rectify11Installer.Pages
{
    public partial class ProgressPage : WizardPage
    {
        public Label CurrentProgressText
        {
            get
            {
                return lblCurrent;
            }
            set
            {
                lblCurrent = value;
            }
        }
        public CustomProgressBar ProgressBarDef
        {
            get
            {
                return ProgressBar;
            }
            set
            {
                ProgressBar = value;
            }
        }
        public ProgressPage()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            NextText();
        }

        private int CurrentTextIndex = 0;
        private void NextText()
        {
            CurrentTextIndex++;

            if (CurrentTextIndex >= Rectify11InstallerTexts.Length)
            {
                CurrentTextIndex = 0;
            }

            var t = Rectify11InstallerTexts[CurrentTextIndex];
            lblTitle.Text = t.Title;
            lblDescript.Text = t.Description;
        }

        private static InstallerTexts[] Rectify11InstallerTexts =
        {
            new("Did you know that...", "Rectify11 has better Win32 DPI support because we scale controls correctly."),
            new("Rectify11 has a better theme", "It took 3 months for the Rectify11 team to create a great consistent light and dark theme."),
            new("Rectify11 has better performance", "At the Rectify11 team, we value performance strongly."),
            new("Rectify11 has changed everything", "We changed many icons in many different DLL's, resulting in a more consistent operating system."),
            new("Control panel Rectified", "We changed many details in the control panel, such as removing old gradients and adding back removed items"),
            new("Thank you!", "Rectify11's team appreciates your support, thanks for choosing us.")
        };

        private class InstallerTexts
        {
            public string Title { get; set; }
            public string Description { get; set; }

            public InstallerTexts(string Title, string Description)
            {
                this.Title = Title;
                this.Description = Description;
            }
        }
    }
}
