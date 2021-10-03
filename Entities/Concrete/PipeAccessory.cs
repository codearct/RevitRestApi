using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class PipeAccessory
    {
        public int Id { get; set; }
        public int? TypeId { get; set; }
        public int? PhaseCreated { get; set; }
        public int? PhaseDemolished { get; set; }
        public int? DesignOption { get; set; }
        public string SystemClassification { get; set; }
        public double? InsulationThickness { get; set; }
        public string InsulationType { get; set; }
        public string OverallSize { get; set; }
        public string SystemName { get; set; }
        public string Size { get; set; }
        public string Comments { get; set; }
        public string Mark { get; set; }

        public virtual DesignOption DesignOptionNavigation { get; set; }
        public virtual Phase PhaseCreatedNavigation { get; set; }
        public virtual Phase PhaseDemolishedNavigation { get; set; }
        public virtual PipeAccessoryType Type { get; set; }
    }
}
