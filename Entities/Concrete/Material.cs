using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class Material
    {
        public Material()
        {
            Categories = new HashSet<Category>();
            FasciaTypes = new HashSet<FasciaType>();
            GutterTypes = new HashSet<GutterType>();
            MaterialQuantities = new HashSet<MaterialQuantity>();
            PipeSegments = new HashSet<PipeSegment>();
            SlabEdgeTypes = new HashSet<SlabEdgeType>();
            StructuralFabricReinforcementTypes = new HashSet<StructuralFabricReinforcementType>();
            WallSweepTypes = new HashSet<WallSweepType>();
        }

        public int Id { get; set; }
        public string Keynote { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string Comments { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public double? Cost { get; set; }
        public string Mark { get; set; }
        public string Grade { get; set; }
        public string Species { get; set; }
        public double? Thermalexpansioncoefficient { get; set; }
        public double? Bending { get; set; }
        public double? Shearmodulus { get; set; }
        public double? Poissonratio { get; set; }
        public double? Tensionperpendiculartograin { get; set; }
        public double? Shearparalleltograin { get; set; }
        public double? Compressionperpendiculartograin { get; set; }
        public double? Compressionparalleltograin { get; set; }
        public double? Youngmodulus { get; set; }
        public int? MaterialType { get; set; }
        public int? Lightweight { get; set; }
        public int? Behavior { get; set; }
        public double? Resistancecalculationstrength { get; set; }
        public double? Reductionfactorforshear { get; set; }
        public double? Minimumtensilestrength { get; set; }
        public double? Minimumyieldstress { get; set; }
        public double? Shearstrengthmodification { get; set; }
        public double? Shearreinforcementyieldstress { get; set; }
        public double? Bendingreinforcement { get; set; }
        public double? Concretecompression { get; set; }
        public double? Dampingratio { get; set; }
        public double? ThermalexpansioncoefficientX { get; set; }
        public double? ThermalexpansioncoefficientY { get; set; }
        public double? ThermalexpansioncoefficientZ { get; set; }
        public double? Unitweight { get; set; }
        public double? ShearmodulusX { get; set; }
        public double? ShearmodulusY { get; set; }
        public double? ShearmodulusZ { get; set; }
        public double? PoissonratioX { get; set; }
        public double? PoissonratioY { get; set; }
        public double? PoissonratioZ { get; set; }
        public double? YoungmodulusX { get; set; }
        public double? YoungmodulusY { get; set; }
        public double? YoungmodulusZ { get; set; }
        public int? Shininess { get; set; }
        public int? Smoothness { get; set; }
        public int? Glow { get; set; }
        public int? Transparency { get; set; }
        public int? Color { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<FasciaType> FasciaTypes { get; set; }
        public virtual ICollection<GutterType> GutterTypes { get; set; }
        public virtual ICollection<MaterialQuantity> MaterialQuantities { get; set; }
        public virtual ICollection<PipeSegment> PipeSegments { get; set; }
        public virtual ICollection<SlabEdgeType> SlabEdgeTypes { get; set; }
        public virtual ICollection<StructuralFabricReinforcementType> StructuralFabricReinforcementTypes { get; set; }
        public virtual ICollection<WallSweepType> WallSweepTypes { get; set; }
    }
}
