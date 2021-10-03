using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class Ceiling
    {
        public Ceiling()
        {
            LightingFixtureOnCeilings = new HashSet<LightingFixtureOnCeiling>();
        }

        public int Id { get; set; }
        public int? TypeId { get; set; }
        public int? PhaseCreated { get; set; }
        public int? PhaseDemolished { get; set; }
        public int? DesignOption { get; set; }
        public double? Volume { get; set; }
        public double? Area { get; set; }
        public string Comments { get; set; }
        public double? HeightOffsetFromLevel { get; set; }
        public int? Level { get; set; }
        public double? Perimeter { get; set; }
        public string Mark { get; set; }

        public virtual DesignOption DesignOptionNavigation { get; set; }
        public virtual Level LevelNavigation { get; set; }
        public virtual Phase PhaseCreatedNavigation { get; set; }
        public virtual Phase PhaseDemolishedNavigation { get; set; }
        public virtual CeilingType Type { get; set; }
        public virtual ICollection<LightingFixtureOnCeiling> LightingFixtureOnCeilings { get; set; }
    }
}
