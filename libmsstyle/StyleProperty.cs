using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libmsstyle
{
    public class PropertyHeader : ICloneable
	{
		public Int32 nameID;     // Offset: 0, Size: 4,	ID for the property name, described in MSDN
		public Int32 typeID;     // Offset: 4, Size: 4,	ID for the type of the property, described in MSDN
		public Int32 classID;    // Offset: 8, Size: 4,	Index to the class from CMAP the propery belongs to
		public Int32 partID;     // Offset: 12, Size: 4	ID for the part of the class the property belongs to, see vsstyle.h
		public Int32 stateID;    // Offset: 16, Size: 4	ID for the state map, see vsstyle.h
		public Int32 shortFlag;  // Offset: 20, Size: 4	If not 0, ignore 'sizeInBytes' as no data follows. Instead this field may contain data.
		public Int32 reserved;   // Offset: 24, Size: 4	Seems to be always zero
		public Int32 sizeInBytes;// Offset: 28, Size: 4	The size of the data that follows. Does not include padding

		public PropertyHeader(Int32 name, Int32 type)
		{
			nameID = name;
			typeID = type;

			switch ((IDENTIFIER)type)
			{
				case IDENTIFIER.DIBDATA:
					break;
				case IDENTIFIER.GLYPHDIBDATA:
					break;
				case IDENTIFIER.ENUM:
					sizeInBytes = 0x4;
					break;
				case IDENTIFIER.STRING:
					// dynamic !!
					break;
				case IDENTIFIER.INT:
					sizeInBytes = 0x4;
					break;
				case IDENTIFIER.BOOLTYPE:
					sizeInBytes = 0x4;
					break;
				case IDENTIFIER.COLOR:
					sizeInBytes = 0x4;
					break;
				case IDENTIFIER.MARGINS:
					sizeInBytes = 0x10;
					break;
				case IDENTIFIER.FILENAME:
					sizeInBytes = 0x10;
					break;
				case IDENTIFIER.SIZE:
					sizeInBytes = 0x4;
					break;
				case IDENTIFIER.POSITION:
					sizeInBytes = 0x8;
					break;
				case IDENTIFIER.RECTTYPE:
					sizeInBytes = 0x10;
					break;
				case IDENTIFIER.FONT:
					sizeInBytes = 0x5C;
					break;
				case IDENTIFIER.INTLIST:
					// dynamic !!
					break;
				case IDENTIFIER.HBITMAP:
					break;
				case IDENTIFIER.DISKSTREAM:
					break;
				case IDENTIFIER.STREAM:
					break;
				case IDENTIFIER.BITMAPREF:
					break;
				case IDENTIFIER.FLOAT:
					break;
				case IDENTIFIER.HIGHCONTRASTCOLORTYPE:
					sizeInBytes = 0x4;
					break;
				default:
					break;
			}

			if (!IsValid())
				throw new ArgumentException("Name/Type mismatch!");
		}

		public PropertyHeader(byte[] data, int start)
        {
			nameID = BitConverter.ToInt32(data, start + 0);
			typeID = BitConverter.ToInt32(data, start + 4);
			classID = BitConverter.ToInt32(data, start + 8);
			partID = BitConverter.ToInt32(data, start + 12);
			stateID = BitConverter.ToInt32(data, start + 16);
			shortFlag = BitConverter.ToInt32(data, start + 20);
			reserved = BitConverter.ToInt32(data, start + 24);
			sizeInBytes = BitConverter.ToInt32(data, start + 28);
		}

		public byte[] Serialize()
        {
			List<byte> data = new List<byte>();
			data.AddRange(BitConverter.GetBytes(nameID));
			data.AddRange(BitConverter.GetBytes(typeID));
			data.AddRange(BitConverter.GetBytes(classID));
			data.AddRange(BitConverter.GetBytes(partID));
			data.AddRange(BitConverter.GetBytes(stateID));
			data.AddRange(BitConverter.GetBytes(shortFlag));
			data.AddRange(BitConverter.GetBytes(reserved));
			data.AddRange(BitConverter.GetBytes(sizeInBytes));
			return data.ToArray();
		}

		public bool IsValid()
        {
			// First attempt was 255, but yielded false-positives.
			// Smaller than 200 eliminates type & prop name ids.
			if (partID < 0 ||
				partID > 199)
				return false;

			if (stateID < 0 ||
				stateID > 199)
				return false;

			// Not a known class
			if (classID < 0 ||
				classID > 500) // guessing here to be stateless
				return false;

			// Basic range check
			if (typeID < (int)IDENTIFIER.ENUM || typeID >= (int)IDENTIFIER.COLORSCHEMES)
				return false;

			// Some color and font props use an type id as name id.
			// They seem to contain valid data, so ill include them.
			if (nameID == (int)IDENTIFIER.COLOR &&
				typeID == (int)IDENTIFIER.COLOR)
				return true;
			if (nameID == (int)IDENTIFIER.FONT &&
				typeID == (int)IDENTIFIER.FONT)
				return true;
			if (nameID == (int)IDENTIFIER.DISKSTREAM &&
				typeID == (int)IDENTIFIER.DISKSTREAM)
				return true;
			if (nameID == (int)IDENTIFIER.STREAM &&
				typeID == (int)IDENTIFIER.STREAM)
				return true;

			// Not sure where the line for valid name ids is.
			// Upper bound is ATLASRECT, but im leaving a bit of space
			// for unknown props.
			if (nameID < (int)IDENTIFIER.COLORSCHEMES ||
				nameID > 25000)
				return false;

			return true;
		}

        public object Clone()
        {
			var hdr = new PropertyHeader(this.nameID, this.typeID);
			hdr.classID = this.classID;
			hdr.partID = this.partID;
			hdr.stateID = this.stateID;
			hdr.shortFlag = this.shortFlag;
			hdr.reserved = this.reserved;
			hdr.sizeInBytes = this.sizeInBytes;
			return hdr;
        }

		public override bool Equals(object o)
		{
			if (o == null)
				return false;

			if (!this.GetType().Equals(o.GetType()))
				return false;

			var other = (PropertyHeader)o;
			return this.nameID == other.nameID &&
				this.typeID == other.typeID &&
				this.classID == other.classID &&
				this.partID == other.partID &&
				this.stateID == other.stateID &&
				this.shortFlag == other.shortFlag &&
				this.reserved == other.reserved &&
				this.sizeInBytes == other.sizeInBytes;
		}
    };

	public class StyleProperty
	{
		public PropertyHeader Header { get; set; }

		private object m_value;

		public StyleProperty(IDENTIFIER name, IDENTIFIER type)
        {
			Header = new PropertyHeader((int)name, (int)type);
			DefaultInitValue();
		}

		public StyleProperty(PropertyHeader header)
		{
			Header = header;
			DefaultInitValue();
		}

		private void DefaultInitValue()
        {
			switch ((IDENTIFIER)Header.typeID)
			{
				case IDENTIFIER.INTLIST:
					SetValue(new List<Int32>()); break;
				case IDENTIFIER.COLORLIST:
					SetValue(new List<Color>()); break;
				case IDENTIFIER.STRING:
					SetValue(""); break;
				case IDENTIFIER.FILENAME:
				case IDENTIFIER.FILENAME_LITE:
				case IDENTIFIER.DISKSTREAM:
				case IDENTIFIER.FONT:
					SetValue(default(Int32)); break;
				case IDENTIFIER.INT:
				case IDENTIFIER.SIZE:
				case IDENTIFIER.ENUM:
				case IDENTIFIER.HIGHCONTRASTCOLORTYPE:
					SetValue(default(Int32)); break;
				case IDENTIFIER.BOOLTYPE:
					SetValue(default(bool)); break;
				case IDENTIFIER.COLOR:
					SetValue(new Color()); break;
				case IDENTIFIER.POSITION:
					SetValue(new Size()); break;
				case IDENTIFIER.RECTTYPE:
				case IDENTIFIER.MARGINS:
					SetValue(new Margins(0,0,0,0)); break;
				default:
					m_value = null; break;
			}
		}

		public object GetValue()
        {
			return m_value;
        }

		public T GetValueAs<T>()
		{
			return (T)m_value;
		}

		public string GetValueAsString()
		{
			switch ((IDENTIFIER)Header.typeID)
			{
				case IDENTIFIER.INTLIST:
					{
						var l = (List<Int32>)GetValue();
						if (l.Count <= 0) return $"Len: {l.Count}";
						if (l.Count == 1) return $"Len: {l.Count}, Values: {l[0]}";
						if (l.Count == 2) return $"Len: {l.Count}, Values: {l[0]}, {l[1]}";
						if (l.Count == 3) return $"Len: {l.Count}, Values: {l[0]}, {l[1]}, {l[2]}";
						else return $"Len: {l.Count}, Values: {l[0]}, {l[1]}, {l[2]}, ...";
					}
				case IDENTIFIER.COLORLIST:
					return "Unsupported";
				case IDENTIFIER.STRING:
					return (string)GetValue();
				case IDENTIFIER.FILENAME:
				case IDENTIFIER.FILENAME_LITE:
				case IDENTIFIER.DISKSTREAM:
					return GetValue().ToString();
				case IDENTIFIER.FONT:
					return GetValue().ToString(); // TODO: need style ref. here to print the actual font name
				case IDENTIFIER.INT:
				case IDENTIFIER.SIZE:
					return GetValue().ToString();
				case IDENTIFIER.ENUM:
				case IDENTIFIER.HIGHCONTRASTCOLORTYPE:
					{
						int index = (int)GetValue();
						var list = VisualStyleEnums.Find(Header.nameID);
						if(list == null)
                        {
							return "UNKNOWN ENUM";
						}
						
						if (index >= list.Count)
						{
							return index + " (BAD ENUM)";
						}

						return list[index].Name;
					}
				case IDENTIFIER.BOOLTYPE:
					return (bool)GetValue() ? "true" : "false";
				case IDENTIFIER.COLOR:
					{
						var c = (Color)GetValue();
						return $"{c.R}, {c.G}, {c.B}";
					}
				case IDENTIFIER.POSITION:
					{
						var p = (Size)GetValue();
						return $"{p.Width}, {p.Height}";
					}
				case IDENTIFIER.RECTTYPE:
				case IDENTIFIER.MARGINS:
                    {
						var m = (Margins)GetValue();
						return $"{m.Left}, {m.Top}, {m.Right}, {m.Bottom}";
                    }
				default:
					return "Unsupported";
			}
		}

		public void SetValue(object o)
		{
			m_value = o;
		}

		public void SetValue(string s)
        {
			Header.sizeInBytes = (s.Length + 1) * 2;
			m_value = s;
		}

		public void SetValue(List<Int32> il)
		{
			if (il.Count > 0)
			{
				Header.sizeInBytes = il.Count * 4 + 4; // 4 byte array length
			}
            else
            {
				Header.sizeInBytes = 0; // empty lists dont even have the count
			}
			m_value = il;
		}

		public void SetValue(List<Color> cl)
		{
			Header.sizeInBytes = cl.Count * 4;
			m_value = cl;
		}

		public void SetValue(int i)
        {
			switch ((IDENTIFIER)Header.typeID)
			{
				case IDENTIFIER.FILENAME:
				case IDENTIFIER.FILENAME_LITE:
				case IDENTIFIER.DISKSTREAM:
				case IDENTIFIER.FONT:
					{
						Header.shortFlag = i;
						m_value = i;
						break;
					}
				default:
					{
						m_value = i;
						break;
					}
			}
		}

		public bool IsImageProperty()
        {
			switch ((IDENTIFIER)Header.typeID)
			{
				case IDENTIFIER.FILENAME:
				case IDENTIFIER.FILENAME_LITE:
				case IDENTIFIER.DISKSTREAM:
					return true;
				default: return false;
			}
		}

		public override bool Equals(object o)
		{
			if (o == null)
				return false;

			if (!this.GetType().Equals(o.GetType()))
				return false;

			var other = (StyleProperty)o;
			return this.Header.Equals(other.Header) &&
				this.GetValue().Equals(other.GetValue());
		}
	}
}
