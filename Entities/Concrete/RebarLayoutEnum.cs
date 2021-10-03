using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class RebarLayoutEnum
    {
        public RebarLayoutEnum()
        {
            StructuralRebars = new HashSet<StructuralRebar>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<StructuralRebar> StructuralRebars { get; set; }
    }
}
