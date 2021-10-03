using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class ElementPhase
    {
        public int ElementId { get; set; }
        public string ElementName { get; set; }
        public int? PhaseCreatedId { get; set; }
        public string PhaseName { get; set; }

        public virtual Phase PhaseCreated { get; set; }
    }
}
