using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class PipingSystemType
    {
        public int Id { get; set; }
        public string Abbreviation { get; set; }
        public string Description { get; set; }
        public double? FluidDensity { get; set; }
        public double? FluidTemperature { get; set; }
        public int? FluidType { get; set; }
        public double? FluidDynamicViscosity { get; set; }
        public int? SingleLineDropSymbol { get; set; }
        public int? SingleLineRiseSymbol { get; set; }
        public int? SingleLineTeeDownSymbol { get; set; }
        public int? SingleLineTeeUpSymbol { get; set; }
        public string SystemClassification { get; set; }
        public int? TwoLineDropSymbol { get; set; }
        public int? TwoLineRiseSymbol { get; set; }
        public string TypeComments { get; set; }
        public string Url { get; set; }
    }
}
