using libmsstyle;
using System.ComponentModel;

namespace Rectify11Installer.Controls
{
    public partial class FakeCommandLink : UserControl
    {
        private static Color DefaultText
        {
            get
            {
                if (Theme.DarkModeBool)
                {
                    return Color.FromArgb(192, 192, 192);
                }
                else
                {
                    return Color.FromArgb(64, 64, 64);
                }
            }
        }
        private static Color HotText
        {
            get
            {
                if (Theme.DarkModeBool)
                {
                    return Color.FromArgb(255, 255, 255);
                }
                else
                {
                    return Color.FromArgb(0, 0, 0);
                }
            }
        }
        private static Color PressedText
        {
            get
            {
                if (Theme.DarkModeBool)
                {
                    return Color.FromArgb(160, 160, 160);
                }
                else
                {
                    return Color.FromArgb(96, 96, 96);
                }
            }
        }

        public string Note
        {
            get
            {
                return lblBody.Text;
            }
            set
            {
                lblBody.Text = value;
            }
        }
        [Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text
        {
            get
            {
                return lblTitle.Text;
            }
            set
            {
                lblTitle.Text = value;
            }
        }

        public new EventHandler? Click;
        public FakeCommandLink()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
            foreach (Control control in Controls)
            {
                control.MouseEnter += new EventHandler(TheMouseEnter);
                control.MouseLeave += new EventHandler(TheMouseLeave);
                control.MouseDown += new MouseEventHandler(TheMouseDown);
                control.MouseUp += new MouseEventHandler(TheMouseUp);
                control.Click += new EventHandler(TheMouseClick);
            }
            this.MouseEnter += new EventHandler(TheMouseEnter);
            this.MouseLeave += new EventHandler(TheMouseLeave);
            this.MouseDown += new MouseEventHandler(TheMouseDown);
            this.MouseUp += new MouseEventHandler(TheMouseUp);
            base.Click += new EventHandler(TheMouseClick);

            BackColor = Color.Transparent;

            pictureBox1.BackColor = Color.Transparent;
            lblTitle.BackColor = Color.Transparent;
            lblBody.BackColor = Color.Transparent;

            SetState(ThemeParts.Normal);
            pictureBox1.Image = GetGlyphImage(ThemeParts.Normal);

            lblTitle.ForeColor = DefaultText;
            lblBody.ForeColor = DefaultText;

            SetDoubleBuffered(lblTitle);
            SetDoubleBuffered(lblBody);
            SetDoubleBuffered(pictureBox1);
            Invalidate();
        }
        private void SetState(ThemeParts s)
        {
            //IsDesignMode and licesning did not work for me
            if (!Application.ExecutablePath.Contains("DesignToolsServer.exe") && !Application.ExecutablePath.Contains("devenv.exe"))
            {
                VisualStyle currentTheme = Theme.DarkModeBool ? Theme.DarkStyle : Theme.LightStyle;
                if (currentTheme != null)
                {
                    var part = Theme.GetCommandLinkPart(currentTheme);
                    var renderer2 = new PartRenderer(currentTheme, part);
                    BackgroundImage = renderer2.RenderPreview(s, Width, Height);
                }
            }
            else
            {
                //BackgroundImage = new Bitmap(Width, Height);
                //Graphics g = Graphics.FromImage(BackgroundImage);
                //Rectangle rect = new Rectangle(0, 0, Width, Height);
                //LinearGradientBrush lBrush = new LinearGradientBrush(rect, Color.Red, Color.Orange, LinearGradientMode.BackwardDiagonal);
                //g.FillRectangle(lBrush, rect);
            } 
        }
        public static void SetDoubleBuffered(System.Windows.Forms.Control c)
        {
            //Taxes: Remote Desktop Connection and painting
            //http://blogs.msdn.com/oldnewthing/archive/2006/01/03/508694.aspx
            if (SystemInformation.TerminalServerSession)
                return;
            var t = typeof(Control);
            System.Reflection.PropertyInfo? aProp = t.GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

            if (aProp != null)
                aProp.SetValue(c, true, null);
        }
        private Bitmap? GetGlyphImage(ThemeParts s)
        {
            if (!Application.ExecutablePath.Contains("DesignToolsServer.exe") && !Application.ExecutablePath.Contains("devenv.exe"))
            {
                VisualStyle currentTheme = Theme.DarkModeBool ? Theme.DarkStyle : Theme.LightStyle;
                if (currentTheme != null)
                {
                    var part = Theme.GetCommandLinkGlyphPart(currentTheme);
                    var renderer2 = new PartRenderer(currentTheme, part);
                    return renderer2.RenderPreview(s, pictureBox1.Width, pictureBox1.Height);
                }
            }
            else
            {
                //var b = new Bitmap(Width, Height);
                //Graphics g = Graphics.FromImage(b);
                //Rectangle rect = new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height);
                //LinearGradientBrush lBrush = new LinearGradientBrush(rect, Color.Blue, Color.DodgerBlue, LinearGradientMode.BackwardDiagonal);
                //g.FillRectangle(lBrush, rect);
                //return b;
            }

          
            return null;
        }

        private void TheMouseClick(object? sender, EventArgs e)
        {
            if (Click != null)
                Click.Invoke(sender, e);
        }

        private void TheMouseUp(object? sender, MouseEventArgs e)
        {
            if (Enabled)
            {
                SetState(ThemeParts.Normal);

                pictureBox1.Image = GetGlyphImage(ThemeParts.Normal);
                Color forecolor = Theme.DarkModeBool ? DefaultBackColor : Color.Black;

                lblTitle.ForeColor = forecolor;
                lblBody.ForeColor = forecolor;
            }
        }
        private void TheMouseDown(object? sender, MouseEventArgs e)
        {
            if (Enabled)
            {
                SetState(ThemeParts.Pressed);
                pictureBox1.Image = GetGlyphImage(ThemeParts.Pressed);


                lblTitle.ForeColor = PressedText;
                lblBody.ForeColor = PressedText;
            }
        }

        private void TheMouseLeave(object? sender, EventArgs e)
        {
            SetState(ThemeParts.Normal);
            pictureBox1.Image = GetGlyphImage(ThemeParts.Normal);

            lblTitle.ForeColor = DefaultText;
            lblBody.ForeColor = DefaultText;
        }

        private void TheMouseEnter(object? sender, EventArgs e)
        {
            SetState(ThemeParts.Hot);
            pictureBox1.Image = GetGlyphImage(ThemeParts.Hot);

            lblTitle.ForeColor = HotText;
            lblBody.ForeColor = HotText;
        }
    }
}