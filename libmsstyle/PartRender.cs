using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libmsstyle
{
    public class PartRenderer : IDisposable
    {
        private VisualStyle m_style;
        private StylePart m_part;

        public PartRenderer(VisualStyle style, StylePart part)
        {
            m_style = style;
            m_part = part;
        }

        public void Dispose()
        {
            m_part.Dispose();
        }

        public Bitmap RenderPreview(ThemeParts t, int width, int height)
        {
            var idx = (int)t;
            if (!m_part.States.TryGetValue(idx, out _))
            {
                return null;
            }

            Bitmap surface = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            using (Graphics g = Graphics.FromImage(surface))
            {
                DrawBackground(g, idx);
            }
            GC.Collect();
            return surface;
        }

        private void DrawBackground(Graphics g, int part)
        {
            int bgType = 2;
            m_part.States[0].TryGetPropertyValue(IDENTIFIER.BGTYPE, ref bgType);

            switch (bgType)
            {
                case 0: // IMAGEFILL
                    DrawBackgroundImageFill(g, part); break;
                case 1: // BORDERFILL
                    DrawBackgroundSolidFill(g, part); break;
                default: break;
            }
        }

        private void DrawBackgroundImageFill(Graphics g, int idx)
        {
            bool incor = false;
            var imageFileProp = m_part.States[idx].Properties.Find((p) => p.Header.nameID == (int)IDENTIFIER.IMAGEFILE);
            if (imageFileProp == default(StyleProperty))
            {
                imageFileProp = m_part.States[idx].Properties.Find((p) => p.Header.nameID == (int)IDENTIFIER.IMAGEFILE1);
                if (imageFileProp == default(StyleProperty))
                {
                    incor = true;
                }
            }

            if (incor)
            {
                imageFileProp = m_part.States[0].Properties.Find((p) => p.Header.nameID == (int)IDENTIFIER.IMAGEFILE);
                if (imageFileProp == default(StyleProperty))
                {
                    imageFileProp = m_part.States[0].Properties.Find((p) => p.Header.nameID == (int)IDENTIFIER.IMAGEFILE1);
                    if (imageFileProp == default(StyleProperty))
                    {
                        return;
                    }
                }
            }
          

            Image fullImage = null;

            string file = m_style.GetQueuedResourceUpdate(imageFileProp.Header.shortFlag, StyleResourceType.Image);
            if (!String.IsNullOrEmpty(file))
            {
                fullImage = Image.FromFile(file);
            }
            else
            {
                var resource = m_style.GetResourceFromProperty(imageFileProp);
                if (resource?.Data != null)
                {
                    fullImage = Image.FromStream(new MemoryStream(resource.Data));
                }
                else
                {
                    return;
                }
            }

            Rectangle imagePartToDraw = new Rectangle(0, 0, fullImage.Width, fullImage.Height);

            int imageLayout = 0; // VERTICAL
            bool haveImageLayout = m_part.States[0].TryGetPropertyValue(IDENTIFIER.IMAGELAYOUT, ref imageLayout);

            int imageCount = 1;
            bool haveImageCount = m_part.States[0].TryGetPropertyValue(IDENTIFIER.IMAGECOUNT, ref imageCount);

            // If the image contains mutliple images, we select the nth one.
            if (imageCount > 1)
            {
                int partW = imageLayout == 1
                    ? fullImage.Width / imageCount
                    : fullImage.Width;
                int partH = imageLayout == 0
                    ? fullImage.Height / imageCount
                    : fullImage.Height;
                int n = idx;

                imagePartToDraw = new Rectangle(
                    0 + (partW * 0),
                    0 + (partH * n),
                    partW, partH
                );
            }

            int sizingType = 0; // TRUESIZE
            bool haveSizingTypes = m_part.States[0].TryGetPropertyValue(IDENTIFIER.SIZINGTYPE, ref sizingType);

            Margins sizingMargins = default(Margins);
            bool haveSizingMargins = m_part.States[0].TryGetPropertyValue(IDENTIFIER.SIZINGMARGINS, ref sizingMargins);
            bool sizingMarginsZero = new Margins(0, 0, 0, 0).Equals(sizingMargins);

            switch (sizingType)
            {
                case 0: // TRUESIZE
                    {
                        // center image for better looks
                        Rectangle dst = new Rectangle(
                            (int)(g.VisibleClipBounds.Width / 2) - (imagePartToDraw.Width / 2),
                            (int)(g.VisibleClipBounds.Height / 2) - (imagePartToDraw.Height / 2),
                            imagePartToDraw.Width, imagePartToDraw.Height);

                        g.DrawImage(fullImage, dst, imagePartToDraw, GraphicsUnit.Pixel);
                    }
                    break;
                case 1: // STRETCH
                case 2: // TILE
                    {
                        if (haveSizingMargins && !sizingMarginsZero)
                        {
                            // Perform 9-slice-scaling. 
                            // Margin tells us the distance from each side that we have to preserve.
                            // For drawing, we convert this side-relative input into absolute coords
                            // for this specific image.

                            Rectangle absMargins = new Rectangle(
                                sizingMargins.Left,
                                sizingMargins.Top,
                                Math.Max(imagePartToDraw.Width - sizingMargins.Left - sizingMargins.Right, 1), // some margins are invalid.
                                Math.Max(imagePartToDraw.Height - sizingMargins.Top - sizingMargins.Bottom, 1) // some margins are invalid.
                            );

                            DrawImage9SliceScaled(g, fullImage, imagePartToDraw, Rectangle.Round(g.VisibleClipBounds), absMargins);
                        }
                        else
                        {
                            // Perform normal, non-uniform scaling
                            using (ImageAttributes attr = new ImageAttributes())
                            {
                                // avoid interpolation with the default black of outside region
                                attr.SetWrapMode(System.Drawing.Drawing2D.WrapMode.TileFlipXY);
                                g.DrawImage(fullImage, Rectangle.Round(g.VisibleClipBounds),
                                    imagePartToDraw.X,
                                    imagePartToDraw.Y,
                                    imagePartToDraw.Width,
                                    imagePartToDraw.Height,
                                    GraphicsUnit.Pixel, attr);
                            }
                        }
                    }
                    break;
                default: // UNSUPPORTED
                    break;
            }
        }

        private void DrawBackgroundSolidFill(Graphics g, int idx)
        {
            Color bgFill = Color.White;
            if (m_part.States[idx].TryGetPropertyValue(IDENTIFIER.FILLCOLOR, ref bgFill))
            {
                g.FillRectangle(new SolidBrush(bgFill), g.ClipBounds);
            }
        }

        private void DrawImage9SliceScaled(Graphics g, Image image, Rectangle src, Rectangle dst, Rectangle sm)
        {
            /* SRC */
            /* Assumes that sm is adjusted to this image */
            Rectangle topLeft = new Rectangle(src.X, src.Y, sm.Left, sm.Top);
            Rectangle topMiddle = new Rectangle(src.X + sm.Left, src.Y, sm.Width, sm.Top);
            Rectangle topRight = new Rectangle(src.X + sm.Right, src.Y, src.Width - sm.Right, sm.Top);

            Rectangle midLeft = new Rectangle(src.X, src.Y + sm.Top, sm.Left, sm.Height);
            Rectangle midMiddle = new Rectangle(src.X + sm.Left, src.Y + sm.Top, sm.Width, sm.Height);
            Rectangle midRight = new Rectangle(src.X + sm.Right, src.Y + sm.Top, src.Width - sm.Right, sm.Height);

            Rectangle botLeft = new Rectangle(src.X, src.Y + sm.Bottom, sm.Left, src.Height - sm.Bottom);
            Rectangle botMiddle = new Rectangle(src.X + sm.Left, src.Y + sm.Bottom, sm.Width, src.Height - sm.Bottom);
            Rectangle botRight = new Rectangle(src.X + sm.Right, src.Y + sm.Bottom, src.Width - sm.Right, src.Height - sm.Bottom);

            /* DST */
            int varWidth = dst.Width - sm.Left - (src.Width - sm.Right);
            int varHeight = dst.Height - sm.Top - (src.Height - sm.Bottom);

            Rectangle topLeftDst = new Rectangle(dst.X, dst.Y, topLeft.Width, topLeft.Height);      // keep W & H
            Rectangle topMiddleDst = new Rectangle(dst.X + sm.Left, dst.Y, varWidth, topMiddle.Height);    // keep H
            Rectangle topRightDst = new Rectangle(dst.X + sm.Left + varWidth, dst.Y, topRight.Width, topRight.Height);     // keep W & H

            Rectangle midLeftDst = new Rectangle(dst.X, dst.Y + sm.Top, midLeft.Width, varHeight); // keep W
            Rectangle midMiddleDst = new Rectangle(dst.X + sm.Left, dst.Y + sm.Top, varWidth, varHeight); // fully scale
            Rectangle midRightDst = new Rectangle(dst.X + sm.Left + varWidth, dst.Y + sm.Top, midRight.Width, varHeight); // keep W

            Rectangle botLeftDst = new Rectangle(dst.X, dst.Y + sm.Top + varHeight, botLeft.Width, botLeft.Height);      // keep W & H
            Rectangle botMiddleDst = new Rectangle(dst.X + sm.Left, dst.Y + sm.Top + varHeight, varWidth, botMiddle.Height);    // keep H
            Rectangle botRightDst = new Rectangle(dst.X + sm.Left + varWidth, dst.Y + sm.Top + varHeight, botRight.Width, botRight.Height);     // keep W & H

            g.DrawImage(image, topLeftDst, topLeft, GraphicsUnit.Pixel);
            g.DrawImage(image, topMiddleDst, topMiddle, GraphicsUnit.Pixel);
            g.DrawImage(image, topRightDst, topRight, GraphicsUnit.Pixel);

            g.DrawImage(image, midLeftDst, midLeft, GraphicsUnit.Pixel);
            g.DrawImage(image, midMiddleDst, midMiddle, GraphicsUnit.Pixel);
            g.DrawImage(image, midRightDst, midRight, GraphicsUnit.Pixel);

            g.DrawImage(image, botLeftDst, botLeft, GraphicsUnit.Pixel);
            g.DrawImage(image, botMiddleDst, botMiddle, GraphicsUnit.Pixel);
            g.DrawImage(image, botRightDst, botRight, GraphicsUnit.Pixel);
        }
    }
    public enum ThemeParts
    {
        Normal = 0,
        Hot = 1,
        Pressed = 2,
        Disabled = 3,
        Defaulted = 4,
        DefaultedAnimating = 5
    }
}
