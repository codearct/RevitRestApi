using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class StructuralFoundation
    {
        public StructuralFoundation()
        {
            RebarOnFoundations = new HashSet<RebarOnFoundation>();
        }

        public int Id { get; set; }
        public int? TypeId { get; set; }
        public int? PhaseCreated { get; set; }
        public int? PhaseDemolished { get; set; }
        public int? DesignOption { get; set; }
        public double? EstimatedReinforcementVolume { get; set; }
        public double? Volume { get; set; }
        public string Comments { get; set; }
        public double? Length { get; set; }
        public double? ElevationatBottom { get; set; }
        public double? Width { get; set; }
        public string Mark { get; set; }

        public virtual DesignOption DesignOptionNavigation { get; set; }
        public virtual Phase PhaseCreatedNavigation { get; set; }
        public virtual Phase PhaseDemolishedNavigation { get; set; }
        public virtual StructuralFoundationType Type { get; set; }
        public virtual ICollection<RebarOnFoundation> RebarOnFoundations { get; set; }
    }
}
