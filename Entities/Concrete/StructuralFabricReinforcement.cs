using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class StructuralFabricReinforcement
    {
        public int Id { get; set; }
        public int? TypeId { get; set; }
        public int? PhaseCreated { get; set; }
        public int? PhaseDemolished { get; set; }
        public int? DesignOption { get; set; }
        public string FabricNumber { get; set; }
        public string Partition { get; set; }
        public double? CutSheetMass { get; set; }
        public double? CutOverallLength { get; set; }
        public double? CutOverallWidth { get; set; }
        public double? MinorLapSpliceLength { get; set; }
        public double? MajorLapSpliceLength { get; set; }
        public string Comments { get; set; }
        public string Mark { get; set; }
        public int? Location { get; set; }

        public virtual DesignOption DesignOptionNavigation { get; set; }
        public virtual FabricLocationEnum LocationNavigation { get; set; }
        public virtual Phase PhaseCreatedNavigation { get; set; }
        public virtual Phase PhaseDemolishedNavigation { get; set; }
        public virtual StructuralFabricReinforcementType Type { get; set; }
    }
}
