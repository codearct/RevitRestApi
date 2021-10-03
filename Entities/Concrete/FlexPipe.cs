using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class FlexPipe
    {
        public int Id { get; set; }
        public int? TypeId { get; set; }
        public int? PhaseCreated { get; set; }
        public int? PhaseDemolished { get; set; }
        public int? DesignOption { get; set; }
        public int? SystemType { get; set; }
        public string SystemClassification { get; set; }
        public string SystemName { get; set; }
        public double? FixtureUnits { get; set; }
        public double? OutsideDiameter { get; set; }
        public double? AdditionalFlow { get; set; }
        public double? Diameter { get; set; }
        public double? Flow { get; set; }
        public double? InsideDiameter { get; set; }
        public double? ReynoldsNumber { get; set; }
        public double? RelativeRoughness { get; set; }
        public int? FlowState { get; set; }
        public double? FrictionFactor { get; set; }
        public double? Velocity { get; set; }
        public double? Friction { get; set; }
        public double? PressureDrop { get; set; }
        public int? Section { get; set; }
        public string Comments { get; set; }
        public double? Length { get; set; }
        public string Mark { get; set; }
        public double? InsulationThickness { get; set; }
        public string InsulationType { get; set; }
        public string OverallSize { get; set; }

        public virtual DesignOption DesignOptionNavigation { get; set; }
        public virtual PipeFlowStateEnum FlowStateNavigation { get; set; }
        public virtual Phase PhaseCreatedNavigation { get; set; }
        public virtual Phase PhaseDemolishedNavigation { get; set; }
        public virtual FlexPipeType Type { get; set; }
    }
}
