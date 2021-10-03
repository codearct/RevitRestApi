using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class DuctInsulation
    {
        public int Id { get; set; }
        public int? TypeId { get; set; }
        public int? PhaseCreated { get; set; }
        public int? PhaseDemolished { get; set; }
        public int? DesignOption { get; set; }
        public string Comments { get; set; }
        public string Mark { get; set; }

        public virtual DesignOption DesignOptionNavigation { get; set; }
        public virtual Phase PhaseCreatedNavigation { get; set; }
        public virtual Phase PhaseDemolishedNavigation { get; set; }
        public virtual DuctInsulationType Type { get; set; }
    }
}
