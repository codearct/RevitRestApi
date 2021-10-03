using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class ElectricalSystemEnum
    {
        public ElectricalSystemEnum()
        {
            ElectricalCircuits = new HashSet<ElectricalCircuit>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ElectricalCircuit> ElectricalCircuits { get; set; }
    }
}
