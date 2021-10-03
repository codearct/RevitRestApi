using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class ElectricalCircuit
    {
        public int Id { get; set; }
        public int? DesignOption { get; set; }
        public string Panel { get; set; }
        public string CircuitNumber { get; set; }
        public int? OfRuns { get; set; }
        public int? OfHotConductors { get; set; }
        public int? OfNeutralConductors { get; set; }
        public int? OfGroundConductors { get; set; }
        public string LoadName { get; set; }
        public double? ApparentLoadPhaseC { get; set; }
        public double? ApparentLoadPhaseB { get; set; }
        public double? ApparentLoadPhaseA { get; set; }
        public double? TrueLoadPhaseC { get; set; }
        public double? TrueLoadPhaseB { get; set; }
        public double? TrueLoadPhaseA { get; set; }
        public double? TrueCurrent { get; set; }
        public double? TrueCurrentPhaseA { get; set; }
        public double? TrueCurrentPhaseB { get; set; }
        public double? TrueCurrentPhaseC { get; set; }
        public double? ApparentCurrent { get; set; }
        public double? ApparentCurrentPhaseA { get; set; }
        public double? ApparentCurrentPhaseB { get; set; }
        public double? ApparentCurrentPhaseC { get; set; }
        public double? VoltageDrop { get; set; }
        public double? Length { get; set; }
        public double? Rating { get; set; }
        public string WireSize { get; set; }
        public int? WireType { get; set; }
        public int? SystemType { get; set; }
        public string LoadClassification { get; set; }
        public double? TrueLoad { get; set; }
        public int? PowerFactorState { get; set; }
        public double? PowerFactor { get; set; }
        public double? ApparentLoad { get; set; }
        public int? BalancedLoad { get; set; }
        public double? Voltage { get; set; }
        public int? NumberofPoles { get; set; }
        public string Comments { get; set; }
        public double? Frame { get; set; }
        public int? NumberofElements { get; set; }

        public virtual DesignOption DesignOptionNavigation { get; set; }
        public virtual ElectricalSystemEnum SystemTypeNavigation { get; set; }
        public virtual WireType WireTypeNavigation { get; set; }
    }
}
