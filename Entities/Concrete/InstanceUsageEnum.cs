using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class InstanceUsageEnum
    {
        public InstanceUsageEnum()
        {
            StructuralFramings = new HashSet<StructuralFraming>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<StructuralFraming> StructuralFramings { get; set; }
    }
}
