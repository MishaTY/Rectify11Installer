using libmsstyle;

namespace Rectify11Installer.Controls
{
    public class CustomProgressBar : ProgressBar
    {
        private bool _error = false;
        public bool Error { get { return _error; } set { _error = value;Invalidate(); } }
        public CustomProgressBar()
        {
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);

            if (Theme.DarkModeBool)
            {
                BackColor = Color.FromArgb(36, 36, 36);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rec = e.ClipRectangle;

            rec.Width = (int)(rec.Width * ((double)Value / Maximum));

            if (DesignMode)
            {
                if (ProgressBarRenderer.IsSupported)
                    ProgressBarRenderer.DrawHorizontalBar(e.Graphics, e.ClipRectangle);
            }
            else
            {
                VisualStyle currentTheme = Theme.DarkModeBool ? Theme.DarkStyle : Theme.LightStyle;

                var part = Theme.GetProgressbarBG(currentTheme);
                var renderer2 = new PartRenderer(currentTheme, part);
                var b = renderer2.RenderPreview(ThemeParts.Normal, Width, Height);

                e.Graphics.DrawImage(b, new Point(0,0));
            }

            if (rec.Width == 0)
                return;

            if (DesignMode)
            {
                e.Graphics.FillRectangle(Brushes.Green, 2, 2, rec.Width, rec.Height);
            }
            else
            {
                VisualStyle currentTheme = Theme.DarkModeBool ? Theme.DarkStyle : Theme.LightStyle;

                var part = Theme.GetProgressbarFill(currentTheme);

                using(PartRenderer renderer2 = new PartRenderer(currentTheme, part))
                {
                    ThemeParts tpart = Error ? ThemeParts.Pressed : ThemeParts.Normal;
                    var b = renderer2.RenderPreview(tpart, rec.Width, rec.Height);

                    e.Graphics.DrawImage(b, new Point(0, 0));
                    b.Dispose();
                }
            }
        }
    }
}
