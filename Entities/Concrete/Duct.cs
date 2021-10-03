using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class Duct
    {
        public int Id { get; set; }
        public int? TypeId { get; set; }
        public int? PhaseCreated { get; set; }
        public int? PhaseDemolished { get; set; }
        public int? DesignOption { get; set; }
        public int? SystemType { get; set; }
        public string SystemClassification { get; set; }
        public string SystemName { get; set; }
        public double? BottomElevation { get; set; }
        public double? TopElevation { get; set; }
        public string Size { get; set; }
        public int? SizeLock { get; set; }
        public double? AdditionalFlow { get; set; }
        public double? HydraulicDiameter { get; set; }
        public double? Reynoldsnumber { get; set; }
        public double? EquivalentDiameter { get; set; }
        public int? Section { get; set; }
        public double? LossCoefficient { get; set; }
        public double? VelocityPressure { get; set; }
        public double? Area { get; set; }
        public double? LiningThickness { get; set; }
        public double? InsulationThickness { get; set; }
        public double? Friction { get; set; }
        public double? PressureDrop { get; set; }
        public double? Velocity { get; set; }
        public double? Diameter { get; set; }
        public double? Height { get; set; }
        public double? Width { get; set; }
        public double? Flow { get; set; }
        public string Comments { get; set; }
        public double? Length { get; set; }
        public string Mark { get; set; }
        public string FreeSize { get; set; }
        public string InsulationType { get; set; }
        public string LiningType { get; set; }
        public string OverallSize { get; set; }

        public virtual DesignOption DesignOptionNavigation { get; set; }
        public virtual Phase PhaseCreatedNavigation { get; set; }
        public virtual Phase PhaseDemolishedNavigation { get; set; }
        public virtual DuctType Type { get; set; }
    }
}
