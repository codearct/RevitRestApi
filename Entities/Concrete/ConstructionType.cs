using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class ConstructionType
    {
        public ConstructionType()
        {
            Constructions = new HashSet<Construction>();
        }

        public int Id { get; set; }

        public virtual ICollection<Construction> Constructions { get; set; }
    }
}
