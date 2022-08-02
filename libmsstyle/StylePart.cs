using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libmsstyle
{
    public class StylePart : IDisposable
    {
        public int PartId { get; set; }
        public string PartName { get; set; }
        public Dictionary<int, StyleState> States { get; set; }

        public StylePart()
        {
            States = new Dictionary<int, StyleState>();
        }

        public IEnumerable<StyleProperty> GetImageProperties()
        {
            foreach (var state in States)
            {
                var imgProps = state.Value.Properties.FindAll((p) =>
                    p.IsImageProperty()
                );

                foreach(var imgProp in imgProps)
                {
                    yield return imgProp;
                }
            }
        }

        public void Dispose()
        {
            States.GetEnumerator().Dispose();
        }
    }
}
