using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class ElectricalPhaseConfigurationEnum
    {
        public ElectricalPhaseConfigurationEnum()
        {
            DistributionSystemTypes = new HashSet<DistributionSystemType>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<DistributionSystemType> DistributionSystemTypes { get; set; }
    }
}
