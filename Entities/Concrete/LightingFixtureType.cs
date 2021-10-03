using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class LightingFixtureType
    {
        public LightingFixtureType()
        {
            LightingFixtures = new HashSet<LightingFixture>();
        }

        public int Id { get; set; }
        public string Keynote { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string TypeComments { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public string OmniClassNumber { get; set; }
        public string AssemblyCode { get; set; }
        public string FamilyName { get; set; }
        public string TypeName { get; set; }
        public string TypeMark { get; set; }
        public double? Cost { get; set; }
        public double? LightSourceSymbolLength { get; set; }
        public double? LightSourceSymbolSize { get; set; }
        public double? EmitfromCircleDiameter { get; set; }
        public double? EmitfromRectangleLength { get; set; }
        public double? EmitfromRectangleWidth { get; set; }
        public double? EmitfromLineLength { get; set; }
        public int? EmitShapeVisibleinRendering { get; set; }
        public int? DimmingLampColorTemperatureShift { get; set; }
        public double? LuminaireDirtDepreciation { get; set; }
        public double? LampLumenDepreciation { get; set; }
        public double? SurfaceDepreciationLoss { get; set; }
        public double? LampTiltLoss { get; set; }
        public double? VoltageLoss { get; set; }
        public double? TemperatureLoss { get; set; }
        public double? InitialColorTemperature { get; set; }
        public double? Illuminance { get; set; }
        public double? LuminousIntensity { get; set; }
        public double? Efficacy { get; set; }
        public double? Wattage { get; set; }
        public string PhotometricWebFile { get; set; }
        public double? ApparentLoad { get; set; }
        public double? BallastLoss { get; set; }
        public double? TotalLightLossFactor { get; set; }
        public double? SpotFieldAngle { get; set; }
        public double? SpotBeamAngle { get; set; }
        public double? TiltAngle { get; set; }
        public double? LuminousFlux { get; set; }
        public string Lamp { get; set; }
        public string WattageComments { get; set; }

        public virtual AssemblyCode AssemblyCodeNavigation { get; set; }
        public virtual OmniClassNumber OmniClassNumberNavigation { get; set; }
        public virtual ICollection<LightingFixture> LightingFixtures { get; set; }
    }
}
