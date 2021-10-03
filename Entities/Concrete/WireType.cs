using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class WireType
    {
        public WireType()
        {
            ElectricalCircuits = new HashSet<ElectricalCircuit>();
            Wires = new HashSet<Wire>();
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
        public int? ShareNeutralConductor { get; set; }
        public int? ShareGroundConductor { get; set; }
        public int? Material { get; set; }
        public int? TemperatureRating { get; set; }
        public int? Insulation { get; set; }
        public string MaxSize { get; set; }
        public double? NeutralMultiplier { get; set; }
        public int? NeutralIncludedinBalancedLoad { get; set; }
        public int? NeutralSize { get; set; }
        public string ConduitType { get; set; }

        public virtual AssemblyCode AssemblyCodeNavigation { get; set; }
        public virtual NeutralModeEnum NeutralSizeNavigation { get; set; }
        public virtual OmniClassNumber OmniClassNumberNavigation { get; set; }
        public virtual ICollection<ElectricalCircuit> ElectricalCircuits { get; set; }
        public virtual ICollection<Wire> Wires { get; set; }
    }
}
