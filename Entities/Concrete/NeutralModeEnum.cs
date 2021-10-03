using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class NeutralModeEnum
    {
        public NeutralModeEnum()
        {
            WireTypes = new HashSet<WireType>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<WireType> WireTypes { get; set; }
    }
}
