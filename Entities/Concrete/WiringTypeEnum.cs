using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class WiringTypeEnum
    {
        public WiringTypeEnum()
        {
            Wires = new HashSet<Wire>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Wire> Wires { get; set; }
    }
}
