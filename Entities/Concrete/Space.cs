using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class Space
    {
        public Space()
        {
            SpaceAssociations = new HashSet<SpaceAssociation>();
        }

        public int Id { get; set; }
        public int? DesignOption { get; set; }
        public double? RoomCavityRatio { get; set; }
        public double? AverageEstimatedIllumination { get; set; }
        public double? FloorReflectance { get; set; }
        public double? WallReflectance { get; set; }
        public double? CeilingReflectance { get; set; }
        public double? LightingCalculationWorkplane { get; set; }
        public int? Plenum { get; set; }
        public int? Occupiable { get; set; }
        public string RoomNumber { get; set; }
        public string RoomName { get; set; }
        public double? CalculatedSupplyAirflowperarea { get; set; }
        public double? CalculatedCoolingLoadperarea { get; set; }
        public double? CalculatedHeatingLoadperarea { get; set; }
        public double? ActualLightingLoadperarea { get; set; }
        public double? ActualPowerLoadperarea { get; set; }
        public int? HeatLoadValues { get; set; }
        public double? DesignCoolingLoad { get; set; }
        public double? CalculatedCoolingLoad { get; set; }
        public double? DesignHeatingLoad { get; set; }
        public double? CalculatedHeatingLoad { get; set; }
        public int? ConstructionType { get; set; }
        public double? SensibleHeatGainperperson { get; set; }
        public double? SpecifiedLightingLoad { get; set; }
        public double? SpecifiedPowerLoad { get; set; }
        public double? ActualLightingLoad { get; set; }
        public double? ActualPowerLoad { get; set; }
        public double? DesignOtherLoadperarea { get; set; }
        public double? DesignHvacloadperarea { get; set; }
        public double? SpecifiedLightingLoadperarea { get; set; }
        public double? SpecifiedPowerLoadperarea { get; set; }
        public double? ActualExhaustAirflow { get; set; }
        public double? ActualReturnAirflow { get; set; }
        public double? ActualSupplyAirflow { get; set; }
        public double? LatentHeatGainperperson { get; set; }
        public double? TotalHeatGainperperson { get; set; }
        public double? CalculatedSupplyAirflow { get; set; }
        public double? SpecifiedExhaustAirflow { get; set; }
        public double? SpecifiedReturnAirflow { get; set; }
        public double? SpecifiedSupplyAirflow { get; set; }
        public double? AreaperPerson { get; set; }
        public double? NumberofPeople { get; set; }
        public int? SpaceType { get; set; }
        public int? ConditionType { get; set; }
        public int? PhaseId { get; set; }
        public string Comments { get; set; }
        public double? Volume { get; set; }
        public double? Perimeter { get; set; }
        public int? Level { get; set; }
        public double? Area { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public double? UnboundedHeight { get; set; }

        public virtual ConditionTypeEnum ConditionTypeNavigation { get; set; }
        public virtual DesignOption DesignOptionNavigation { get; set; }
        public virtual Level LevelNavigation { get; set; }
        public virtual Phase Phase { get; set; }
        public virtual SpaceTypeEnum SpaceTypeNavigation { get; set; }
        public virtual ICollection<SpaceAssociation> SpaceAssociations { get; set; }
    }
}
