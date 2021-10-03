using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class DesignOption
    {
        public DesignOption()
        {
            AirTerminals = new HashSet<AirTerminal>();
            AreaLoads = new HashSet<AreaLoad>();
            Assemblies = new HashSet<Assembly>();
            BuildingTypeSettings = new HashSet<BuildingTypeSetting>();
            CableTrayFittings = new HashSet<CableTrayFitting>();
            CableTrays = new HashSet<CableTray>();
            Caseworks = new HashSet<Casework>();
            Ceilings = new HashSet<Ceiling>();
            Columns1s = new HashSet<Columns1>();
            CommunicationDevices = new HashSet<CommunicationDevice>();
            ConduitFittings = new HashSet<ConduitFitting>();
            Conduits = new HashSet<Conduit>();
            Constructions = new HashSet<Construction>();
            CurtainPanels = new HashSet<CurtainPanel>();
            CurtainSystems = new HashSet<CurtainSystem>();
            CurtainWallMullions = new HashSet<CurtainWallMullion>();
            DataDevices = new HashSet<DataDevice>();
            DemandFactors = new HashSet<DemandFactor>();
            DesignOptionSets = new HashSet<DesignOptionSet>();
            DistributionSystems = new HashSet<DistributionSystem>();
            Doors = new HashSet<Door>();
            DuctAccessories = new HashSet<DuctAccessory>();
            DuctFittings = new HashSet<DuctFitting>();
            DuctInsulations = new HashSet<DuctInsulation>();
            DuctLinings = new HashSet<DuctLining>();
            DuctPlaceholders = new HashSet<DuctPlaceholder>();
            DuctSystems = new HashSet<DuctSystem>();
            Ducts = new HashSet<Duct>();
            ElectricalCircuits = new HashSet<ElectricalCircuit>();
            ElectricalDemandFactorDefinitions = new HashSet<ElectricalDemandFactorDefinition>();
            ElectricalEquipments = new HashSet<ElectricalEquipment>();
            ElectricalFixtures = new HashSet<ElectricalFixture>();
            ElectricalLoadClassificationParameterElements = new HashSet<ElectricalLoadClassificationParameterElement>();
            ElectricalLoadClassifications = new HashSet<ElectricalLoadClassification>();
            Fascia = new HashSet<Fascia>();
            FireAlarmDevices = new HashSet<FireAlarmDevice>();
            FlexDucts = new HashSet<FlexDuct>();
            FlexPipes = new HashSet<FlexPipe>();
            Floors = new HashSet<Floor>();
            Fluids = new HashSet<Fluid>();
            FurnitureSystems = new HashSet<FurnitureSystem>();
            Furnitures = new HashSet<Furniture>();
            GenericModels = new HashSet<GenericModel>();
            Gutters = new HashSet<Gutter>();
            HvacloadSchedules = new HashSet<HvacloadSchedule>();
            Hvaczones = new HashSet<Hvaczone>();
            InternalAreaLoads = new HashSet<InternalAreaLoad>();
            InternalLineLoads = new HashSet<InternalLineLoad>();
            InternalPointLoads = new HashSet<InternalPointLoad>();
            Levels = new HashSet<Level>();
            LightingDevices = new HashSet<LightingDevice>();
            LightingFixtures = new HashSet<LightingFixture>();
            LineLoads = new HashSet<LineLoad>();
            MassExteriorWalls = new HashSet<MassExteriorWall>();
            MassFloors = new HashSet<MassFloor>();
            MassGlazings = new HashSet<MassGlazing>();
            MassInteriorWalls = new HashSet<MassInteriorWall>();
            MassOpenings = new HashSet<MassOpening>();
            MassRoofs = new HashSet<MassRoof>();
            MassSkylights = new HashSet<MassSkylight>();
            Masses = new HashSet<Mass>();
            MechanicalEquipments = new HashSet<MechanicalEquipment>();
            NurseCallDevices = new HashSet<NurseCallDevice>();
            PanelScheduleTemplatesBranchPanels = new HashSet<PanelScheduleTemplatesBranchPanel>();
            PanelScheduleTemplatesDataPanels = new HashSet<PanelScheduleTemplatesDataPanel>();
            PanelScheduleTemplatesSwitchboards = new HashSet<PanelScheduleTemplatesSwitchboard>();
            Parkings = new HashSet<Parking>();
            PipeAccessories = new HashSet<PipeAccessory>();
            PipeConnections = new HashSet<PipeConnection>();
            PipeFittings = new HashSet<PipeFitting>();
            PipeInsulations = new HashSet<PipeInsulation>();
            PipeMaterials = new HashSet<PipeMaterial>();
            PipePlaceholders = new HashSet<PipePlaceholder>();
            PipeSchedules = new HashSet<PipeSchedule>();
            PipeSegments = new HashSet<PipeSegment>();
            Pipes = new HashSet<Pipe>();
            PipingSystems = new HashSet<PipingSystem>();
            Plantings = new HashSet<Planting>();
            PlumbingFixtures = new HashSet<PlumbingFixture>();
            PointLoads = new HashSet<PointLoad>();
            PropertyLines = new HashSet<PropertyLine>();
            Railings = new HashSet<Railing>();
            Ramps = new HashSet<Ramp>();
            Roofs = new HashSet<Roof>();
            Rooms = new HashSet<Room>();
            SecurityDevices = new HashSet<SecurityDevice>();
            Sites = new HashSet<Site>();
            SlabEdges = new HashSet<SlabEdge>();
            SpaceTypeSettings = new HashSet<SpaceTypeSetting>();
            Spaces = new HashSet<Space>();
            SpecialtyEquipments = new HashSet<SpecialtyEquipment>();
            Sprinklers = new HashSet<Sprinkler>();
            Stairs = new HashSet<Stair>();
            StructuralColumns = new HashSet<StructuralColumn>();
            StructuralFabricReinforcements = new HashSet<StructuralFabricReinforcement>();
            StructuralFoundations = new HashSet<StructuralFoundation>();
            StructuralFramings = new HashSet<StructuralFraming>();
            StructuralRebars = new HashSet<StructuralRebar>();
            StructuralStiffeners = new HashSet<StructuralStiffener>();
            StructuralTrusses = new HashSet<StructuralTruss>();
            SwitchSystems = new HashSet<SwitchSystem>();
            TelephoneDevices = new HashSet<TelephoneDevice>();
            Topographies = new HashSet<Topography>();
            Voltages = new HashSet<Voltage>();
            WallSweeps = new HashSet<WallSweep>();
            Walls = new HashSet<Wall>();
            Windows = new HashSet<Window>();
            WireInsulations = new HashSet<WireInsulation>();
            WireMaterials = new HashSet<WireMaterial>();
            WireTemperatureRatings = new HashSet<WireTemperatureRating>();
            Wires = new HashSet<Wire>();
        }

        public int Id { get; set; }
        public int? DesignOptionSetId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<AirTerminal> AirTerminals { get; set; }
        public virtual ICollection<AreaLoad> AreaLoads { get; set; }
        public virtual ICollection<Assembly> Assemblies { get; set; }
        public virtual ICollection<BuildingTypeSetting> BuildingTypeSettings { get; set; }
        public virtual ICollection<CableTrayFitting> CableTrayFittings { get; set; }
        public virtual ICollection<CableTray> CableTrays { get; set; }
        public virtual ICollection<Casework> Caseworks { get; set; }
        public virtual ICollection<Ceiling> Ceilings { get; set; }
        public virtual ICollection<Columns1> Columns1s { get; set; }
        public virtual ICollection<CommunicationDevice> CommunicationDevices { get; set; }
        public virtual ICollection<ConduitFitting> ConduitFittings { get; set; }
        public virtual ICollection<Conduit> Conduits { get; set; }
        public virtual ICollection<Construction> Constructions { get; set; }
        public virtual ICollection<CurtainPanel> CurtainPanels { get; set; }
        public virtual ICollection<CurtainSystem> CurtainSystems { get; set; }
        public virtual ICollection<CurtainWallMullion> CurtainWallMullions { get; set; }
        public virtual ICollection<DataDevice> DataDevices { get; set; }
        public virtual ICollection<DemandFactor> DemandFactors { get; set; }
        public virtual ICollection<DesignOptionSet> DesignOptionSets { get; set; }
        public virtual ICollection<DistributionSystem> DistributionSystems { get; set; }
        public virtual ICollection<Door> Doors { get; set; }
        public virtual ICollection<DuctAccessory> DuctAccessories { get; set; }
        public virtual ICollection<DuctFitting> DuctFittings { get; set; }
        public virtual ICollection<DuctInsulation> DuctInsulations { get; set; }
        public virtual ICollection<DuctLining> DuctLinings { get; set; }
        public virtual ICollection<DuctPlaceholder> DuctPlaceholders { get; set; }
        public virtual ICollection<DuctSystem> DuctSystems { get; set; }
        public virtual ICollection<Duct> Ducts { get; set; }
        public virtual ICollection<ElectricalCircuit> ElectricalCircuits { get; set; }
        public virtual ICollection<ElectricalDemandFactorDefinition> ElectricalDemandFactorDefinitions { get; set; }
        public virtual ICollection<ElectricalEquipment> ElectricalEquipments { get; set; }
        public virtual ICollection<ElectricalFixture> ElectricalFixtures { get; set; }
        public virtual ICollection<ElectricalLoadClassificationParameterElement> ElectricalLoadClassificationParameterElements { get; set; }
        public virtual ICollection<ElectricalLoadClassification> ElectricalLoadClassifications { get; set; }
        public virtual ICollection<Fascia> Fascia { get; set; }
        public virtual ICollection<FireAlarmDevice> FireAlarmDevices { get; set; }
        public virtual ICollection<FlexDuct> FlexDucts { get; set; }
        public virtual ICollection<FlexPipe> FlexPipes { get; set; }
        public virtual ICollection<Floor> Floors { get; set; }
        public virtual ICollection<Fluid> Fluids { get; set; }
        public virtual ICollection<FurnitureSystem> FurnitureSystems { get; set; }
        public virtual ICollection<Furniture> Furnitures { get; set; }
        public virtual ICollection<GenericModel> GenericModels { get; set; }
        public virtual ICollection<Gutter> Gutters { get; set; }
        public virtual ICollection<HvacloadSchedule> HvacloadSchedules { get; set; }
        public virtual ICollection<Hvaczone> Hvaczones { get; set; }
        public virtual ICollection<InternalAreaLoad> InternalAreaLoads { get; set; }
        public virtual ICollection<InternalLineLoad> InternalLineLoads { get; set; }
        public virtual ICollection<InternalPointLoad> InternalPointLoads { get; set; }
        public virtual ICollection<Level> Levels { get; set; }
        public virtual ICollection<LightingDevice> LightingDevices { get; set; }
        public virtual ICollection<LightingFixture> LightingFixtures { get; set; }
        public virtual ICollection<LineLoad> LineLoads { get; set; }
        public virtual ICollection<MassExteriorWall> MassExteriorWalls { get; set; }
        public virtual ICollection<MassFloor> MassFloors { get; set; }
        public virtual ICollection<MassGlazing> MassGlazings { get; set; }
        public virtual ICollection<MassInteriorWall> MassInteriorWalls { get; set; }
        public virtual ICollection<MassOpening> MassOpenings { get; set; }
        public virtual ICollection<MassRoof> MassRoofs { get; set; }
        public virtual ICollection<MassSkylight> MassSkylights { get; set; }
        public virtual ICollection<Mass> Masses { get; set; }
        public virtual ICollection<MechanicalEquipment> MechanicalEquipments { get; set; }
        public virtual ICollection<NurseCallDevice> NurseCallDevices { get; set; }
        public virtual ICollection<PanelScheduleTemplatesBranchPanel> PanelScheduleTemplatesBranchPanels { get; set; }
        public virtual ICollection<PanelScheduleTemplatesDataPanel> PanelScheduleTemplatesDataPanels { get; set; }
        public virtual ICollection<PanelScheduleTemplatesSwitchboard> PanelScheduleTemplatesSwitchboards { get; set; }
        public virtual ICollection<Parking> Parkings { get; set; }
        public virtual ICollection<PipeAccessory> PipeAccessories { get; set; }
        public virtual ICollection<PipeConnection> PipeConnections { get; set; }
        public virtual ICollection<PipeFitting> PipeFittings { get; set; }
        public virtual ICollection<PipeInsulation> PipeInsulations { get; set; }
        public virtual ICollection<PipeMaterial> PipeMaterials { get; set; }
        public virtual ICollection<PipePlaceholder> PipePlaceholders { get; set; }
        public virtual ICollection<PipeSchedule> PipeSchedules { get; set; }
        public virtual ICollection<PipeSegment> PipeSegments { get; set; }
        public virtual ICollection<Pipe> Pipes { get; set; }
        public virtual ICollection<PipingSystem> PipingSystems { get; set; }
        public virtual ICollection<Planting> Plantings { get; set; }
        public virtual ICollection<PlumbingFixture> PlumbingFixtures { get; set; }
        public virtual ICollection<PointLoad> PointLoads { get; set; }
        public virtual ICollection<PropertyLine> PropertyLines { get; set; }
        public virtual ICollection<Railing> Railings { get; set; }
        public virtual ICollection<Ramp> Ramps { get; set; }
        public virtual ICollection<Roof> Roofs { get; set; }
        public virtual ICollection<Room> Rooms { get; set; }
        public virtual ICollection<SecurityDevice> SecurityDevices { get; set; }
        public virtual ICollection<Site> Sites { get; set; }
        public virtual ICollection<SlabEdge> SlabEdges { get; set; }
        public virtual ICollection<SpaceTypeSetting> SpaceTypeSettings { get; set; }
        public virtual ICollection<Space> Spaces { get; set; }
        public virtual ICollection<SpecialtyEquipment> SpecialtyEquipments { get; set; }
        public virtual ICollection<Sprinkler> Sprinklers { get; set; }
        public virtual ICollection<Stair> Stairs { get; set; }
        public virtual ICollection<StructuralColumn> StructuralColumns { get; set; }
        public virtual ICollection<StructuralFabricReinforcement> StructuralFabricReinforcements { get; set; }
        public virtual ICollection<StructuralFoundation> StructuralFoundations { get; set; }
        public virtual ICollection<StructuralFraming> StructuralFramings { get; set; }
        public virtual ICollection<StructuralRebar> StructuralRebars { get; set; }
        public virtual ICollection<StructuralStiffener> StructuralStiffeners { get; set; }
        public virtual ICollection<StructuralTruss> StructuralTrusses { get; set; }
        public virtual ICollection<SwitchSystem> SwitchSystems { get; set; }
        public virtual ICollection<TelephoneDevice> TelephoneDevices { get; set; }
        public virtual ICollection<Topography> Topographies { get; set; }
        public virtual ICollection<Voltage> Voltages { get; set; }
        public virtual ICollection<WallSweep> WallSweeps { get; set; }
        public virtual ICollection<Wall> Walls { get; set; }
        public virtual ICollection<Window> Windows { get; set; }
        public virtual ICollection<WireInsulation> WireInsulations { get; set; }
        public virtual ICollection<WireMaterial> WireMaterials { get; set; }
        public virtual ICollection<WireTemperatureRating> WireTemperatureRatings { get; set; }
        public virtual ICollection<Wire> Wires { get; set; }
    }
}
