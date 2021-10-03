using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class OmniClassNumber
    {
        public OmniClassNumber()
        {
            AirTerminalTypes = new HashSet<AirTerminalType>();
            AssemblyTypes = new HashSet<AssemblyType>();
            CableTrayFittingTypes = new HashSet<CableTrayFittingType>();
            CableTrayTypes = new HashSet<CableTrayType>();
            CaseworkTypes = new HashSet<CaseworkType>();
            CeilingTypes = new HashSet<CeilingType>();
            ColumnTypes = new HashSet<ColumnType>();
            CommunicationDeviceTypes = new HashSet<CommunicationDeviceType>();
            ConduitFittingTypes = new HashSet<ConduitFittingType>();
            ConduitTypes = new HashSet<ConduitType>();
            CoverTypes = new HashSet<CoverType>();
            CurtainPanelTypes = new HashSet<CurtainPanelType>();
            CurtainSystemTypes = new HashSet<CurtainSystemType>();
            CurtainWallMullionTypes = new HashSet<CurtainWallMullionType>();
            DataDeviceTypes = new HashSet<DataDeviceType>();
            DemandFactorTypes = new HashSet<DemandFactorType>();
            DistributionSystemTypes = new HashSet<DistributionSystemType>();
            DivisionProfiles = new HashSet<DivisionProfile>();
            DoorTypes = new HashSet<DoorType>();
            DuctAccessoryTypes = new HashSet<DuctAccessoryType>();
            DuctFittingTypes = new HashSet<DuctFittingType>();
            DuctInsulationTypes = new HashSet<DuctInsulationType>();
            DuctLiningTypes = new HashSet<DuctLiningType>();
            DuctTypes = new HashSet<DuctType>();
            ElectricalEquipmentTypes = new HashSet<ElectricalEquipmentType>();
            ElectricalFixtureTypes = new HashSet<ElectricalFixtureType>();
            FasciaTypes = new HashSet<FasciaType>();
            FireAlarmDeviceTypes = new HashSet<FireAlarmDeviceType>();
            FlexDuctTypes = new HashSet<FlexDuctType>();
            FlexPipeTypes = new HashSet<FlexPipeType>();
            FloorTypes = new HashSet<FloorType>();
            FluidTypes = new HashSet<FluidType>();
            FurnitureSystemTypes = new HashSet<FurnitureSystemType>();
            FurnitureTypes = new HashSet<FurnitureType>();
            GenericModelTypes = new HashSet<GenericModelType>();
            GutterTypes = new HashSet<GutterType>();
            LightingDeviceTypes = new HashSet<LightingDeviceType>();
            LightingFixtureTypes = new HashSet<LightingFixtureType>();
            MassTypes = new HashSet<MassType>();
            MechanicalEquipmentTypes = new HashSet<MechanicalEquipmentType>();
            NurseCallDeviceTypes = new HashSet<NurseCallDeviceType>();
            ParkingTypes = new HashSet<ParkingType>();
            PipeAccessoryTypes = new HashSet<PipeAccessoryType>();
            PipeConnectionTypes = new HashSet<PipeConnectionType>();
            PipeFittingTypes = new HashSet<PipeFittingType>();
            PipeInsulationTypes = new HashSet<PipeInsulationType>();
            PipeMaterialTypes = new HashSet<PipeMaterialType>();
            PipeScheduleTypes = new HashSet<PipeScheduleType>();
            PipeTypes = new HashSet<PipeType>();
            PlantingTypes = new HashSet<PlantingType>();
            PlumbingFixtureTypes = new HashSet<PlumbingFixtureType>();
            Profiles = new HashSet<Profile>();
            PropertyLineTypes = new HashSet<PropertyLineType>();
            RailingTypes = new HashSet<RailingType>();
            RampTypes = new HashSet<RampType>();
            RoofTypes = new HashSet<RoofType>();
            SecurityDeviceTypes = new HashSet<SecurityDeviceType>();
            SiteTypes = new HashSet<SiteType>();
            SlabEdgeTypes = new HashSet<SlabEdgeType>();
            SpecialtyEquipmentTypes = new HashSet<SpecialtyEquipmentType>();
            SprinklerTypes = new HashSet<SprinklerType>();
            StairTypes = new HashSet<StairType>();
            StructuralColumnTypes = new HashSet<StructuralColumnType>();
            StructuralFabricReinforcementTypes = new HashSet<StructuralFabricReinforcementType>();
            StructuralFoundationTypes = new HashSet<StructuralFoundationType>();
            StructuralFramingTypes = new HashSet<StructuralFramingType>();
            StructuralRebarBarTypes = new HashSet<StructuralRebarBarType>();
            StructuralRebarHookTypes = new HashSet<StructuralRebarHookType>();
            StructuralRebarShapes = new HashSet<StructuralRebarShape>();
            StructuralStiffenerTypes = new HashSet<StructuralStiffenerType>();
            StructuralTrussTypes = new HashSet<StructuralTrussType>();
            TelephoneDeviceTypes = new HashSet<TelephoneDeviceType>();
            TopographyTypes = new HashSet<TopographyType>();
            VoltageTypes = new HashSet<VoltageType>();
            WallSweepTypes = new HashSet<WallSweepType>();
            WallTypes = new HashSet<WallType>();
            WindowTypes = new HashSet<WindowType>();
            WireInsulationTypes = new HashSet<WireInsulationType>();
            WireMaterialTypes = new HashSet<WireMaterialType>();
            WireTemperatureRatingTypes = new HashSet<WireTemperatureRatingType>();
            WireTypes = new HashSet<WireType>();
        }

        public string OmniClassNumber1 { get; set; }
        public string OmniClassTitle { get; set; }

        public virtual ICollection<AirTerminalType> AirTerminalTypes { get; set; }
        public virtual ICollection<AssemblyType> AssemblyTypes { get; set; }
        public virtual ICollection<CableTrayFittingType> CableTrayFittingTypes { get; set; }
        public virtual ICollection<CableTrayType> CableTrayTypes { get; set; }
        public virtual ICollection<CaseworkType> CaseworkTypes { get; set; }
        public virtual ICollection<CeilingType> CeilingTypes { get; set; }
        public virtual ICollection<ColumnType> ColumnTypes { get; set; }
        public virtual ICollection<CommunicationDeviceType> CommunicationDeviceTypes { get; set; }
        public virtual ICollection<ConduitFittingType> ConduitFittingTypes { get; set; }
        public virtual ICollection<ConduitType> ConduitTypes { get; set; }
        public virtual ICollection<CoverType> CoverTypes { get; set; }
        public virtual ICollection<CurtainPanelType> CurtainPanelTypes { get; set; }
        public virtual ICollection<CurtainSystemType> CurtainSystemTypes { get; set; }
        public virtual ICollection<CurtainWallMullionType> CurtainWallMullionTypes { get; set; }
        public virtual ICollection<DataDeviceType> DataDeviceTypes { get; set; }
        public virtual ICollection<DemandFactorType> DemandFactorTypes { get; set; }
        public virtual ICollection<DistributionSystemType> DistributionSystemTypes { get; set; }
        public virtual ICollection<DivisionProfile> DivisionProfiles { get; set; }
        public virtual ICollection<DoorType> DoorTypes { get; set; }
        public virtual ICollection<DuctAccessoryType> DuctAccessoryTypes { get; set; }
        public virtual ICollection<DuctFittingType> DuctFittingTypes { get; set; }
        public virtual ICollection<DuctInsulationType> DuctInsulationTypes { get; set; }
        public virtual ICollection<DuctLiningType> DuctLiningTypes { get; set; }
        public virtual ICollection<DuctType> DuctTypes { get; set; }
        public virtual ICollection<ElectricalEquipmentType> ElectricalEquipmentTypes { get; set; }
        public virtual ICollection<ElectricalFixtureType> ElectricalFixtureTypes { get; set; }
        public virtual ICollection<FasciaType> FasciaTypes { get; set; }
        public virtual ICollection<FireAlarmDeviceType> FireAlarmDeviceTypes { get; set; }
        public virtual ICollection<FlexDuctType> FlexDuctTypes { get; set; }
        public virtual ICollection<FlexPipeType> FlexPipeTypes { get; set; }
        public virtual ICollection<FloorType> FloorTypes { get; set; }
        public virtual ICollection<FluidType> FluidTypes { get; set; }
        public virtual ICollection<FurnitureSystemType> FurnitureSystemTypes { get; set; }
        public virtual ICollection<FurnitureType> FurnitureTypes { get; set; }
        public virtual ICollection<GenericModelType> GenericModelTypes { get; set; }
        public virtual ICollection<GutterType> GutterTypes { get; set; }
        public virtual ICollection<LightingDeviceType> LightingDeviceTypes { get; set; }
        public virtual ICollection<LightingFixtureType> LightingFixtureTypes { get; set; }
        public virtual ICollection<MassType> MassTypes { get; set; }
        public virtual ICollection<MechanicalEquipmentType> MechanicalEquipmentTypes { get; set; }
        public virtual ICollection<NurseCallDeviceType> NurseCallDeviceTypes { get; set; }
        public virtual ICollection<ParkingType> ParkingTypes { get; set; }
        public virtual ICollection<PipeAccessoryType> PipeAccessoryTypes { get; set; }
        public virtual ICollection<PipeConnectionType> PipeConnectionTypes { get; set; }
        public virtual ICollection<PipeFittingType> PipeFittingTypes { get; set; }
        public virtual ICollection<PipeInsulationType> PipeInsulationTypes { get; set; }
        public virtual ICollection<PipeMaterialType> PipeMaterialTypes { get; set; }
        public virtual ICollection<PipeScheduleType> PipeScheduleTypes { get; set; }
        public virtual ICollection<PipeType> PipeTypes { get; set; }
        public virtual ICollection<PlantingType> PlantingTypes { get; set; }
        public virtual ICollection<PlumbingFixtureType> PlumbingFixtureTypes { get; set; }
        public virtual ICollection<Profile> Profiles { get; set; }
        public virtual ICollection<PropertyLineType> PropertyLineTypes { get; set; }
        public virtual ICollection<RailingType> RailingTypes { get; set; }
        public virtual ICollection<RampType> RampTypes { get; set; }
        public virtual ICollection<RoofType> RoofTypes { get; set; }
        public virtual ICollection<SecurityDeviceType> SecurityDeviceTypes { get; set; }
        public virtual ICollection<SiteType> SiteTypes { get; set; }
        public virtual ICollection<SlabEdgeType> SlabEdgeTypes { get; set; }
        public virtual ICollection<SpecialtyEquipmentType> SpecialtyEquipmentTypes { get; set; }
        public virtual ICollection<SprinklerType> SprinklerTypes { get; set; }
        public virtual ICollection<StairType> StairTypes { get; set; }
        public virtual ICollection<StructuralColumnType> StructuralColumnTypes { get; set; }
        public virtual ICollection<StructuralFabricReinforcementType> StructuralFabricReinforcementTypes { get; set; }
        public virtual ICollection<StructuralFoundationType> StructuralFoundationTypes { get; set; }
        public virtual ICollection<StructuralFramingType> StructuralFramingTypes { get; set; }
        public virtual ICollection<StructuralRebarBarType> StructuralRebarBarTypes { get; set; }
        public virtual ICollection<StructuralRebarHookType> StructuralRebarHookTypes { get; set; }
        public virtual ICollection<StructuralRebarShape> StructuralRebarShapes { get; set; }
        public virtual ICollection<StructuralStiffenerType> StructuralStiffenerTypes { get; set; }
        public virtual ICollection<StructuralTrussType> StructuralTrussTypes { get; set; }
        public virtual ICollection<TelephoneDeviceType> TelephoneDeviceTypes { get; set; }
        public virtual ICollection<TopographyType> TopographyTypes { get; set; }
        public virtual ICollection<VoltageType> VoltageTypes { get; set; }
        public virtual ICollection<WallSweepType> WallSweepTypes { get; set; }
        public virtual ICollection<WallType> WallTypes { get; set; }
        public virtual ICollection<WindowType> WindowTypes { get; set; }
        public virtual ICollection<WireInsulationType> WireInsulationTypes { get; set; }
        public virtual ICollection<WireMaterialType> WireMaterialTypes { get; set; }
        public virtual ICollection<WireTemperatureRatingType> WireTemperatureRatingTypes { get; set; }
        public virtual ICollection<WireType> WireTypes { get; set; }
    }
}
