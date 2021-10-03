using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class Hvaczone
    {
        public int Id { get; set; }
        public int? DesignOption { get; set; }
        public double? CalculatedAreaperCoolingLoad { get; set; }
        public double? CalculatedAreaperHeatingLoad { get; set; }
        public int? UseAirChangesPerHour { get; set; }
        public int? UseOutsideAirPerArea { get; set; }
        public int? UseOutsideAirPerPerson { get; set; }
        public int? UseDehumidificationSetPoint { get; set; }
        public int? UseHumidificationSetPoint { get; set; }
        public double? GrossArea { get; set; }
        public double? GrossVolume { get; set; }
        public int? PhaseId { get; set; }
        public double? CalculatedSupplyAirflowperarea { get; set; }
        public double? CalculatedCoolingLoadperarea { get; set; }
        public double? CalculatedHeatingLoadperarea { get; set; }
        public int? Level { get; set; }
        public double? OutdoorAirRateAirChangesperHour { get; set; }
        public double? OutdoorAirperArea { get; set; }
        public double? OutdoorAirperPerson { get; set; }
        public double? DehumidificationSetPoint { get; set; }
        public double? HumidificationSetPoint { get; set; }
        public double? CoolingAirTemperature { get; set; }
        public double? HeatingAirTemperature { get; set; }
        public double? CoolingSetPoint { get; set; }
        public double? HeatingSetPoint { get; set; }
        public double? CalculatedSupplyAirflow { get; set; }
        public double? CalculatedCoolingLoad { get; set; }
        public double? CalculatedHeatingLoad { get; set; }
        public int? ServiceType { get; set; }
        public double? OccupiedVolume { get; set; }
        public double? Perimeter { get; set; }
        public double? OccupiedArea { get; set; }
        public double? CoilBypass { get; set; }
        public string Name { get; set; }
        public string Comments { get; set; }

        public virtual DesignOption DesignOptionNavigation { get; set; }
        public virtual ServiceTypeEnum ServiceTypeNavigation { get; set; }
    }
}
