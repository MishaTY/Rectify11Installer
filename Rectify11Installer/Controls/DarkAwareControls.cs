using System.ComponentModel;

namespace Rectify11Installer.Controls
{
    public class DarkAwareButton : Button
    {
        public DarkAwareButton()
        {
            Theme.OnThemeChanged += delegate (object? sender, EventArgs e)
            {
                UpdateTheming();
            };
        }
        protected override void CreateHandle()
        {
            base.CreateHandle();
            UpdateTheming();
        }
        private void UpdateTheming()
        {
            if (Theme.DarkModeBool)
            {
                FrmWizard.SetWindowTheme(this.Handle, "DarkMode_Explorer", null);
            }
            else
            {
                FrmWizard.SetWindowTheme(this.Handle, "Explorer", null);
            }
        }
    }
    public class DarkAwareFlowLayoutPanel : FlowLayoutPanel
    {
        private bool _ForceDark = false;
        [Description("Force Dark Mode UI")]
        [DefaultValue(false)]
        public bool ForceDark
        {
            get
            {
                return _ForceDark;
            }
            set
            {
                _ForceDark = value;
                UpdateTheming();
            }
        }
        public DarkAwareFlowLayoutPanel()
        {
            Theme.OnThemeChanged += delegate (object? sender, EventArgs e)
            {
                UpdateTheming();
            };
        }
        protected override void CreateHandle()
        {
            base.CreateHandle();
            UpdateTheming();
        }
        private void UpdateTheming()
        {
            if (Theme.DarkModeBool || ForceDark)
            {
                FrmWizard.SetWindowTheme(this.Handle, "DarkMode_Explorer", null);
            }
            else
            {
                FrmWizard.SetWindowTheme(this.Handle, "Explorer", null);
            }
        }
    }

    public class DarkAwareRichTextBox : RichTextBox
    {
        public DarkAwareRichTextBox()
        {
            Theme.OnThemeChanged += delegate (object? sender, EventArgs e)
            {
                UpdateTheming();
            };
        }
        protected override void CreateHandle()
        {
            base.CreateHandle();
            UpdateTheming();
        }
        private void UpdateTheming()
        {
            if (Theme.DarkModeBool)
            {
                FrmWizard.SetWindowTheme(this.Handle, "DarkMode_Explorer", null);
            }
            else
            {
                FrmWizard.SetWindowTheme(this.Handle, "Explorer", null);
            }
        }
    }

    public class DarkAwareComboBox : ComboBox
    {
        public DarkAwareComboBox()
        {
            Theme.OnThemeChanged += delegate (object? sender, EventArgs e)
            {
                UpdateTheming();
            };
        }
        protected override void CreateHandle()
        {
            base.CreateHandle();
            UpdateTheming();
        }
        private void UpdateTheming()
        {
            if (Theme.DarkModeBool)
            {
                FrmWizard.SetWindowTheme(this.Handle, "DarkMode_Explorer", null);
            }
            else
            {
                FrmWizard.SetWindowTheme(this.Handle, "Explorer", null);
            }
        }
    }

    public class DarkAwareRadioButton : RadioButton
    {
        public DarkAwareRadioButton()
        {
            Theme.OnThemeChanged += delegate (object? sender, EventArgs e)
            {
                UpdateTheming();
            };
        }
        protected override void CreateHandle()
        {
            base.CreateHandle();
            UpdateTheming();
        }
        private void UpdateTheming()
        {
            if (Theme.DarkModeBool)
            {
                FrmWizard.SetWindowTheme(this.Handle, "DarkMode_Explorer", null);
            }
            else
            {
                FrmWizard.SetWindowTheme(this.Handle, "Explorer", null);
            }
        }
    }

    public class DarkAwareCheckBox : CheckBox
    {
        public DarkAwareCheckBox()
        {
            Theme.OnThemeChanged += delegate (object? sender, EventArgs e)
            {
                UpdateTheming();
            };
        }
        protected override void CreateHandle()
        {
            base.CreateHandle();
            UpdateTheming();
        }
        private void UpdateTheming()
        {
            if (Theme.DarkModeBool)
            {
                FrmWizard.SetWindowTheme(this.Handle, "DarkMode_Explorer", null);
            }
            else
            {
                FrmWizard.SetWindowTheme(this.Handle, "Explorer", null);
            }
        }
    }
}
