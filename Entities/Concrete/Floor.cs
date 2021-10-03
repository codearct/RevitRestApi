using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class Floor
    {
        public Floor()
        {
            AreaLoadOnSlabs = new HashSet<AreaLoadOnSlab>();
            OpeningOnFloors = new HashSet<OpeningOnFloor>();
            RebarOnFloors = new HashSet<RebarOnFloor>();
        }

        public int Id { get; set; }
        public int? TypeId { get; set; }
        public int? PhaseCreated { get; set; }
        public int? PhaseDemolished { get; set; }
        public int? DesignOption { get; set; }
        public double? EstimatedReinforcementVolume { get; set; }
        public double? Volume { get; set; }
        public double? Area { get; set; }
        public string Comments { get; set; }
        public int? Level { get; set; }
        public int? Structural { get; set; }
        public double? Perimeter { get; set; }
        public double? HeightOffsetFromLevel { get; set; }
        public int? AnalyzeAs { get; set; }
        public string Mark { get; set; }

        public virtual AnalyzesAsTypeEnum AnalyzeAsNavigation { get; set; }
        public virtual DesignOption DesignOptionNavigation { get; set; }
        public virtual Level LevelNavigation { get; set; }
        public virtual Phase PhaseCreatedNavigation { get; set; }
        public virtual Phase PhaseDemolishedNavigation { get; set; }
        public virtual FloorType Type { get; set; }
        public virtual ICollection<AreaLoadOnSlab> AreaLoadOnSlabs { get; set; }
        public virtual ICollection<OpeningOnFloor> OpeningOnFloors { get; set; }
        public virtual ICollection<RebarOnFloor> RebarOnFloors { get; set; }
    }
}
