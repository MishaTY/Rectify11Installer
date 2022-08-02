using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libmsstyle
{
    [TypeConverter(typeof(MarginsTypeConverter))]
    public class Margins
    {
        public Margins(int l, int t, int r, int b)
        {
            Left = l;
            Top = t;
            Right = r;
            Bottom = b;
        }

        [RefreshProperties(RefreshProperties.All)]
        public int Left { get;set; }
        [RefreshProperties(RefreshProperties.All)]
        public int Top { get; set; }
        [RefreshProperties(RefreshProperties.All)]
        public int Right { get; set; }
        [RefreshProperties(RefreshProperties.All)]
        public int Bottom { get; set; }

        public override string ToString()
        {
            return String.Format("{0}; {1}; {2}; {3}", Left, Top, Right, Bottom);
        }

        public override bool Equals(object obj)
        {
            var m = obj as Margins;
            if (m != null)
            {
                return this.Left == m.Left &&
                    this.Top == m.Top &&
                    this.Right == m.Right &&
                    this.Bottom == m.Bottom;
            }
            else return false;
        }

        public override int GetHashCode()
        {
            return (this.Left << 24) |
                (this.Top << 16) |
                (this.Right << 8) |
                (this.Bottom << 0);
        }
    }

    public class MarginsTypeConverter : ExpandableObjectConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return sourceType == typeof(string); ;
        }

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            return destinationType == typeof(string);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            string[] c = (value as string).Split(new char[] { ';' });
            if(c.Length != 4)
            {
                throw new FormatException("Missing component! Margins require 'left', 'top', 'right' and 'bottom'.");
            }

            return new Margins(Convert.ToInt32(c[0]),
                Convert.ToInt32(c[1]),
                Convert.ToInt32(c[2]),
                Convert.ToInt32(c[3]));
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            return base.ConvertTo(context, culture, value, destinationType);
        }
    }
}
