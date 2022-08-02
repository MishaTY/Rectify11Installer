using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libmsstyle
{
    public enum StyleResourceType
    {
        None,
        Image,
        Atlas
    }

    public class StyleResource
    {
        private byte[] m_data;
        public byte[] Data { get => m_data; }

        private int m_resId;
        public int ResourceId { get => m_resId; }

        private StyleResourceType m_type;
        public StyleResourceType Type { get => m_type; }

        public StyleResource(byte[] data, int resId, StyleResourceType type)
        {
            m_data = data;
            m_resId = resId;
            m_type = type;
        }

        public override bool Equals(object obj)
        {
            if (obj is StyleResource other)
            {
                return
                    this.m_resId == other.m_resId &&
                    this.m_type == other.m_type &&
                    object.ReferenceEquals(this.m_data, other.m_data);
            }
            else return false;
        }

        public override int GetHashCode()
        {
            int hash = 1337;
            hash = (hash * 4) ^ m_resId;
            hash = (hash * 4) ^ (int)m_type;
            hash = (hash * 4) ^ (m_data != null ? m_data.Length : 0);
            return hash;
        }
    }
}
