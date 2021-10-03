using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class Mass
    {
        public int Id { get; set; }
        public int? TypeId { get; set; }
        public int? PhaseCreated { get; set; }
        public int? PhaseDemolished { get; set; }
        public int? DesignOption { get; set; }
        public double? GrossVolume { get; set; }
        public double? GrossSurfaceArea { get; set; }
        public double? GrossFloorArea { get; set; }
        public string Comments { get; set; }
        public int? BaseLevel { get; set; }
        public string Mark { get; set; }

        public virtual DesignOption DesignOptionNavigation { get; set; }
        public virtual Phase PhaseCreatedNavigation { get; set; }
        public virtual Phase PhaseDemolishedNavigation { get; set; }
        public virtual MassType Type { get; set; }
    }
}
