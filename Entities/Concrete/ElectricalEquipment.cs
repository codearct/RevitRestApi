using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class ElectricalEquipment
    {
        public int Id { get; set; }
        public int? TypeId { get; set; }
        public int? PhaseCreated { get; set; }
        public int? PhaseDemolished { get; set; }
        public int? DesignOption { get; set; }
        public string Modifications { get; set; }
        public string Enclosure { get; set; }
        public double? Mains { get; set; }
        public string Mounting { get; set; }
        public string ShortCircuitRating { get; set; }
        public int? Max1poleBreakers { get; set; }
        public string PanelName { get; set; }
        public double? TotalEstimatedDemand { get; set; }
        public double? TotalConnected { get; set; }
        public double? ApparentLoadPhaseA { get; set; }
        public double? ApparentLoadPhaseB { get; set; }
        public double? ApparentLoadPhaseC { get; set; }
        public string ElectricalData { get; set; }
        public string Comments { get; set; }
        public int? HostId { get; set; }
        public int? Level { get; set; }
        public string Mark { get; set; }
        public double? CurrentPhaseA { get; set; }
        public double? CurrentPhaseB { get; set; }
        public double? CurrentPhaseC { get; set; }
        public string Feed { get; set; }
        public string Location { get; set; }
        public int? NumberofWires { get; set; }
        public int? NumberofPhases { get; set; }
        public string SupplyFrom { get; set; }
        public double? TotalConnectedCurrent { get; set; }
        public double? TotalDemandFactor { get; set; }
        public double? TotalEstimatedDemandCurrent { get; set; }

        public virtual DesignOption DesignOptionNavigation { get; set; }
        public virtual Level LevelNavigation { get; set; }
        public virtual Phase PhaseCreatedNavigation { get; set; }
        public virtual Phase PhaseDemolishedNavigation { get; set; }
        public virtual ElectricalEquipmentType Type { get; set; }
    }
}
