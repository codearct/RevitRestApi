using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class StructuralFraming
    {
        public StructuralFraming()
        {
            LineLoadOnBeams = new HashSet<LineLoadOnBeam>();
            RebarOnFramings = new HashSet<RebarOnFraming>();
        }

        public int Id { get; set; }
        public int? TypeId { get; set; }
        public int? PhaseCreated { get; set; }
        public int? PhaseDemolished { get; set; }
        public int? DesignOption { get; set; }
        public double? EstimatedReinforcementVolume { get; set; }
        public double? Volume { get; set; }
        public string Comments { get; set; }
        public int? Level { get; set; }
        public double? CutLength { get; set; }
        public int? ReferenceLevel { get; set; }
        public int? StructuralUsage { get; set; }
        public double? Length { get; set; }
        public string Mark { get; set; }

        public virtual DesignOption DesignOptionNavigation { get; set; }
        public virtual Level LevelNavigation { get; set; }
        public virtual Phase PhaseCreatedNavigation { get; set; }
        public virtual Phase PhaseDemolishedNavigation { get; set; }
        public virtual Level ReferenceLevelNavigation { get; set; }
        public virtual InstanceUsageEnum StructuralUsageNavigation { get; set; }
        public virtual StructuralFramingType Type { get; set; }
        public virtual ICollection<LineLoadOnBeam> LineLoadOnBeams { get; set; }
        public virtual ICollection<RebarOnFraming> RebarOnFramings { get; set; }
    }
}
