using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class ElectricalPhaseEnum
    {
        public ElectricalPhaseEnum()
        {
            DistributionSystemTypes = new HashSet<DistributionSystemType>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<DistributionSystemType> DistributionSystemTypes { get; set; }
    }
}
