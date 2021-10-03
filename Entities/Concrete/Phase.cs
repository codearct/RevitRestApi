using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class Phase
    {
        public Phase()
        {
            AirTerminalPhaseCreatedNavigations = new HashSet<AirTerminal>();
            AirTerminalPhaseDemolishedNavigations = new HashSet<AirTerminal>();
            AreaLoadPhaseCreatedNavigations = new HashSet<AreaLoad>();
            AreaLoadPhaseDemolishedNavigations = new HashSet<AreaLoad>();
            AssemblyPhaseCreatedNavigations = new HashSet<Assembly>();
            AssemblyPhaseDemolishedNavigations = new HashSet<Assembly>();
            CableTrayFittingPhaseCreatedNavigations = new HashSet<CableTrayFitting>();
            CableTrayFittingPhaseDemolishedNavigations = new HashSet<CableTrayFitting>();
            CableTrayPhaseCreatedNavigations = new HashSet<CableTray>();
            CableTrayPhaseDemolishedNavigations = new HashSet<CableTray>();
            CaseworkPhaseCreatedNavigations = new HashSet<Casework>();
            CaseworkPhaseDemolishedNavigations = new HashSet<Casework>();
            CeilingPhaseCreatedNavigations = new HashSet<Ceiling>();
            CeilingPhaseDemolishedNavigations = new HashSet<Ceiling>();
            Columns1PhaseCreatedNavigations = new HashSet<Columns1>();
            Columns1PhaseDemolishedNavigations = new HashSet<Columns1>();
            CommunicationDevicePhaseCreatedNavigations = new HashSet<CommunicationDevice>();
            CommunicationDevicePhaseDemolishedNavigations = new HashSet<CommunicationDevice>();
            ConduitFittingPhaseCreatedNavigations = new HashSet<ConduitFitting>();
            ConduitFittingPhaseDemolishedNavigations = new HashSet<ConduitFitting>();
            ConduitPhaseCreatedNavigations = new HashSet<Conduit>();
            ConduitPhaseDemolishedNavigations = new HashSet<Conduit>();
            ConstructionPhaseCreatedNavigations = new HashSet<Construction>();
            ConstructionPhaseDemolishedNavigations = new HashSet<Construction>();
            CurtainPanelPhaseCreatedNavigations = new HashSet<CurtainPanel>();
            CurtainPanelPhaseDemolishedNavigations = new HashSet<CurtainPanel>();
            CurtainSystemPhaseCreatedNavigations = new HashSet<CurtainSystem>();
            CurtainSystemPhaseDemolishedNavigations = new HashSet<CurtainSystem>();
            CurtainWallMullionPhaseCreatedNavigations = new HashSet<CurtainWallMullion>();
            CurtainWallMullionPhaseDemolishedNavigations = new HashSet<CurtainWallMullion>();
            DataDevicePhaseCreatedNavigations = new HashSet<DataDevice>();
            DataDevicePhaseDemolishedNavigations = new HashSet<DataDevice>();
            DemandFactorPhaseCreatedNavigations = new HashSet<DemandFactor>();
            DemandFactorPhaseDemolishedNavigations = new HashSet<DemandFactor>();
            DistributionSystemPhaseCreatedNavigations = new HashSet<DistributionSystem>();
            DistributionSystemPhaseDemolishedNavigations = new HashSet<DistributionSystem>();
            DoorPhaseCreatedNavigations = new HashSet<Door>();
            DoorPhaseDemolishedNavigations = new HashSet<Door>();
            DuctAccessoryPhaseCreatedNavigations = new HashSet<DuctAccessory>();
            DuctAccessoryPhaseDemolishedNavigations = new HashSet<DuctAccessory>();
            DuctFittingPhaseCreatedNavigations = new HashSet<DuctFitting>();
            DuctFittingPhaseDemolishedNavigations = new HashSet<DuctFitting>();
            DuctInsulationPhaseCreatedNavigations = new HashSet<DuctInsulation>();
            DuctInsulationPhaseDemolishedNavigations = new HashSet<DuctInsulation>();
            DuctLiningPhaseCreatedNavigations = new HashSet<DuctLining>();
            DuctLiningPhaseDemolishedNavigations = new HashSet<DuctLining>();
            DuctPhaseCreatedNavigations = new HashSet<Duct>();
            DuctPhaseDemolishedNavigations = new HashSet<Duct>();
            DuctPlaceholderPhaseCreatedNavigations = new HashSet<DuctPlaceholder>();
            DuctPlaceholderPhaseDemolishedNavigations = new HashSet<DuctPlaceholder>();
            ElectricalEquipmentPhaseCreatedNavigations = new HashSet<ElectricalEquipment>();
            ElectricalEquipmentPhaseDemolishedNavigations = new HashSet<ElectricalEquipment>();
            ElectricalFixturePhaseCreatedNavigations = new HashSet<ElectricalFixture>();
            ElectricalFixturePhaseDemolishedNavigations = new HashSet<ElectricalFixture>();
            ElementPhases = new HashSet<ElementPhase>();
            FasciaPhaseCreatedNavigations = new HashSet<Fascia>();
            FasciaPhaseDemolishedNavigations = new HashSet<Fascia>();
            FireAlarmDevicePhaseCreatedNavigations = new HashSet<FireAlarmDevice>();
            FireAlarmDevicePhaseDemolishedNavigations = new HashSet<FireAlarmDevice>();
            FlexDuctPhaseCreatedNavigations = new HashSet<FlexDuct>();
            FlexDuctPhaseDemolishedNavigations = new HashSet<FlexDuct>();
            FlexPipePhaseCreatedNavigations = new HashSet<FlexPipe>();
            FlexPipePhaseDemolishedNavigations = new HashSet<FlexPipe>();
            FloorPhaseCreatedNavigations = new HashSet<Floor>();
            FloorPhaseDemolishedNavigations = new HashSet<Floor>();
            FluidPhaseCreatedNavigations = new HashSet<Fluid>();
            FluidPhaseDemolishedNavigations = new HashSet<Fluid>();
            FurniturePhaseCreatedNavigations = new HashSet<Furniture>();
            FurniturePhaseDemolishedNavigations = new HashSet<Furniture>();
            FurnitureSystemPhaseCreatedNavigations = new HashSet<FurnitureSystem>();
            FurnitureSystemPhaseDemolishedNavigations = new HashSet<FurnitureSystem>();
            GenericModelPhaseCreatedNavigations = new HashSet<GenericModel>();
            GenericModelPhaseDemolishedNavigations = new HashSet<GenericModel>();
            GutterPhaseCreatedNavigations = new HashSet<Gutter>();
            GutterPhaseDemolishedNavigations = new HashSet<Gutter>();
            InternalAreaLoadPhaseCreatedNavigations = new HashSet<InternalAreaLoad>();
            InternalAreaLoadPhaseDemolishedNavigations = new HashSet<InternalAreaLoad>();
            InternalLineLoadPhaseCreatedNavigations = new HashSet<InternalLineLoad>();
            InternalLineLoadPhaseDemolishedNavigations = new HashSet<InternalLineLoad>();
            InternalPointLoadPhaseCreatedNavigations = new HashSet<InternalPointLoad>();
            InternalPointLoadPhaseDemolishedNavigations = new HashSet<InternalPointLoad>();
            LightingDevicePhaseCreatedNavigations = new HashSet<LightingDevice>();
            LightingDevicePhaseDemolishedNavigations = new HashSet<LightingDevice>();
            LightingFixturePhaseCreatedNavigations = new HashSet<LightingFixture>();
            LightingFixturePhaseDemolishedNavigations = new HashSet<LightingFixture>();
            LineLoadPhaseCreatedNavigations = new HashSet<LineLoad>();
            LineLoadPhaseDemolishedNavigations = new HashSet<LineLoad>();
            MassExteriorWallPhaseCreatedNavigations = new HashSet<MassExteriorWall>();
            MassExteriorWallPhaseDemolishedNavigations = new HashSet<MassExteriorWall>();
            MassFloorPhaseCreatedNavigations = new HashSet<MassFloor>();
            MassFloorPhaseDemolishedNavigations = new HashSet<MassFloor>();
            MassGlazingPhaseCreatedNavigations = new HashSet<MassGlazing>();
            MassGlazingPhaseDemolishedNavigations = new HashSet<MassGlazing>();
            MassInteriorWallPhaseCreatedNavigations = new HashSet<MassInteriorWall>();
            MassInteriorWallPhaseDemolishedNavigations = new HashSet<MassInteriorWall>();
            MassOpeningPhaseCreatedNavigations = new HashSet<MassOpening>();
            MassOpeningPhaseDemolishedNavigations = new HashSet<MassOpening>();
            MassPhaseCreatedNavigations = new HashSet<Mass>();
            MassPhaseDemolishedNavigations = new HashSet<Mass>();
            MassRoofPhaseCreatedNavigations = new HashSet<MassRoof>();
            MassRoofPhaseDemolishedNavigations = new HashSet<MassRoof>();
            MassSkylightPhaseCreatedNavigations = new HashSet<MassSkylight>();
            MassSkylightPhaseDemolishedNavigations = new HashSet<MassSkylight>();
            MechanicalEquipmentPhaseCreatedNavigations = new HashSet<MechanicalEquipment>();
            MechanicalEquipmentPhaseDemolishedNavigations = new HashSet<MechanicalEquipment>();
            NurseCallDevicePhaseCreatedNavigations = new HashSet<NurseCallDevice>();
            NurseCallDevicePhaseDemolishedNavigations = new HashSet<NurseCallDevice>();
            ParkingPhaseCreatedNavigations = new HashSet<Parking>();
            ParkingPhaseDemolishedNavigations = new HashSet<Parking>();
            PipeAccessoryPhaseCreatedNavigations = new HashSet<PipeAccessory>();
            PipeAccessoryPhaseDemolishedNavigations = new HashSet<PipeAccessory>();
            PipeConnectionPhaseCreatedNavigations = new HashSet<PipeConnection>();
            PipeConnectionPhaseDemolishedNavigations = new HashSet<PipeConnection>();
            PipeFittingPhaseCreatedNavigations = new HashSet<PipeFitting>();
            PipeFittingPhaseDemolishedNavigations = new HashSet<PipeFitting>();
            PipeInsulationPhaseCreatedNavigations = new HashSet<PipeInsulation>();
            PipeInsulationPhaseDemolishedNavigations = new HashSet<PipeInsulation>();
            PipeMaterialPhaseCreatedNavigations = new HashSet<PipeMaterial>();
            PipeMaterialPhaseDemolishedNavigations = new HashSet<PipeMaterial>();
            PipePhaseCreatedNavigations = new HashSet<Pipe>();
            PipePhaseDemolishedNavigations = new HashSet<Pipe>();
            PipePlaceholderPhaseCreatedNavigations = new HashSet<PipePlaceholder>();
            PipePlaceholderPhaseDemolishedNavigations = new HashSet<PipePlaceholder>();
            PipeSchedulePhaseCreatedNavigations = new HashSet<PipeSchedule>();
            PipeSchedulePhaseDemolishedNavigations = new HashSet<PipeSchedule>();
            PlantingPhaseCreatedNavigations = new HashSet<Planting>();
            PlantingPhaseDemolishedNavigations = new HashSet<Planting>();
            PlumbingFixturePhaseCreatedNavigations = new HashSet<PlumbingFixture>();
            PlumbingFixturePhaseDemolishedNavigations = new HashSet<PlumbingFixture>();
            PointLoadPhaseCreatedNavigations = new HashSet<PointLoad>();
            PointLoadPhaseDemolishedNavigations = new HashSet<PointLoad>();
            RailingPhaseCreatedNavigations = new HashSet<Railing>();
            RailingPhaseDemolishedNavigations = new HashSet<Railing>();
            RampPhaseCreatedNavigations = new HashSet<Ramp>();
            RampPhaseDemolishedNavigations = new HashSet<Ramp>();
            RoofPhaseCreatedNavigations = new HashSet<Roof>();
            RoofPhaseDemolishedNavigations = new HashSet<Roof>();
            RoomAssociations = new HashSet<RoomAssociation>();
            RoomFromToAssociations = new HashSet<RoomFromToAssociation>();
            Rooms = new HashSet<Room>();
            SecurityDevicePhaseCreatedNavigations = new HashSet<SecurityDevice>();
            SecurityDevicePhaseDemolishedNavigations = new HashSet<SecurityDevice>();
            SitePhaseCreatedNavigations = new HashSet<Site>();
            SitePhaseDemolishedNavigations = new HashSet<Site>();
            SlabEdgePhaseCreatedNavigations = new HashSet<SlabEdge>();
            SlabEdgePhaseDemolishedNavigations = new HashSet<SlabEdge>();
            SpaceAssociations = new HashSet<SpaceAssociation>();
            Spaces = new HashSet<Space>();
            SpecialtyEquipmentPhaseCreatedNavigations = new HashSet<SpecialtyEquipment>();
            SpecialtyEquipmentPhaseDemolishedNavigations = new HashSet<SpecialtyEquipment>();
            SprinklerPhaseCreatedNavigations = new HashSet<Sprinkler>();
            SprinklerPhaseDemolishedNavigations = new HashSet<Sprinkler>();
            StairPhaseCreatedNavigations = new HashSet<Stair>();
            StairPhaseDemolishedNavigations = new HashSet<Stair>();
            StructuralColumnPhaseCreatedNavigations = new HashSet<StructuralColumn>();
            StructuralColumnPhaseDemolishedNavigations = new HashSet<StructuralColumn>();
            StructuralFabricReinforcementPhaseCreatedNavigations = new HashSet<StructuralFabricReinforcement>();
            StructuralFabricReinforcementPhaseDemolishedNavigations = new HashSet<StructuralFabricReinforcement>();
            StructuralFoundationPhaseCreatedNavigations = new HashSet<StructuralFoundation>();
            StructuralFoundationPhaseDemolishedNavigations = new HashSet<StructuralFoundation>();
            StructuralFramingPhaseCreatedNavigations = new HashSet<StructuralFraming>();
            StructuralFramingPhaseDemolishedNavigations = new HashSet<StructuralFraming>();
            StructuralRebarPhaseCreatedNavigations = new HashSet<StructuralRebar>();
            StructuralRebarPhaseDemolishedNavigations = new HashSet<StructuralRebar>();
            StructuralStiffenerPhaseCreatedNavigations = new HashSet<StructuralStiffener>();
            StructuralStiffenerPhaseDemolishedNavigations = new HashSet<StructuralStiffener>();
            StructuralTrussPhaseCreatedNavigations = new HashSet<StructuralTruss>();
            StructuralTrussPhaseDemolishedNavigations = new HashSet<StructuralTruss>();
            TelephoneDevicePhaseCreatedNavigations = new HashSet<TelephoneDevice>();
            TelephoneDevicePhaseDemolishedNavigations = new HashSet<TelephoneDevice>();
            TopographyPhaseCreatedNavigations = new HashSet<Topography>();
            TopographyPhaseDemolishedNavigations = new HashSet<Topography>();
            Views = new HashSet<View>();
            VoltagePhaseCreatedNavigations = new HashSet<Voltage>();
            VoltagePhaseDemolishedNavigations = new HashSet<Voltage>();
            WallPhaseCreatedNavigations = new HashSet<Wall>();
            WallPhaseDemolishedNavigations = new HashSet<Wall>();
            WallSweepPhaseCreatedNavigations = new HashSet<WallSweep>();
            WallSweepPhaseDemolishedNavigations = new HashSet<WallSweep>();
            WindowPhaseCreatedNavigations = new HashSet<Window>();
            WindowPhaseDemolishedNavigations = new HashSet<Window>();
            WireInsulationPhaseCreatedNavigations = new HashSet<WireInsulation>();
            WireInsulationPhaseDemolishedNavigations = new HashSet<WireInsulation>();
            WireMaterialPhaseCreatedNavigations = new HashSet<WireMaterial>();
            WireMaterialPhaseDemolishedNavigations = new HashSet<WireMaterial>();
            WirePhaseCreatedNavigations = new HashSet<Wire>();
            WirePhaseDemolishedNavigations = new HashSet<Wire>();
            WireTemperatureRatingPhaseCreatedNavigations = new HashSet<WireTemperatureRating>();
            WireTemperatureRatingPhaseDemolishedNavigations = new HashSet<WireTemperatureRating>();
        }

        public int Id { get; set; }
        public int? SequenceNumber { get; set; }
        public string Name { get; set; }

        public virtual ICollection<AirTerminal> AirTerminalPhaseCreatedNavigations { get; set; }
        public virtual ICollection<AirTerminal> AirTerminalPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<AreaLoad> AreaLoadPhaseCreatedNavigations { get; set; }
        public virtual ICollection<AreaLoad> AreaLoadPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<Assembly> AssemblyPhaseCreatedNavigations { get; set; }
        public virtual ICollection<Assembly> AssemblyPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<CableTrayFitting> CableTrayFittingPhaseCreatedNavigations { get; set; }
        public virtual ICollection<CableTrayFitting> CableTrayFittingPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<CableTray> CableTrayPhaseCreatedNavigations { get; set; }
        public virtual ICollection<CableTray> CableTrayPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<Casework> CaseworkPhaseCreatedNavigations { get; set; }
        public virtual ICollection<Casework> CaseworkPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<Ceiling> CeilingPhaseCreatedNavigations { get; set; }
        public virtual ICollection<Ceiling> CeilingPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<Columns1> Columns1PhaseCreatedNavigations { get; set; }
        public virtual ICollection<Columns1> Columns1PhaseDemolishedNavigations { get; set; }
        public virtual ICollection<CommunicationDevice> CommunicationDevicePhaseCreatedNavigations { get; set; }
        public virtual ICollection<CommunicationDevice> CommunicationDevicePhaseDemolishedNavigations { get; set; }
        public virtual ICollection<ConduitFitting> ConduitFittingPhaseCreatedNavigations { get; set; }
        public virtual ICollection<ConduitFitting> ConduitFittingPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<Conduit> ConduitPhaseCreatedNavigations { get; set; }
        public virtual ICollection<Conduit> ConduitPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<Construction> ConstructionPhaseCreatedNavigations { get; set; }
        public virtual ICollection<Construction> ConstructionPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<CurtainPanel> CurtainPanelPhaseCreatedNavigations { get; set; }
        public virtual ICollection<CurtainPanel> CurtainPanelPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<CurtainSystem> CurtainSystemPhaseCreatedNavigations { get; set; }
        public virtual ICollection<CurtainSystem> CurtainSystemPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<CurtainWallMullion> CurtainWallMullionPhaseCreatedNavigations { get; set; }
        public virtual ICollection<CurtainWallMullion> CurtainWallMullionPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<DataDevice> DataDevicePhaseCreatedNavigations { get; set; }
        public virtual ICollection<DataDevice> DataDevicePhaseDemolishedNavigations { get; set; }
        public virtual ICollection<DemandFactor> DemandFactorPhaseCreatedNavigations { get; set; }
        public virtual ICollection<DemandFactor> DemandFactorPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<DistributionSystem> DistributionSystemPhaseCreatedNavigations { get; set; }
        public virtual ICollection<DistributionSystem> DistributionSystemPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<Door> DoorPhaseCreatedNavigations { get; set; }
        public virtual ICollection<Door> DoorPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<DuctAccessory> DuctAccessoryPhaseCreatedNavigations { get; set; }
        public virtual ICollection<DuctAccessory> DuctAccessoryPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<DuctFitting> DuctFittingPhaseCreatedNavigations { get; set; }
        public virtual ICollection<DuctFitting> DuctFittingPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<DuctInsulation> DuctInsulationPhaseCreatedNavigations { get; set; }
        public virtual ICollection<DuctInsulation> DuctInsulationPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<DuctLining> DuctLiningPhaseCreatedNavigations { get; set; }
        public virtual ICollection<DuctLining> DuctLiningPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<Duct> DuctPhaseCreatedNavigations { get; set; }
        public virtual ICollection<Duct> DuctPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<DuctPlaceholder> DuctPlaceholderPhaseCreatedNavigations { get; set; }
        public virtual ICollection<DuctPlaceholder> DuctPlaceholderPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<ElectricalEquipment> ElectricalEquipmentPhaseCreatedNavigations { get; set; }
        public virtual ICollection<ElectricalEquipment> ElectricalEquipmentPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<ElectricalFixture> ElectricalFixturePhaseCreatedNavigations { get; set; }
        public virtual ICollection<ElectricalFixture> ElectricalFixturePhaseDemolishedNavigations { get; set; }
        public virtual ICollection<ElementPhase> ElementPhases { get; set; }
        public virtual ICollection<Fascia> FasciaPhaseCreatedNavigations { get; set; }
        public virtual ICollection<Fascia> FasciaPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<FireAlarmDevice> FireAlarmDevicePhaseCreatedNavigations { get; set; }
        public virtual ICollection<FireAlarmDevice> FireAlarmDevicePhaseDemolishedNavigations { get; set; }
        public virtual ICollection<FlexDuct> FlexDuctPhaseCreatedNavigations { get; set; }
        public virtual ICollection<FlexDuct> FlexDuctPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<FlexPipe> FlexPipePhaseCreatedNavigations { get; set; }
        public virtual ICollection<FlexPipe> FlexPipePhaseDemolishedNavigations { get; set; }
        public virtual ICollection<Floor> FloorPhaseCreatedNavigations { get; set; }
        public virtual ICollection<Floor> FloorPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<Fluid> FluidPhaseCreatedNavigations { get; set; }
        public virtual ICollection<Fluid> FluidPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<Furniture> FurniturePhaseCreatedNavigations { get; set; }
        public virtual ICollection<Furniture> FurniturePhaseDemolishedNavigations { get; set; }
        public virtual ICollection<FurnitureSystem> FurnitureSystemPhaseCreatedNavigations { get; set; }
        public virtual ICollection<FurnitureSystem> FurnitureSystemPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<GenericModel> GenericModelPhaseCreatedNavigations { get; set; }
        public virtual ICollection<GenericModel> GenericModelPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<Gutter> GutterPhaseCreatedNavigations { get; set; }
        public virtual ICollection<Gutter> GutterPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<InternalAreaLoad> InternalAreaLoadPhaseCreatedNavigations { get; set; }
        public virtual ICollection<InternalAreaLoad> InternalAreaLoadPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<InternalLineLoad> InternalLineLoadPhaseCreatedNavigations { get; set; }
        public virtual ICollection<InternalLineLoad> InternalLineLoadPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<InternalPointLoad> InternalPointLoadPhaseCreatedNavigations { get; set; }
        public virtual ICollection<InternalPointLoad> InternalPointLoadPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<LightingDevice> LightingDevicePhaseCreatedNavigations { get; set; }
        public virtual ICollection<LightingDevice> LightingDevicePhaseDemolishedNavigations { get; set; }
        public virtual ICollection<LightingFixture> LightingFixturePhaseCreatedNavigations { get; set; }
        public virtual ICollection<LightingFixture> LightingFixturePhaseDemolishedNavigations { get; set; }
        public virtual ICollection<LineLoad> LineLoadPhaseCreatedNavigations { get; set; }
        public virtual ICollection<LineLoad> LineLoadPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<MassExteriorWall> MassExteriorWallPhaseCreatedNavigations { get; set; }
        public virtual ICollection<MassExteriorWall> MassExteriorWallPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<MassFloor> MassFloorPhaseCreatedNavigations { get; set; }
        public virtual ICollection<MassFloor> MassFloorPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<MassGlazing> MassGlazingPhaseCreatedNavigations { get; set; }
        public virtual ICollection<MassGlazing> MassGlazingPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<MassInteriorWall> MassInteriorWallPhaseCreatedNavigations { get; set; }
        public virtual ICollection<MassInteriorWall> MassInteriorWallPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<MassOpening> MassOpeningPhaseCreatedNavigations { get; set; }
        public virtual ICollection<MassOpening> MassOpeningPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<Mass> MassPhaseCreatedNavigations { get; set; }
        public virtual ICollection<Mass> MassPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<MassRoof> MassRoofPhaseCreatedNavigations { get; set; }
        public virtual ICollection<MassRoof> MassRoofPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<MassSkylight> MassSkylightPhaseCreatedNavigations { get; set; }
        public virtual ICollection<MassSkylight> MassSkylightPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<MechanicalEquipment> MechanicalEquipmentPhaseCreatedNavigations { get; set; }
        public virtual ICollection<MechanicalEquipment> MechanicalEquipmentPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<NurseCallDevice> NurseCallDevicePhaseCreatedNavigations { get; set; }
        public virtual ICollection<NurseCallDevice> NurseCallDevicePhaseDemolishedNavigations { get; set; }
        public virtual ICollection<Parking> ParkingPhaseCreatedNavigations { get; set; }
        public virtual ICollection<Parking> ParkingPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<PipeAccessory> PipeAccessoryPhaseCreatedNavigations { get; set; }
        public virtual ICollection<PipeAccessory> PipeAccessoryPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<PipeConnection> PipeConnectionPhaseCreatedNavigations { get; set; }
        public virtual ICollection<PipeConnection> PipeConnectionPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<PipeFitting> PipeFittingPhaseCreatedNavigations { get; set; }
        public virtual ICollection<PipeFitting> PipeFittingPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<PipeInsulation> PipeInsulationPhaseCreatedNavigations { get; set; }
        public virtual ICollection<PipeInsulation> PipeInsulationPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<PipeMaterial> PipeMaterialPhaseCreatedNavigations { get; set; }
        public virtual ICollection<PipeMaterial> PipeMaterialPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<Pipe> PipePhaseCreatedNavigations { get; set; }
        public virtual ICollection<Pipe> PipePhaseDemolishedNavigations { get; set; }
        public virtual ICollection<PipePlaceholder> PipePlaceholderPhaseCreatedNavigations { get; set; }
        public virtual ICollection<PipePlaceholder> PipePlaceholderPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<PipeSchedule> PipeSchedulePhaseCreatedNavigations { get; set; }
        public virtual ICollection<PipeSchedule> PipeSchedulePhaseDemolishedNavigations { get; set; }
        public virtual ICollection<Planting> PlantingPhaseCreatedNavigations { get; set; }
        public virtual ICollection<Planting> PlantingPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<PlumbingFixture> PlumbingFixturePhaseCreatedNavigations { get; set; }
        public virtual ICollection<PlumbingFixture> PlumbingFixturePhaseDemolishedNavigations { get; set; }
        public virtual ICollection<PointLoad> PointLoadPhaseCreatedNavigations { get; set; }
        public virtual ICollection<PointLoad> PointLoadPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<Railing> RailingPhaseCreatedNavigations { get; set; }
        public virtual ICollection<Railing> RailingPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<Ramp> RampPhaseCreatedNavigations { get; set; }
        public virtual ICollection<Ramp> RampPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<Roof> RoofPhaseCreatedNavigations { get; set; }
        public virtual ICollection<Roof> RoofPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<RoomAssociation> RoomAssociations { get; set; }
        public virtual ICollection<RoomFromToAssociation> RoomFromToAssociations { get; set; }
        public virtual ICollection<Room> Rooms { get; set; }
        public virtual ICollection<SecurityDevice> SecurityDevicePhaseCreatedNavigations { get; set; }
        public virtual ICollection<SecurityDevice> SecurityDevicePhaseDemolishedNavigations { get; set; }
        public virtual ICollection<Site> SitePhaseCreatedNavigations { get; set; }
        public virtual ICollection<Site> SitePhaseDemolishedNavigations { get; set; }
        public virtual ICollection<SlabEdge> SlabEdgePhaseCreatedNavigations { get; set; }
        public virtual ICollection<SlabEdge> SlabEdgePhaseDemolishedNavigations { get; set; }
        public virtual ICollection<SpaceAssociation> SpaceAssociations { get; set; }
        public virtual ICollection<Space> Spaces { get; set; }
        public virtual ICollection<SpecialtyEquipment> SpecialtyEquipmentPhaseCreatedNavigations { get; set; }
        public virtual ICollection<SpecialtyEquipment> SpecialtyEquipmentPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<Sprinkler> SprinklerPhaseCreatedNavigations { get; set; }
        public virtual ICollection<Sprinkler> SprinklerPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<Stair> StairPhaseCreatedNavigations { get; set; }
        public virtual ICollection<Stair> StairPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<StructuralColumn> StructuralColumnPhaseCreatedNavigations { get; set; }
        public virtual ICollection<StructuralColumn> StructuralColumnPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<StructuralFabricReinforcement> StructuralFabricReinforcementPhaseCreatedNavigations { get; set; }
        public virtual ICollection<StructuralFabricReinforcement> StructuralFabricReinforcementPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<StructuralFoundation> StructuralFoundationPhaseCreatedNavigations { get; set; }
        public virtual ICollection<StructuralFoundation> StructuralFoundationPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<StructuralFraming> StructuralFramingPhaseCreatedNavigations { get; set; }
        public virtual ICollection<StructuralFraming> StructuralFramingPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<StructuralRebar> StructuralRebarPhaseCreatedNavigations { get; set; }
        public virtual ICollection<StructuralRebar> StructuralRebarPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<StructuralStiffener> StructuralStiffenerPhaseCreatedNavigations { get; set; }
        public virtual ICollection<StructuralStiffener> StructuralStiffenerPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<StructuralTruss> StructuralTrussPhaseCreatedNavigations { get; set; }
        public virtual ICollection<StructuralTruss> StructuralTrussPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<TelephoneDevice> TelephoneDevicePhaseCreatedNavigations { get; set; }
        public virtual ICollection<TelephoneDevice> TelephoneDevicePhaseDemolishedNavigations { get; set; }
        public virtual ICollection<Topography> TopographyPhaseCreatedNavigations { get; set; }
        public virtual ICollection<Topography> TopographyPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<View> Views { get; set; }
        public virtual ICollection<Voltage> VoltagePhaseCreatedNavigations { get; set; }
        public virtual ICollection<Voltage> VoltagePhaseDemolishedNavigations { get; set; }
        public virtual ICollection<Wall> WallPhaseCreatedNavigations { get; set; }
        public virtual ICollection<Wall> WallPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<WallSweep> WallSweepPhaseCreatedNavigations { get; set; }
        public virtual ICollection<WallSweep> WallSweepPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<Window> WindowPhaseCreatedNavigations { get; set; }
        public virtual ICollection<Window> WindowPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<WireInsulation> WireInsulationPhaseCreatedNavigations { get; set; }
        public virtual ICollection<WireInsulation> WireInsulationPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<WireMaterial> WireMaterialPhaseCreatedNavigations { get; set; }
        public virtual ICollection<WireMaterial> WireMaterialPhaseDemolishedNavigations { get; set; }
        public virtual ICollection<Wire> WirePhaseCreatedNavigations { get; set; }
        public virtual ICollection<Wire> WirePhaseDemolishedNavigations { get; set; }
        public virtual ICollection<WireTemperatureRating> WireTemperatureRatingPhaseCreatedNavigations { get; set; }
        public virtual ICollection<WireTemperatureRating> WireTemperatureRatingPhaseDemolishedNavigations { get; set; }
    }
}
