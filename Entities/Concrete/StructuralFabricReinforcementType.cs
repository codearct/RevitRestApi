using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class StructuralFabricReinforcementType
    {
        public StructuralFabricReinforcementType()
        {
            StructuralFabricReinforcements = new HashSet<StructuralFabricReinforcement>();
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
        public double? SheetMassperUnitArea { get; set; }
        public double? MinorReinforcementArea { get; set; }
        public double? MajorReinforcementArea { get; set; }
        public double? SheetMass { get; set; }
        public double? MinorSpacing { get; set; }
        public double? MinorNumberofWires { get; set; }
        public double? MinorEndOverhang { get; set; }
        public double? MinorStartOverhang { get; set; }
        public double? Width { get; set; }
        public double? MajorSpacing { get; set; }
        public double? MajorNumberofWires { get; set; }
        public double? MajorEndOverhang { get; set; }
        public double? Length { get; set; }
        public double? OverallLength { get; set; }
        public double? MinorDirectionWireType { get; set; }
        public double? MajorDirectionWireType { get; set; }
        public string PhysicalMaterialAsset { get; set; }
        public int? Material { get; set; }

        public virtual AssemblyCode AssemblyCodeNavigation { get; set; }
        public virtual Material MaterialNavigation { get; set; }
        public virtual OmniClassNumber OmniClassNumberNavigation { get; set; }
        public virtual ICollection<StructuralFabricReinforcement> StructuralFabricReinforcements { get; set; }
    }
}
