using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class Topography
    {
        public int Id { get; set; }
        public int? TypeId { get; set; }
        public int? PhaseCreated { get; set; }
        public int? PhaseDemolished { get; set; }
        public int? DesignOption { get; set; }
        public double? NetcutFill { get; set; }
        public double? ProjectedArea { get; set; }
        public double? Fill { get; set; }
        public double? Cut { get; set; }
        public double? SurfaceArea { get; set; }
        public string Comments { get; set; }
        public string Name { get; set; }
        public string Mark { get; set; }

        public virtual DesignOption DesignOptionNavigation { get; set; }
        public virtual Phase PhaseCreatedNavigation { get; set; }
        public virtual Phase PhaseDemolishedNavigation { get; set; }
        public virtual TopographyType Type { get; set; }
    }
}
