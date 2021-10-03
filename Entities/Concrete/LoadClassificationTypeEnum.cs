using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class LoadClassificationTypeEnum
    {
        public LoadClassificationTypeEnum()
        {
            DemandFactorTypes = new HashSet<DemandFactorType>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<DemandFactorType> DemandFactorTypes { get; set; }
    }
}
