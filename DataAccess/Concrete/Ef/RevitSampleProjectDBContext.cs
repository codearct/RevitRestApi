using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Entities.Concrete;

#nullable disable

namespace DataAccess.Concrete.Ef
{
    public partial class RevitSampleProjectDBContext : DbContext
    {
        public RevitSampleProjectDBContext()
        {
        }

        public RevitSampleProjectDBContext(DbContextOptions<RevitSampleProjectDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AirTerminal> AirTerminals { get; set; }
        public virtual DbSet<AirTerminalType> AirTerminalTypes { get; set; }
        public virtual DbSet<AnalyzesAsTypeEnum> AnalyzesAsTypeEnums { get; set; }
        public virtual DbSet<Area> Areas { get; set; }
        public virtual DbSet<AreaLoad> AreaLoads { get; set; }
        public virtual DbSet<AreaLoadOnSlab> AreaLoadOnSlabs { get; set; }
        public virtual DbSet<AreaScheme> AreaSchemes { get; set; }
        public virtual DbSet<Assembly> Assemblies { get; set; }
        public virtual DbSet<AssemblyCode> AssemblyCodes { get; set; }
        public virtual DbSet<AssemblyType> AssemblyTypes { get; set; }
        public virtual DbSet<BuildingTypeSetting> BuildingTypeSettings { get; set; }
        public virtual DbSet<CableTray> CableTrays { get; set; }
        public virtual DbSet<CableTrayFitting> CableTrayFittings { get; set; }
        public virtual DbSet<CableTrayFittingType> CableTrayFittingTypes { get; set; }
        public virtual DbSet<CableTrayType> CableTrayTypes { get; set; }
        public virtual DbSet<Casework> Caseworks { get; set; }
        public virtual DbSet<CaseworkOnWall> CaseworkOnWalls { get; set; }
        public virtual DbSet<CaseworkType> CaseworkTypes { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Ceiling> Ceilings { get; set; }
        public virtual DbSet<CeilingType> CeilingTypes { get; set; }
        public virtual DbSet<ColumnType> ColumnTypes { get; set; }
        public virtual DbSet<Columns1> Columns1s { get; set; }
        public virtual DbSet<CommunicationDevice> CommunicationDevices { get; set; }
        public virtual DbSet<CommunicationDeviceType> CommunicationDeviceTypes { get; set; }
        public virtual DbSet<ConditionTypeEnum> ConditionTypeEnums { get; set; }
        public virtual DbSet<Conduit> Conduits { get; set; }
        public virtual DbSet<ConduitFitting> ConduitFittings { get; set; }
        public virtual DbSet<ConduitFittingType> ConduitFittingTypes { get; set; }
        public virtual DbSet<ConduitType> ConduitTypes { get; set; }
        public virtual DbSet<Construction> Constructions { get; set; }
        public virtual DbSet<ConstructionType> ConstructionTypes { get; set; }
        public virtual DbSet<CoverType> CoverTypes { get; set; }
        public virtual DbSet<CurtainPanel> CurtainPanels { get; set; }
        public virtual DbSet<CurtainPanelType> CurtainPanelTypes { get; set; }
        public virtual DbSet<CurtainSystem> CurtainSystems { get; set; }
        public virtual DbSet<CurtainSystemType> CurtainSystemTypes { get; set; }
        public virtual DbSet<CurtainWallMullion> CurtainWallMullions { get; set; }
        public virtual DbSet<CurtainWallMullionType> CurtainWallMullionTypes { get; set; }
        public virtual DbSet<CurtainWallPanelOnRoof> CurtainWallPanelOnRoofs { get; set; }
        public virtual DbSet<CurtainWallPanelOnWall> CurtainWallPanelOnWalls { get; set; }
        public virtual DbSet<DataDevice> DataDevices { get; set; }
        public virtual DbSet<DataDeviceType> DataDeviceTypes { get; set; }
        public virtual DbSet<DemandFactor> DemandFactors { get; set; }
        public virtual DbSet<DemandFactorType> DemandFactorTypes { get; set; }
        public virtual DbSet<DesignOption> DesignOptions { get; set; }
        public virtual DbSet<DesignOptionSet> DesignOptionSets { get; set; }
        public virtual DbSet<DistributionSystem> DistributionSystems { get; set; }
        public virtual DbSet<DistributionSystemType> DistributionSystemTypes { get; set; }
        public virtual DbSet<DivisionProfile> DivisionProfiles { get; set; }
        public virtual DbSet<Door> Doors { get; set; }
        public virtual DbSet<DoorType> DoorTypes { get; set; }
        public virtual DbSet<DoorWall> DoorWalls { get; set; }
        public virtual DbSet<Duct> Ducts { get; set; }
        public virtual DbSet<DuctAccessory> DuctAccessories { get; set; }
        public virtual DbSet<DuctAccessoryType> DuctAccessoryTypes { get; set; }
        public virtual DbSet<DuctFitting> DuctFittings { get; set; }
        public virtual DbSet<DuctFittingType> DuctFittingTypes { get; set; }
        public virtual DbSet<DuctInsulation> DuctInsulations { get; set; }
        public virtual DbSet<DuctInsulationType> DuctInsulationTypes { get; set; }
        public virtual DbSet<DuctLining> DuctLinings { get; set; }
        public virtual DbSet<DuctLiningType> DuctLiningTypes { get; set; }
        public virtual DbSet<DuctPlaceholder> DuctPlaceholders { get; set; }
        public virtual DbSet<DuctSystem> DuctSystems { get; set; }
        public virtual DbSet<DuctSystemType> DuctSystemTypes { get; set; }
        public virtual DbSet<DuctSystemTypeEnum> DuctSystemTypeEnums { get; set; }
        public virtual DbSet<DuctType> DuctTypes { get; set; }
        public virtual DbSet<EaveCutterTypeEnum> EaveCutterTypeEnums { get; set; }
        public virtual DbSet<ElectricalCircuit> ElectricalCircuits { get; set; }
        public virtual DbSet<ElectricalDemandFactorDefinition> ElectricalDemandFactorDefinitions { get; set; }
        public virtual DbSet<ElectricalEquipment> ElectricalEquipments { get; set; }
        public virtual DbSet<ElectricalEquipmentType> ElectricalEquipmentTypes { get; set; }
        public virtual DbSet<ElectricalFixture> ElectricalFixtures { get; set; }
        public virtual DbSet<ElectricalFixtureType> ElectricalFixtureTypes { get; set; }
        public virtual DbSet<ElectricalLoadClassification> ElectricalLoadClassifications { get; set; }
        public virtual DbSet<ElectricalLoadClassificationParameterElement> ElectricalLoadClassificationParameterElements { get; set; }
        public virtual DbSet<ElectricalPhaseConfigurationEnum> ElectricalPhaseConfigurationEnums { get; set; }
        public virtual DbSet<ElectricalPhaseEnum> ElectricalPhaseEnums { get; set; }
        public virtual DbSet<ElectricalSystemEnum> ElectricalSystemEnums { get; set; }
        public virtual DbSet<ElementLevel> ElementLevels { get; set; }
        public virtual DbSet<ElementPhase> ElementPhases { get; set; }
        public virtual DbSet<FabricLocationEnum> FabricLocationEnums { get; set; }
        public virtual DbSet<Fascia> Fascias { get; set; }
        public virtual DbSet<FasciaType> FasciaTypes { get; set; }
        public virtual DbSet<FireAlarmDevice> FireAlarmDevices { get; set; }
        public virtual DbSet<FireAlarmDeviceType> FireAlarmDeviceTypes { get; set; }
        public virtual DbSet<FlexDuct> FlexDucts { get; set; }
        public virtual DbSet<FlexDuctType> FlexDuctTypes { get; set; }
        public virtual DbSet<FlexPipe> FlexPipes { get; set; }
        public virtual DbSet<FlexPipeType> FlexPipeTypes { get; set; }
        public virtual DbSet<Floor> Floors { get; set; }
        public virtual DbSet<FloorType> FloorTypes { get; set; }
        public virtual DbSet<Fluid> Fluids { get; set; }
        public virtual DbSet<FluidType> FluidTypes { get; set; }
        public virtual DbSet<Furniture> Furnitures { get; set; }
        public virtual DbSet<FurnitureSystem> FurnitureSystems { get; set; }
        public virtual DbSet<FurnitureSystemType> FurnitureSystemTypes { get; set; }
        public virtual DbSet<FurnitureType> FurnitureTypes { get; set; }
        public virtual DbSet<GenericModel> GenericModels { get; set; }
        public virtual DbSet<GenericModelOnRoof> GenericModelOnRoofs { get; set; }
        public virtual DbSet<GenericModelOnWall> GenericModelOnWalls { get; set; }
        public virtual DbSet<GenericModelType> GenericModelTypes { get; set; }
        public virtual DbSet<Grid> Grids { get; set; }
        public virtual DbSet<GridType> GridTypes { get; set; }
        public virtual DbSet<Gutter> Gutters { get; set; }
        public virtual DbSet<GutterType> GutterTypes { get; set; }
        public virtual DbSet<HvacloadSchedule> HvacloadSchedules { get; set; }
        public virtual DbSet<Hvaczone> Hvaczones { get; set; }
        public virtual DbSet<InstanceUsageEnum> InstanceUsageEnums { get; set; }
        public virtual DbSet<InternalAreaLoad> InternalAreaLoads { get; set; }
        public virtual DbSet<InternalLineLoad> InternalLineLoads { get; set; }
        public virtual DbSet<InternalPointLoad> InternalPointLoads { get; set; }
        public virtual DbSet<Level> Levels { get; set; }
        public virtual DbSet<LevelType> LevelTypes { get; set; }
        public virtual DbSet<LightingDevice> LightingDevices { get; set; }
        public virtual DbSet<LightingDeviceType> LightingDeviceTypes { get; set; }
        public virtual DbSet<LightingFixture> LightingFixtures { get; set; }
        public virtual DbSet<LightingFixtureOnCeiling> LightingFixtureOnCeilings { get; set; }
        public virtual DbSet<LightingFixtureOnWall> LightingFixtureOnWalls { get; set; }
        public virtual DbSet<LightingFixtureType> LightingFixtureTypes { get; set; }
        public virtual DbSet<LineLoad> LineLoads { get; set; }
        public virtual DbSet<LineLoadOnBeam> LineLoadOnBeams { get; set; }
        public virtual DbSet<LoadClassificationTypeEnum> LoadClassificationTypeEnums { get; set; }
        public virtual DbSet<Mass> Masses { get; set; }
        public virtual DbSet<MassExteriorWall> MassExteriorWalls { get; set; }
        public virtual DbSet<MassFloor> MassFloors { get; set; }
        public virtual DbSet<MassGlazing> MassGlazings { get; set; }
        public virtual DbSet<MassInteriorWall> MassInteriorWalls { get; set; }
        public virtual DbSet<MassOpening> MassOpenings { get; set; }
        public virtual DbSet<MassRoof> MassRoofs { get; set; }
        public virtual DbSet<MassSkylight> MassSkylights { get; set; }
        public virtual DbSet<MassType> MassTypes { get; set; }
        public virtual DbSet<Material> Materials { get; set; }
        public virtual DbSet<MaterialQuantity> MaterialQuantities { get; set; }
        public virtual DbSet<MechanicalEquipment> MechanicalEquipments { get; set; }
        public virtual DbSet<MechanicalEquipmentOnWall> MechanicalEquipmentOnWalls { get; set; }
        public virtual DbSet<MechanicalEquipmentType> MechanicalEquipmentTypes { get; set; }
        public virtual DbSet<NeutralModeEnum> NeutralModeEnums { get; set; }
        public virtual DbSet<NurseCallDevice> NurseCallDevices { get; set; }
        public virtual DbSet<NurseCallDeviceType> NurseCallDeviceTypes { get; set; }
        public virtual DbSet<OmniClassNumber> OmniClassNumbers { get; set; }
        public virtual DbSet<Opening> Openings { get; set; }
        public virtual DbSet<OpeningOnFloor> OpeningOnFloors { get; set; }
        public virtual DbSet<OpeningOnWall> OpeningOnWalls { get; set; }
        public virtual DbSet<PanelScheduleTemplatesBranchPanel> PanelScheduleTemplatesBranchPanels { get; set; }
        public virtual DbSet<PanelScheduleTemplatesDataPanel> PanelScheduleTemplatesDataPanels { get; set; }
        public virtual DbSet<PanelScheduleTemplatesSwitchboard> PanelScheduleTemplatesSwitchboards { get; set; }
        public virtual DbSet<Parking> Parkings { get; set; }
        public virtual DbSet<ParkingType> ParkingTypes { get; set; }
        public virtual DbSet<Phase> Phases { get; set; }
        public virtual DbSet<Pipe> Pipes { get; set; }
        public virtual DbSet<PipeAccessory> PipeAccessories { get; set; }
        public virtual DbSet<PipeAccessoryType> PipeAccessoryTypes { get; set; }
        public virtual DbSet<PipeConnection> PipeConnections { get; set; }
        public virtual DbSet<PipeConnectionType> PipeConnectionTypes { get; set; }
        public virtual DbSet<PipeFitting> PipeFittings { get; set; }
        public virtual DbSet<PipeFittingType> PipeFittingTypes { get; set; }
        public virtual DbSet<PipeFlowStateEnum> PipeFlowStateEnums { get; set; }
        public virtual DbSet<PipeInsulation> PipeInsulations { get; set; }
        public virtual DbSet<PipeInsulationType> PipeInsulationTypes { get; set; }
        public virtual DbSet<PipeMaterial> PipeMaterials { get; set; }
        public virtual DbSet<PipeMaterialType> PipeMaterialTypes { get; set; }
        public virtual DbSet<PipePlaceholder> PipePlaceholders { get; set; }
        public virtual DbSet<PipeSchedule> PipeSchedules { get; set; }
        public virtual DbSet<PipeScheduleType> PipeScheduleTypes { get; set; }
        public virtual DbSet<PipeSegment> PipeSegments { get; set; }
        public virtual DbSet<PipeSystemTypeEnum> PipeSystemTypeEnums { get; set; }
        public virtual DbSet<PipeType> PipeTypes { get; set; }
        public virtual DbSet<PipingSystem> PipingSystems { get; set; }
        public virtual DbSet<PipingSystemType> PipingSystemTypes { get; set; }
        public virtual DbSet<Planting> Plantings { get; set; }
        public virtual DbSet<PlantingType> PlantingTypes { get; set; }
        public virtual DbSet<PlumbingFixture> PlumbingFixtures { get; set; }
        public virtual DbSet<PlumbingFixtureOnWall> PlumbingFixtureOnWalls { get; set; }
        public virtual DbSet<PlumbingFixtureType> PlumbingFixtureTypes { get; set; }
        public virtual DbSet<PointLoad> PointLoads { get; set; }
        public virtual DbSet<PowerFactorStateTypeEnum> PowerFactorStateTypeEnums { get; set; }
        public virtual DbSet<Profile> Profiles { get; set; }
        public virtual DbSet<ProjectInformation> ProjectInformations { get; set; }
        public virtual DbSet<PropertyLine> PropertyLines { get; set; }
        public virtual DbSet<PropertyLineType> PropertyLineTypes { get; set; }
        public virtual DbSet<Railing> Railings { get; set; }
        public virtual DbSet<RailingType> RailingTypes { get; set; }
        public virtual DbSet<Ramp> Ramps { get; set; }
        public virtual DbSet<RampType> RampTypes { get; set; }
        public virtual DbSet<RebarLayoutEnum> RebarLayoutEnums { get; set; }
        public virtual DbSet<RebarOnColumn> RebarOnColumns { get; set; }
        public virtual DbSet<RebarOnFloor> RebarOnFloors { get; set; }
        public virtual DbSet<RebarOnFoundation> RebarOnFoundations { get; set; }
        public virtual DbSet<RebarOnFraming> RebarOnFramings { get; set; }
        public virtual DbSet<RebarOnWall> RebarOnWalls { get; set; }
        public virtual DbSet<RebarStyleEnum> RebarStyleEnums { get; set; }
        public virtual DbSet<RevitDblinkInfo> RevitDblinkInfos { get; set; }
        public virtual DbSet<Roof> Roofs { get; set; }
        public virtual DbSet<RoofType> RoofTypes { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<RoomAssociation> RoomAssociations { get; set; }
        public virtual DbSet<RoomFromToAssociation> RoomFromToAssociations { get; set; }
        public virtual DbSet<RoomTag> RoomTags { get; set; }
        public virtual DbSet<SecurityDevice> SecurityDevices { get; set; }
        public virtual DbSet<SecurityDeviceType> SecurityDeviceTypes { get; set; }
        public virtual DbSet<ServiceTypeEnum> ServiceTypeEnums { get; set; }
        public virtual DbSet<Sheet> Sheets { get; set; }
        public virtual DbSet<Site> Sites { get; set; }
        public virtual DbSet<SiteType> SiteTypes { get; set; }
        public virtual DbSet<SlabEdge> SlabEdges { get; set; }
        public virtual DbSet<SlabEdgeType> SlabEdgeTypes { get; set; }
        public virtual DbSet<Space> Spaces { get; set; }
        public virtual DbSet<SpaceAssociation> SpaceAssociations { get; set; }
        public virtual DbSet<SpaceTypeEnum> SpaceTypeEnums { get; set; }
        public virtual DbSet<SpaceTypeSetting> SpaceTypeSettings { get; set; }
        public virtual DbSet<SpecialtyEquipment> SpecialtyEquipments { get; set; }
        public virtual DbSet<SpecialtyEquipmentType> SpecialtyEquipmentTypes { get; set; }
        public virtual DbSet<Sprinkler> Sprinklers { get; set; }
        public virtual DbSet<SprinklerType> SprinklerTypes { get; set; }
        public virtual DbSet<Stair> Stairs { get; set; }
        public virtual DbSet<StairType> StairTypes { get; set; }
        public virtual DbSet<StructuralColumn> StructuralColumns { get; set; }
        public virtual DbSet<StructuralColumnType> StructuralColumnTypes { get; set; }
        public virtual DbSet<StructuralFabricReinforcement> StructuralFabricReinforcements { get; set; }
        public virtual DbSet<StructuralFabricReinforcementType> StructuralFabricReinforcementTypes { get; set; }
        public virtual DbSet<StructuralFoundation> StructuralFoundations { get; set; }
        public virtual DbSet<StructuralFoundationType> StructuralFoundationTypes { get; set; }
        public virtual DbSet<StructuralFraming> StructuralFramings { get; set; }
        public virtual DbSet<StructuralFramingType> StructuralFramingTypes { get; set; }
        public virtual DbSet<StructuralRebar> StructuralRebars { get; set; }
        public virtual DbSet<StructuralRebarBarType> StructuralRebarBarTypes { get; set; }
        public virtual DbSet<StructuralRebarHookType> StructuralRebarHookTypes { get; set; }
        public virtual DbSet<StructuralRebarShape> StructuralRebarShapes { get; set; }
        public virtual DbSet<StructuralStiffener> StructuralStiffeners { get; set; }
        public virtual DbSet<StructuralStiffenerType> StructuralStiffenerTypes { get; set; }
        public virtual DbSet<StructuralTruss> StructuralTrusses { get; set; }
        public virtual DbSet<StructuralTrussType> StructuralTrussTypes { get; set; }
        public virtual DbSet<SwitchSystem> SwitchSystems { get; set; }
        public virtual DbSet<TelephoneDevice> TelephoneDevices { get; set; }
        public virtual DbSet<TelephoneDeviceType> TelephoneDeviceTypes { get; set; }
        public virtual DbSet<Topography> Topographies { get; set; }
        public virtual DbSet<TopographyType> TopographyTypes { get; set; }
        public virtual DbSet<View> Views { get; set; }
        public virtual DbSet<Voltage> Voltages { get; set; }
        public virtual DbSet<VoltageType> VoltageTypes { get; set; }
        public virtual DbSet<Wall> Walls { get; set; }
        public virtual DbSet<WallSweep> WallSweeps { get; set; }
        public virtual DbSet<WallSweepType> WallSweepTypes { get; set; }
        public virtual DbSet<WallType> WallTypes { get; set; }
        public virtual DbSet<WallUsageEnum> WallUsageEnums { get; set; }
        public virtual DbSet<Window> Windows { get; set; }
        public virtual DbSet<WindowType> WindowTypes { get; set; }
        public virtual DbSet<WindowWall> WindowWalls { get; set; }
        public virtual DbSet<Wire> Wires { get; set; }
        public virtual DbSet<WireInsulation> WireInsulations { get; set; }
        public virtual DbSet<WireInsulationType> WireInsulationTypes { get; set; }
        public virtual DbSet<WireMaterial> WireMaterials { get; set; }
        public virtual DbSet<WireMaterialType> WireMaterialTypes { get; set; }
        public virtual DbSet<WireTemperatureRating> WireTemperatureRatings { get; set; }
        public virtual DbSet<WireTemperatureRatingType> WireTemperatureRatingTypes { get; set; }
        public virtual DbSet<WireType> WireTypes { get; set; }
        public virtual DbSet<WiringTypeEnum> WiringTypeEnums { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=RevitSampleProjectDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AirTerminal>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.Property(e => e.SystemClassification).HasMaxLength(255);

                entity.Property(e => e.SystemName).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.AirTerminals)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_AirTerminals_DesignOption");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.AirTerminalPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_AirTerminals_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.AirTerminalPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_AirTerminals_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.AirTerminals)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_AirTerminals_TypeId");
            });

            modelBuilder.Entity<AirTerminalType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.AirTerminalTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_AirTerminalTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.AirTerminalTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_AirTerminalTypes_OmniClassNumber");
            });

            modelBuilder.Entity<AnalyzesAsTypeEnum>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<Area>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Area1).HasColumnName("Area");

                entity.Property(e => e.AreaType).HasMaxLength(255);

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Number).HasMaxLength(255);

                entity.HasOne(d => d.AreaScheme)
                    .WithMany(p => p.Areas)
                    .HasForeignKey(d => d.AreaSchemeId)
                    .HasConstraintName("FK_Areas_AreaSchemeId");

                entity.HasOne(d => d.LevelNavigation)
                    .WithMany(p => p.Areas)
                    .HasForeignKey(d => d.Level)
                    .HasConstraintName("FK_Areas_Level");
            });

            modelBuilder.Entity<AreaLoad>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Allnon0loads).HasMaxLength(255);

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.AreaLoads)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_AreaLoads_DesignOption");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.AreaLoadPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_AreaLoads_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.AreaLoadPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_AreaLoads_PhaseDemolished");
            });

            modelBuilder.Entity<AreaLoadOnSlab>(entity =>
            {
                entity.HasKey(e => e.AreaLoadId);

                entity.ToTable("AreaLoadOnSlab");

                entity.Property(e => e.AreaLoadId).ValueGeneratedNever();

                entity.HasOne(d => d.AreaLoad)
                    .WithOne(p => p.AreaLoadOnSlab)
                    .HasForeignKey<AreaLoadOnSlab>(d => d.AreaLoadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AreaLoadOnSlab_AreaLoadId");

                entity.HasOne(d => d.Slab)
                    .WithMany(p => p.AreaLoadOnSlabs)
                    .HasForeignKey(d => d.SlabId)
                    .HasConstraintName("FK_AreaLoadOnSlab_SlabId");
            });

            modelBuilder.Entity<AreaScheme>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<Assembly>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.Assemblies)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_Assemblies_DesignOption");

                entity.HasOne(d => d.NamingCategoryNavigation)
                    .WithMany(p => p.Assemblies)
                    .HasForeignKey(d => d.NamingCategory)
                    .HasConstraintName("FK_Assemblies_NamingCategory");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.AssemblyPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_Assemblies_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.AssemblyPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_Assemblies_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Assemblies)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_Assemblies_TypeId");
            });

            modelBuilder.Entity<AssemblyCode>(entity =>
            {
                entity.HasKey(e => e.AssemblyCode1);

                entity.Property(e => e.AssemblyCode1)
                    .HasMaxLength(255)
                    .HasColumnName("AssemblyCode");

                entity.Property(e => e.AssemblyDescription).HasMaxLength(255);
            });

            modelBuilder.Entity<AssemblyType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.AssemblyTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_AssemblyTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.AssemblyTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_AssemblyTypes_OmniClassNumber");
            });

            modelBuilder.Entity<BuildingTypeSetting>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.BuildingTypeSettings)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_BuildingTypeSettings_DesignOption");
            });

            modelBuilder.Entity<CableTray>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.Property(e => e.ServiceType).HasMaxLength(255);

                entity.Property(e => e.Size).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.CableTrays)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_CableTrays_DesignOption");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.CableTrayPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_CableTrays_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.CableTrayPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_CableTrays_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.CableTrays)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_CableTrays_TypeId");
            });

            modelBuilder.Entity<CableTrayFitting>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.Property(e => e.ServiceType).HasMaxLength(255);

                entity.Property(e => e.Size).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.CableTrayFittings)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_CableTrayFittings_DesignOption");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.CableTrayFittingPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_CableTrayFittings_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.CableTrayFittingPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_CableTrayFittings_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.CableTrayFittings)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_CableTrayFittings_TypeId");
            });

            modelBuilder.Entity<CableTrayFittingType>(entity =>
            {
                entity.ToTable("CableTrayFittingType");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.CableTrayFittingTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_CableTrayFittingType_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.CableTrayFittingTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_CableTrayFittingType_OmniClassNumber");
            });

            modelBuilder.Entity<CableTrayType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.CableTrayTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_CableTrayTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.CableTrayTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_CableTrayTypes_OmniClassNumber");
            });

            modelBuilder.Entity<Casework>(entity =>
            {
                entity.ToTable("Casework");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.Caseworks)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_Casework_DesignOption");

                entity.HasOne(d => d.LevelNavigation)
                    .WithMany(p => p.Caseworks)
                    .HasForeignKey(d => d.Level)
                    .HasConstraintName("FK_Casework_Level");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.CaseworkPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_Casework_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.CaseworkPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_Casework_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Caseworks)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_Casework_TypeId");
            });

            modelBuilder.Entity<CaseworkOnWall>(entity =>
            {
                entity.ToTable("CaseworkOnWall");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.HostName).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.HasOne(d => d.Host)
                    .WithMany(p => p.CaseworkOnWalls)
                    .HasForeignKey(d => d.HostId)
                    .HasConstraintName("FK_CaseworkOnWall_HostId");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.CaseworkOnWall)
                    .HasForeignKey<CaseworkOnWall>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CaseworkOnWall_Id");
            });

            modelBuilder.Entity<CaseworkType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.ConstructionType).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Finish).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.CaseworkTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_CaseworkTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.CaseworkTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_CaseworkTypes_OmniClassNumber");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.HasOne(d => d.Material)
                    .WithMany(p => p.Categories)
                    .HasForeignKey(d => d.MaterialId)
                    .HasConstraintName("FK_Categories_MaterialId");
            });

            modelBuilder.Entity<Ceiling>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.Ceilings)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_Ceilings_DesignOption");

                entity.HasOne(d => d.LevelNavigation)
                    .WithMany(p => p.Ceilings)
                    .HasForeignKey(d => d.Level)
                    .HasConstraintName("FK_Ceilings_Level");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.CeilingPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_Ceilings_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.CeilingPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_Ceilings_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Ceilings)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_Ceilings_TypeId");
            });

            modelBuilder.Entity<CeilingType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.CeilingTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_CeilingTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.CeilingTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_CeilingTypes_OmniClassNumber");
            });

            modelBuilder.Entity<ColumnType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.ColumnTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_ColumnTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.ColumnTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_ColumnTypes_OmniClassNumber");
            });

            modelBuilder.Entity<Columns1>(entity =>
            {
                entity.ToTable("Columns1");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.HasOne(d => d.BaseLevelNavigation)
                    .WithMany(p => p.Columns1BaseLevelNavigations)
                    .HasForeignKey(d => d.BaseLevel)
                    .HasConstraintName("FK_Columns1_BaseLevel");

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.Columns1s)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_Columns1_DesignOption");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.Columns1PhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_Columns1_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.Columns1PhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_Columns1_PhaseDemolished");

                entity.HasOne(d => d.TopLevelNavigation)
                    .WithMany(p => p.Columns1TopLevelNavigations)
                    .HasForeignKey(d => d.TopLevel)
                    .HasConstraintName("FK_Columns1_TopLevel");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Columns1s)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_Columns1_TypeId");
            });

            modelBuilder.Entity<CommunicationDevice>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CircuitNumber).HasMaxLength(255);

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.ElectricalData).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.Property(e => e.Panel).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.CommunicationDevices)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_CommunicationDevices_DesignOption");

                entity.HasOne(d => d.LevelNavigation)
                    .WithMany(p => p.CommunicationDevices)
                    .HasForeignKey(d => d.Level)
                    .HasConstraintName("FK_CommunicationDevices_Level");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.CommunicationDevicePhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_CommunicationDevices_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.CommunicationDevicePhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_CommunicationDevices_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.CommunicationDevices)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_CommunicationDevices_TypeId");
            });

            modelBuilder.Entity<CommunicationDeviceType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.CommunicationDeviceTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_CommunicationDeviceTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.CommunicationDeviceTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_CommunicationDeviceTypes_OmniClassNumber");
            });

            modelBuilder.Entity<ConditionTypeEnum>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<Conduit>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.DiameterTradeSize).HasColumnName("Diameter(TradeSize)");

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.Property(e => e.ServiceType).HasMaxLength(255);

                entity.Property(e => e.Size).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.Conduits)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_Conduits_DesignOption");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.ConduitPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_Conduits_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.ConduitPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_Conduits_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Conduits)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_Conduits_TypeId");
            });

            modelBuilder.Entity<ConduitFitting>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.Property(e => e.ServiceType).HasMaxLength(255);

                entity.Property(e => e.Size).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.ConduitFittings)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_ConduitFittings_DesignOption");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.ConduitFittingPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_ConduitFittings_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.ConduitFittingPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_ConduitFittings_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.ConduitFittings)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_ConduitFittings_TypeId");
            });

            modelBuilder.Entity<ConduitFittingType>(entity =>
            {
                entity.ToTable("ConduitFittingType");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.ConduitFittingTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_ConduitFittingType_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.ConduitFittingTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_ConduitFittingType_OmniClassNumber");
            });

            modelBuilder.Entity<ConduitType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.ConduitTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_ConduitTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.ConduitTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_ConduitTypes_OmniClassNumber");
            });

            modelBuilder.Entity<Construction>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.Constructions)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_Constructions_DesignOption");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.ConstructionPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_Constructions_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.ConstructionPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_Constructions_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Constructions)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_Constructions_TypeId");
            });

            modelBuilder.Entity<ConstructionType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<CoverType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.CoverTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_CoverTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.CoverTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_CoverTypes_OmniClassNumber");
            });

            modelBuilder.Entity<CurtainPanel>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.CurtainPanels)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_CurtainPanels_DesignOption");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.CurtainPanelPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_CurtainPanels_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.CurtainPanelPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_CurtainPanels_PhaseDemolished");
            });

            modelBuilder.Entity<CurtainPanelType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.ConstructionType).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Finish).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.CurtainPanelTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_CurtainPanelTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.CurtainPanelTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_CurtainPanelTypes_OmniClassNumber");
            });

            modelBuilder.Entity<CurtainSystem>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.CurtainSystems)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_CurtainSystems_DesignOption");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.CurtainSystemPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_CurtainSystems_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.CurtainSystemPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_CurtainSystems_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.CurtainSystems)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_CurtainSystems_TypeId");
            });

            modelBuilder.Entity<CurtainSystemType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.CurtainSystemTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_CurtainSystemTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.CurtainSystemTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_CurtainSystemTypes_OmniClassNumber");
            });

            modelBuilder.Entity<CurtainWallMullion>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.CurtainWallMullions)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_CurtainWallMullions_DesignOption");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.CurtainWallMullionPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_CurtainWallMullions_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.CurtainWallMullionPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_CurtainWallMullions_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.CurtainWallMullions)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_CurtainWallMullions_TypeId");
            });

            modelBuilder.Entity<CurtainWallMullionType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.CurtainWallMullionTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_CurtainWallMullionTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.CurtainWallMullionTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_CurtainWallMullionTypes_OmniClassNumber");
            });

            modelBuilder.Entity<CurtainWallPanelOnRoof>(entity =>
            {
                entity.ToTable("CurtainWallPanelOnRoof");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.HostName).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.HasOne(d => d.Host)
                    .WithMany(p => p.CurtainWallPanelOnRoofs)
                    .HasForeignKey(d => d.HostId)
                    .HasConstraintName("FK_CurtainWallPanelOnRoof_HostId");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.CurtainWallPanelOnRoof)
                    .HasForeignKey<CurtainWallPanelOnRoof>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CurtainWallPanelOnRoof_Id");
            });

            modelBuilder.Entity<CurtainWallPanelOnWall>(entity =>
            {
                entity.ToTable("CurtainWallPanelOnWall");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.HostName).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.HasOne(d => d.Host)
                    .WithMany(p => p.CurtainWallPanelOnWalls)
                    .HasForeignKey(d => d.HostId)
                    .HasConstraintName("FK_CurtainWallPanelOnWall_HostId");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.CurtainWallPanelOnWall)
                    .HasForeignKey<CurtainWallPanelOnWall>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CurtainWallPanelOnWall_Id");
            });

            modelBuilder.Entity<DataDevice>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CircuitNumber).HasMaxLength(255);

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.ElectricalData).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.Property(e => e.Panel).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.DataDevices)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_DataDevices_DesignOption");

                entity.HasOne(d => d.LevelNavigation)
                    .WithMany(p => p.DataDevices)
                    .HasForeignKey(d => d.Level)
                    .HasConstraintName("FK_DataDevices_Level");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.DataDevicePhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_DataDevices_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.DataDevicePhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_DataDevices_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.DataDevices)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_DataDevices_TypeId");
            });

            modelBuilder.Entity<DataDeviceType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.DataDeviceTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_DataDeviceTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.DataDeviceTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_DataDeviceTypes_OmniClassNumber");
            });

            modelBuilder.Entity<DemandFactor>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.DemandFactors)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_DemandFactors_DesignOption");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.DemandFactorPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_DemandFactors_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.DemandFactorPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_DemandFactors_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.DemandFactors)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_DemandFactors_TypeId");
            });

            modelBuilder.Entity<DemandFactorType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.DemandFactorTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_DemandFactorTypes_AssemblyCode");

                entity.HasOne(d => d.LoadClassificationNavigation)
                    .WithMany(p => p.DemandFactorTypes)
                    .HasForeignKey(d => d.LoadClassification)
                    .HasConstraintName("FK_DemandFactorTypes_LoadClassification");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.DemandFactorTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_DemandFactorTypes_OmniClassNumber");
            });

            modelBuilder.Entity<DesignOption>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<DesignOptionSet>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.HasOne(d => d.PrimaryOption)
                    .WithMany(p => p.DesignOptionSets)
                    .HasForeignKey(d => d.PrimaryOptionId)
                    .HasConstraintName("FK_DesignOptionSets_PrimaryOptionId");
            });

            modelBuilder.Entity<DistributionSystem>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.DistributionSystems)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_DistributionSystems_DesignOption");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.DistributionSystemPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_DistributionSystems_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.DistributionSystemPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_DistributionSystems_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.DistributionSystems)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_DistributionSystems_TypeId");
            });

            modelBuilder.Entity<DistributionSystemType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.DistributionSystemTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_DistributionSystemTypes_AssemblyCode");

                entity.HasOne(d => d.ConfigurationNavigation)
                    .WithMany(p => p.DistributionSystemTypes)
                    .HasForeignKey(d => d.Configuration)
                    .HasConstraintName("FK_DistributionSystemTypes_Configuration");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.DistributionSystemTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_DistributionSystemTypes_OmniClassNumber");

                entity.HasOne(d => d.PhaseNavigation)
                    .WithMany(p => p.DistributionSystemTypes)
                    .HasForeignKey(d => d.Phase)
                    .HasConstraintName("FK_DistributionSystemTypes_Phase");
            });

            modelBuilder.Entity<DivisionProfile>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.DivisionProfiles)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_DivisionProfiles_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.DivisionProfiles)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_DivisionProfiles_OmniClassNumber");
            });

            modelBuilder.Entity<Door>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.EgressHardware).HasColumnName("Egress Hardware");

                entity.Property(e => e.Finish).HasMaxLength(255);

                entity.Property(e => e.FrameMaterial).HasMaxLength(255);

                entity.Property(e => e.FrameType).HasMaxLength(255);

                entity.Property(e => e.HingeSet)
                    .HasMaxLength(255)
                    .HasColumnName("Hinge Set");

                entity.Property(e => e.HoldOpen).HasColumnName("Hold Open");

                entity.Property(e => e.LockFunction)
                    .HasMaxLength(255)
                    .HasColumnName("Lock Function");

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.Doors)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_Doors_DesignOption");

                entity.HasOne(d => d.LevelNavigation)
                    .WithMany(p => p.Doors)
                    .HasForeignKey(d => d.Level)
                    .HasConstraintName("FK_Doors_Level");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.DoorPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_Doors_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.DoorPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_Doors_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Doors)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_Doors_TypeId");
            });

            modelBuilder.Entity<DoorType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.ConstructionType).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.FireRating).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.Operation).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.DoorTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_DoorTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.DoorTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_DoorTypes_OmniClassNumber");
            });

            modelBuilder.Entity<DoorWall>(entity =>
            {
                entity.HasKey(e => e.DoorId);

                entity.ToTable("DoorWall");

                entity.Property(e => e.DoorId).ValueGeneratedNever();

                entity.Property(e => e.DoorName).HasMaxLength(255);

                entity.Property(e => e.WallName).HasMaxLength(255);

                entity.HasOne(d => d.Door)
                    .WithOne(p => p.DoorWall)
                    .HasForeignKey<DoorWall>(d => d.DoorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DoorWall_DoorId");

                entity.HasOne(d => d.Wall)
                    .WithMany(p => p.DoorWalls)
                    .HasForeignKey(d => d.WallId)
                    .HasConstraintName("FK_DoorWall_WallId");
            });

            modelBuilder.Entity<Duct>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.FreeSize).HasMaxLength(255);

                entity.Property(e => e.InsulationType).HasMaxLength(255);

                entity.Property(e => e.LiningType).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.Property(e => e.OverallSize).HasMaxLength(255);

                entity.Property(e => e.Size).HasMaxLength(255);

                entity.Property(e => e.SystemClassification).HasMaxLength(255);

                entity.Property(e => e.SystemName).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.Ducts)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_Ducts_DesignOption");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.DuctPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_Ducts_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.DuctPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_Ducts_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Ducts)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_Ducts_TypeId");
            });

            modelBuilder.Entity<DuctAccessory>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.FreeSize).HasMaxLength(255);

                entity.Property(e => e.InsulationType).HasMaxLength(255);

                entity.Property(e => e.LiningType).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.Property(e => e.OverallSize).HasMaxLength(255);

                entity.Property(e => e.Size).HasMaxLength(255);

                entity.Property(e => e.SystemClassification).HasMaxLength(255);

                entity.Property(e => e.SystemName).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.DuctAccessories)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_DuctAccessories_DesignOption");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.DuctAccessoryPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_DuctAccessories_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.DuctAccessoryPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_DuctAccessories_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.DuctAccessories)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_DuctAccessories_TypeId");
            });

            modelBuilder.Entity<DuctAccessoryType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.DuctAccessoryTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_DuctAccessoryTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.DuctAccessoryTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_DuctAccessoryTypes_OmniClassNumber");
            });

            modelBuilder.Entity<DuctFitting>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.FreeSize).HasMaxLength(255);

                entity.Property(e => e.InsulationType).HasMaxLength(255);

                entity.Property(e => e.LiningType).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.Property(e => e.OverallSize).HasMaxLength(255);

                entity.Property(e => e.Size).HasMaxLength(255);

                entity.Property(e => e.SystemClassification).HasMaxLength(255);

                entity.Property(e => e.SystemName).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.DuctFittings)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_DuctFittings_DesignOption");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.DuctFittingPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_DuctFittings_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.DuctFittingPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_DuctFittings_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.DuctFittings)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_DuctFittings_TypeId");
            });

            modelBuilder.Entity<DuctFittingType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.DuctFittingTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_DuctFittingTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.DuctFittingTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_DuctFittingTypes_OmniClassNumber");
            });

            modelBuilder.Entity<DuctInsulation>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.DuctInsulations)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_DuctInsulations_DesignOption");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.DuctInsulationPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_DuctInsulations_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.DuctInsulationPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_DuctInsulations_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.DuctInsulations)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_DuctInsulations_TypeId");
            });

            modelBuilder.Entity<DuctInsulationType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.DuctInsulationTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_DuctInsulationTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.DuctInsulationTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_DuctInsulationTypes_OmniClassNumber");
            });

            modelBuilder.Entity<DuctLining>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.DuctLinings)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_DuctLinings_DesignOption");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.DuctLiningPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_DuctLinings_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.DuctLiningPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_DuctLinings_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.DuctLinings)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_DuctLinings_TypeId");
            });

            modelBuilder.Entity<DuctLiningType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.DuctLiningTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_DuctLiningTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.DuctLiningTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_DuctLiningTypes_OmniClassNumber");
            });

            modelBuilder.Entity<DuctPlaceholder>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.FreeSize).HasMaxLength(255);

                entity.Property(e => e.InsulationType).HasMaxLength(255);

                entity.Property(e => e.LiningType).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.Property(e => e.OverallSize).HasMaxLength(255);

                entity.Property(e => e.Size).HasMaxLength(255);

                entity.Property(e => e.SystemClassification).HasMaxLength(255);

                entity.Property(e => e.SystemName).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.DuctPlaceholders)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_DuctPlaceholders_DesignOption");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.DuctPlaceholderPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_DuctPlaceholders_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.DuctPlaceholderPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_DuctPlaceholders_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.DuctPlaceholders)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_DuctPlaceholders_TypeId");
            });

            modelBuilder.Entity<DuctSystem>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.SystemEquipment).HasMaxLength(255);

                entity.Property(e => e.SystemName).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.DuctSystems)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_DuctSystems_DesignOption");
            });

            modelBuilder.Entity<DuctSystemType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Abbreviation).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.RiseDropSymbol).HasColumnName("Rise/DropSymbol");

                entity.Property(e => e.SystemClassification).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");
            });

            modelBuilder.Entity<DuctSystemTypeEnum>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<DuctType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.DuctTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_DuctTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.DuctTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_DuctTypes_OmniClassNumber");
            });

            modelBuilder.Entity<EaveCutterTypeEnum>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<ElectricalCircuit>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CircuitNumber).HasMaxLength(255);

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.LoadClassification).HasMaxLength(255);

                entity.Property(e => e.LoadName).HasMaxLength(255);

                entity.Property(e => e.OfGroundConductors).HasColumnName("ofGroundConductors");

                entity.Property(e => e.OfHotConductors).HasColumnName("ofHotConductors");

                entity.Property(e => e.OfNeutralConductors).HasColumnName("ofNeutralConductors");

                entity.Property(e => e.OfRuns).HasColumnName("ofRuns");

                entity.Property(e => e.Panel).HasMaxLength(255);

                entity.Property(e => e.WireSize).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.ElectricalCircuits)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_ElectricalCircuits_DesignOption");

                entity.HasOne(d => d.SystemTypeNavigation)
                    .WithMany(p => p.ElectricalCircuits)
                    .HasForeignKey(d => d.SystemType)
                    .HasConstraintName("FK_ElectricalCircuits_SystemType");

                entity.HasOne(d => d.WireTypeNavigation)
                    .WithMany(p => p.ElectricalCircuits)
                    .HasForeignKey(d => d.WireType)
                    .HasConstraintName("FK_ElectricalCircuits_WireType");
            });

            modelBuilder.Entity<ElectricalDemandFactorDefinition>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.ElectricalDemandFactorDefinitions)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_ElectricalDemandFactorDefinitions_DesignOption");
            });

            modelBuilder.Entity<ElectricalEquipment>(entity =>
            {
                entity.ToTable("ElectricalEquipment");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.ElectricalData).HasMaxLength(255);

                entity.Property(e => e.Enclosure).HasMaxLength(255);

                entity.Property(e => e.Feed).HasMaxLength(255);

                entity.Property(e => e.Location).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.Property(e => e.Max1poleBreakers).HasColumnName("Max#1PoleBreakers");

                entity.Property(e => e.Modifications).HasMaxLength(255);

                entity.Property(e => e.Mounting).HasMaxLength(255);

                entity.Property(e => e.PanelName).HasMaxLength(255);

                entity.Property(e => e.ShortCircuitRating).HasMaxLength(255);

                entity.Property(e => e.SupplyFrom).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.ElectricalEquipments)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_ElectricalEquipment_DesignOption");

                entity.HasOne(d => d.LevelNavigation)
                    .WithMany(p => p.ElectricalEquipments)
                    .HasForeignKey(d => d.Level)
                    .HasConstraintName("FK_ElectricalEquipment_Level");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.ElectricalEquipmentPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_ElectricalEquipment_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.ElectricalEquipmentPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_ElectricalEquipment_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.ElectricalEquipments)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_ElectricalEquipment_TypeId");
            });

            modelBuilder.Entity<ElectricalEquipmentType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Bussing).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.MainsType).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Mcbrating).HasColumnName("MCBRating");

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.Property(e => e.Voltage).HasMaxLength(255);

                entity.Property(e => e.Wattage).HasMaxLength(255);

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.ElectricalEquipmentTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_ElectricalEquipmentTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.ElectricalEquipmentTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_ElectricalEquipmentTypes_OmniClassNumber");
            });

            modelBuilder.Entity<ElectricalFixture>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CircuitNumber).HasMaxLength(255);

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.ElectricalData).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.Property(e => e.Panel).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.ElectricalFixtures)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_ElectricalFixtures_DesignOption");

                entity.HasOne(d => d.LevelNavigation)
                    .WithMany(p => p.ElectricalFixtures)
                    .HasForeignKey(d => d.Level)
                    .HasConstraintName("FK_ElectricalFixtures_Level");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.ElectricalFixturePhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_ElectricalFixtures_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.ElectricalFixturePhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_ElectricalFixtures_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.ElectricalFixtures)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_ElectricalFixtures_TypeId");
            });

            modelBuilder.Entity<ElectricalFixtureType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.ElectricalFixtureTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_ElectricalFixtureTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.ElectricalFixtureTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_ElectricalFixtureTypes_OmniClassNumber");
            });

            modelBuilder.Entity<ElectricalLoadClassification>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.ElectricalLoadClassifications)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_ElectricalLoadClassifications_DesignOption");
            });

            modelBuilder.Entity<ElectricalLoadClassificationParameterElement>(entity =>
            {
                entity.ToTable("ElectricalLoadClassificationParameterElement");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.ElectricalLoadClassificationParameterElements)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_ElectricalLoadClassificationParameterElement_DesignOption");
            });

            modelBuilder.Entity<ElectricalPhaseConfigurationEnum>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<ElectricalPhaseEnum>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<ElectricalSystemEnum>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<ElementLevel>(entity =>
            {
                entity.HasKey(e => e.ElementId);

                entity.ToTable("ElementLevel");

                entity.Property(e => e.ElementId).ValueGeneratedNever();

                entity.Property(e => e.ElementName).HasMaxLength(255);

                entity.Property(e => e.LevelName).HasMaxLength(255);

                entity.HasOne(d => d.Level)
                    .WithMany(p => p.ElementLevels)
                    .HasForeignKey(d => d.LevelId)
                    .HasConstraintName("FK_ElementLevel_LevelId");
            });

            modelBuilder.Entity<ElementPhase>(entity =>
            {
                entity.HasKey(e => e.ElementId);

                entity.ToTable("ElementPhase");

                entity.Property(e => e.ElementId).ValueGeneratedNever();

                entity.Property(e => e.ElementName).HasMaxLength(255);

                entity.Property(e => e.PhaseName).HasMaxLength(255);

                entity.HasOne(d => d.PhaseCreated)
                    .WithMany(p => p.ElementPhases)
                    .HasForeignKey(d => d.PhaseCreatedId)
                    .HasConstraintName("FK_ElementPhase_PhaseCreatedId");
            });

            modelBuilder.Entity<FabricLocationEnum>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<Fascia>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.Fascia)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_Fascias_DesignOption");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.FasciaPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_Fascias_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.FasciaPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_Fascias_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Fascia)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_Fascias_TypeId");
            });

            modelBuilder.Entity<FasciaType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.FasciaTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_FasciaTypes_AssemblyCode");

                entity.HasOne(d => d.MaterialNavigation)
                    .WithMany(p => p.FasciaTypes)
                    .HasForeignKey(d => d.Material)
                    .HasConstraintName("FK_FasciaTypes_Material");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.FasciaTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_FasciaTypes_OmniClassNumber");

                entity.HasOne(d => d.ProfileNavigation)
                    .WithMany(p => p.FasciaTypes)
                    .HasForeignKey(d => d.Profile)
                    .HasConstraintName("FK_FasciaTypes_Profile");
            });

            modelBuilder.Entity<FireAlarmDevice>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CircuitNumber).HasMaxLength(255);

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.ElectricalData).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.Property(e => e.Panel).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.FireAlarmDevices)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_FireAlarmDevices_DesignOption");

                entity.HasOne(d => d.LevelNavigation)
                    .WithMany(p => p.FireAlarmDevices)
                    .HasForeignKey(d => d.Level)
                    .HasConstraintName("FK_FireAlarmDevices_Level");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.FireAlarmDevicePhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_FireAlarmDevices_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.FireAlarmDevicePhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_FireAlarmDevices_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.FireAlarmDevices)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_FireAlarmDevices_TypeId");
            });

            modelBuilder.Entity<FireAlarmDeviceType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.FireAlarmDeviceTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_FireAlarmDeviceTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.FireAlarmDeviceTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_FireAlarmDeviceTypes_OmniClassNumber");
            });

            modelBuilder.Entity<FlexDuct>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.FreeSize).HasMaxLength(255);

                entity.Property(e => e.InsulationType).HasMaxLength(255);

                entity.Property(e => e.LiningType).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.Property(e => e.OverallSize).HasMaxLength(255);

                entity.Property(e => e.SystemClassification).HasMaxLength(255);

                entity.Property(e => e.SystemName).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.FlexDucts)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_FlexDucts_DesignOption");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.FlexDuctPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_FlexDucts_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.FlexDuctPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_FlexDucts_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.FlexDucts)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_FlexDucts_TypeId");
            });

            modelBuilder.Entity<FlexDuctType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.FlexDuctTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_FlexDuctTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.FlexDuctTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_FlexDuctTypes_OmniClassNumber");
            });

            modelBuilder.Entity<FlexPipe>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.InsulationType).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.Property(e => e.OverallSize).HasMaxLength(255);

                entity.Property(e => e.SystemClassification).HasMaxLength(255);

                entity.Property(e => e.SystemName).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.FlexPipes)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_FlexPipes_DesignOption");

                entity.HasOne(d => d.FlowStateNavigation)
                    .WithMany(p => p.FlexPipes)
                    .HasForeignKey(d => d.FlowState)
                    .HasConstraintName("FK_FlexPipes_FlowState");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.FlexPipePhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_FlexPipes_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.FlexPipePhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_FlexPipes_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.FlexPipes)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_FlexPipes_TypeId");
            });

            modelBuilder.Entity<FlexPipeType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.FlexPipeTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_FlexPipeTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.FlexPipeTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_FlexPipeTypes_OmniClassNumber");
            });

            modelBuilder.Entity<Floor>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.HasOne(d => d.AnalyzeAsNavigation)
                    .WithMany(p => p.Floors)
                    .HasForeignKey(d => d.AnalyzeAs)
                    .HasConstraintName("FK_Floors_AnalyzeAs");

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.Floors)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_Floors_DesignOption");

                entity.HasOne(d => d.LevelNavigation)
                    .WithMany(p => p.Floors)
                    .HasForeignKey(d => d.Level)
                    .HasConstraintName("FK_Floors_Level");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.FloorPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_Floors_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.FloorPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_Floors_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Floors)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_Floors_TypeId");
            });

            modelBuilder.Entity<FloorType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.FloorTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_FloorTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.FloorTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_FloorTypes_OmniClassNumber");
            });

            modelBuilder.Entity<Fluid>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.Fluids)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_Fluids_DesignOption");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.FluidPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_Fluids_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.FluidPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_Fluids_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Fluids)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_Fluids_TypeId");
            });

            modelBuilder.Entity<FluidType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.FluidTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_FluidTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.FluidTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_FluidTypes_OmniClassNumber");
            });

            modelBuilder.Entity<Furniture>(entity =>
            {
                entity.ToTable("Furniture");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.Furnitures)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_Furniture_DesignOption");

                entity.HasOne(d => d.LevelNavigation)
                    .WithMany(p => p.Furnitures)
                    .HasForeignKey(d => d.Level)
                    .HasConstraintName("FK_Furniture_Level");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.FurniturePhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_Furniture_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.FurniturePhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_Furniture_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Furnitures)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_Furniture_TypeId");
            });

            modelBuilder.Entity<FurnitureSystem>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.FurnitureSystems)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_FurnitureSystems_DesignOption");

                entity.HasOne(d => d.LevelNavigation)
                    .WithMany(p => p.FurnitureSystems)
                    .HasForeignKey(d => d.Level)
                    .HasConstraintName("FK_FurnitureSystems_Level");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.FurnitureSystemPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_FurnitureSystems_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.FurnitureSystemPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_FurnitureSystems_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.FurnitureSystems)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_FurnitureSystems_TypeId");
            });

            modelBuilder.Entity<FurnitureSystemType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.FurnitureSystemTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_FurnitureSystemTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.FurnitureSystemTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_FurnitureSystemTypes_OmniClassNumber");
            });

            modelBuilder.Entity<FurnitureType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.FurnitureTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_FurnitureTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.FurnitureTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_FurnitureTypes_OmniClassNumber");
            });

            modelBuilder.Entity<GenericModel>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.GenericModels)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_GenericModels_DesignOption");

                entity.HasOne(d => d.LevelNavigation)
                    .WithMany(p => p.GenericModels)
                    .HasForeignKey(d => d.Level)
                    .HasConstraintName("FK_GenericModels_Level");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.GenericModelPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_GenericModels_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.GenericModelPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_GenericModels_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.GenericModels)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_GenericModels_TypeId");
            });

            modelBuilder.Entity<GenericModelOnRoof>(entity =>
            {
                entity.ToTable("GenericModelOnRoof");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.HostName).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.HasOne(d => d.Host)
                    .WithMany(p => p.GenericModelOnRoofs)
                    .HasForeignKey(d => d.HostId)
                    .HasConstraintName("FK_GenericModelOnRoof_HostId");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.GenericModelOnRoof)
                    .HasForeignKey<GenericModelOnRoof>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GenericModelOnRoof_Id");
            });

            modelBuilder.Entity<GenericModelOnWall>(entity =>
            {
                entity.ToTable("GenericModelOnWall");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.HostName).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.HasOne(d => d.Host)
                    .WithMany(p => p.GenericModelOnWalls)
                    .HasForeignKey(d => d.HostId)
                    .HasConstraintName("FK_GenericModelOnWall_HostId");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.GenericModelOnWall)
                    .HasForeignKey<GenericModelOnWall>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GenericModelOnWall_Id");
            });

            modelBuilder.Entity<GenericModelType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.GenericModelTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_GenericModelTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.GenericModelTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_GenericModelTypes_OmniClassNumber");
            });

            modelBuilder.Entity<Grid>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Grids)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_Grids_TypeId");
            });

            modelBuilder.Entity<GridType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.NonPlanViewSymbolsDefault).HasColumnName("Non-PlanViewSymbols(Default)");

                entity.Property(e => e.PlanViewSymbolsEnd1Default).HasColumnName("PlanViewSymbolsEnd1(Default)");

                entity.Property(e => e.PlanViewSymbolsEnd2Default).HasColumnName("PlanViewSymbolsEnd2(Default)");

                entity.Property(e => e.TypeName).HasMaxLength(255);
            });

            modelBuilder.Entity<Gutter>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.Gutters)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_Gutters_DesignOption");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.GutterPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_Gutters_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.GutterPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_Gutters_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Gutters)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_Gutters_TypeId");
            });

            modelBuilder.Entity<GutterType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.GutterTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_GutterTypes_AssemblyCode");

                entity.HasOne(d => d.MaterialNavigation)
                    .WithMany(p => p.GutterTypes)
                    .HasForeignKey(d => d.Material)
                    .HasConstraintName("FK_GutterTypes_Material");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.GutterTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_GutterTypes_OmniClassNumber");

                entity.HasOne(d => d.ProfileNavigation)
                    .WithMany(p => p.GutterTypes)
                    .HasForeignKey(d => d.Profile)
                    .HasConstraintName("FK_GutterTypes_Profile");
            });

            modelBuilder.Entity<HvacloadSchedule>(entity =>
            {
                entity.ToTable("HVACLoadSchedules");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.HvacloadSchedules)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_HVACLoadSchedules_DesignOption");
            });

            modelBuilder.Entity<Hvaczone>(entity =>
            {
                entity.ToTable("HVACZones");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.OutdoorAirRateAirChangesperHour).HasColumnName("OutdoorAirRate/AirChangesperHour");

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.Hvaczones)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_HVACZones_DesignOption");

                entity.HasOne(d => d.ServiceTypeNavigation)
                    .WithMany(p => p.Hvaczones)
                    .HasForeignKey(d => d.ServiceType)
                    .HasConstraintName("FK_HVACZones_ServiceType");
            });

            modelBuilder.Entity<InstanceUsageEnum>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<InternalAreaLoad>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Allnon0loads).HasMaxLength(255);

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.InternalAreaLoads)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_InternalAreaLoads_DesignOption");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.InternalAreaLoadPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_InternalAreaLoads_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.InternalAreaLoadPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_InternalAreaLoads_PhaseDemolished");
            });

            modelBuilder.Entity<InternalLineLoad>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Allnon0loads).HasMaxLength(255);

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.InternalLineLoads)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_InternalLineLoads_DesignOption");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.InternalLineLoadPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_InternalLineLoads_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.InternalLineLoadPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_InternalLineLoads_PhaseDemolished");
            });

            modelBuilder.Entity<InternalPointLoad>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Allnon0loads).HasMaxLength(255);

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.InternalPointLoads)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_InternalPointLoads_DesignOption");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.InternalPointLoadPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_InternalPointLoads_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.InternalPointLoadPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_InternalPointLoads_PhaseDemolished");
            });

            modelBuilder.Entity<Level>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.Levels)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_Levels_DesignOption");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Levels)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_Levels_TypeId");
            });

            modelBuilder.Entity<LevelType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<LightingDevice>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CircuitNumber).HasMaxLength(255);

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.ElectricalData).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.Property(e => e.Panel).HasMaxLength(255);

                entity.Property(e => e.SwitchId)
                    .HasMaxLength(255)
                    .HasColumnName("SwitchID");

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.LightingDevices)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_LightingDevices_DesignOption");

                entity.HasOne(d => d.LevelNavigation)
                    .WithMany(p => p.LightingDevices)
                    .HasForeignKey(d => d.Level)
                    .HasConstraintName("FK_LightingDevices_Level");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.LightingDevicePhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_LightingDevices_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.LightingDevicePhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_LightingDevices_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.LightingDevices)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_LightingDevices_TypeId");
            });

            modelBuilder.Entity<LightingDeviceType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.LightingDeviceTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_LightingDeviceTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.LightingDeviceTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_LightingDeviceTypes_OmniClassNumber");
            });

            modelBuilder.Entity<LightingFixture>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CircuitNumber).HasMaxLength(255);

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.ElectricalData).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.Property(e => e.Panel).HasMaxLength(255);

                entity.Property(e => e.SwitchId)
                    .HasMaxLength(255)
                    .HasColumnName("SwitchID");

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.LightingFixtures)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_LightingFixtures_DesignOption");

                entity.HasOne(d => d.LevelNavigation)
                    .WithMany(p => p.LightingFixtures)
                    .HasForeignKey(d => d.Level)
                    .HasConstraintName("FK_LightingFixtures_Level");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.LightingFixturePhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_LightingFixtures_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.LightingFixturePhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_LightingFixtures_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.LightingFixtures)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_LightingFixtures_TypeId");
            });

            modelBuilder.Entity<LightingFixtureOnCeiling>(entity =>
            {
                entity.ToTable("LightingFixtureOnCeiling");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.HostName).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.HasOne(d => d.Host)
                    .WithMany(p => p.LightingFixtureOnCeilings)
                    .HasForeignKey(d => d.HostId)
                    .HasConstraintName("FK_LightingFixtureOnCeiling_HostId");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.LightingFixtureOnCeiling)
                    .HasForeignKey<LightingFixtureOnCeiling>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LightingFixtureOnCeiling_Id");
            });

            modelBuilder.Entity<LightingFixtureOnWall>(entity =>
            {
                entity.ToTable("LightingFixtureOnWall");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.HostName).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.HasOne(d => d.Host)
                    .WithMany(p => p.LightingFixtureOnWalls)
                    .HasForeignKey(d => d.HostId)
                    .HasConstraintName("FK_LightingFixtureOnWall_HostId");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.LightingFixtureOnWall)
                    .HasForeignKey<LightingFixtureOnWall>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LightingFixtureOnWall_Id");
            });

            modelBuilder.Entity<LightingFixtureType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Lamp).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.PhotometricWebFile).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.Property(e => e.WattageComments).HasMaxLength(255);

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.LightingFixtureTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_LightingFixtureTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.LightingFixtureTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_LightingFixtureTypes_OmniClassNumber");
            });

            modelBuilder.Entity<LineLoad>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Allnon0loads).HasMaxLength(255);

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.LineLoads)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_LineLoads_DesignOption");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.LineLoadPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_LineLoads_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.LineLoadPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_LineLoads_PhaseDemolished");
            });

            modelBuilder.Entity<LineLoadOnBeam>(entity =>
            {
                entity.HasKey(e => e.LineLoadId);

                entity.ToTable("LineLoadOnBeam");

                entity.Property(e => e.LineLoadId).ValueGeneratedNever();

                entity.HasOne(d => d.Beam)
                    .WithMany(p => p.LineLoadOnBeams)
                    .HasForeignKey(d => d.BeamId)
                    .HasConstraintName("FK_LineLoadOnBeam_BeamId");

                entity.HasOne(d => d.LineLoad)
                    .WithOne(p => p.LineLoadOnBeam)
                    .HasForeignKey<LineLoadOnBeam>(d => d.LineLoadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LineLoadOnBeam_LineLoadId");
            });

            modelBuilder.Entity<LoadClassificationTypeEnum>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<Mass>(entity =>
            {
                entity.ToTable("Mass");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.Masses)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_Mass_DesignOption");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.MassPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_Mass_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.MassPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_Mass_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Masses)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_Mass_TypeId");
            });

            modelBuilder.Entity<MassExteriorWall>(entity =>
            {
                entity.ToTable("MassExteriorWall");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.MassComments)
                    .HasMaxLength(255)
                    .HasColumnName("Mass:Comments");

                entity.Property(e => e.MassFamily)
                    .HasMaxLength(255)
                    .HasColumnName("Mass:Family");

                entity.Property(e => e.MassFamilyandType)
                    .HasMaxLength(255)
                    .HasColumnName("Mass:FamilyandType");

                entity.Property(e => e.MassType)
                    .HasMaxLength(255)
                    .HasColumnName("Mass:Type");

                entity.Property(e => e.MassTypeComments)
                    .HasMaxLength(255)
                    .HasColumnName("Mass:TypeComments");

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.MassExteriorWalls)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_MassExteriorWall_DesignOption");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.MassExteriorWallPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_MassExteriorWall_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.MassExteriorWallPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_MassExteriorWall_PhaseDemolished");
            });

            modelBuilder.Entity<MassFloor>(entity =>
            {
                entity.ToTable("MassFloor");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Level).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.Property(e => e.MassComments)
                    .HasMaxLength(255)
                    .HasColumnName("Mass:Comments");

                entity.Property(e => e.MassDescription)
                    .HasMaxLength(255)
                    .HasColumnName("Mass:Description");

                entity.Property(e => e.MassFamily)
                    .HasMaxLength(255)
                    .HasColumnName("Mass:Family");

                entity.Property(e => e.MassFamilyandType)
                    .HasMaxLength(255)
                    .HasColumnName("Mass:FamilyandType");

                entity.Property(e => e.MassType)
                    .HasMaxLength(255)
                    .HasColumnName("Mass:Type");

                entity.Property(e => e.MassTypeComments)
                    .HasMaxLength(255)
                    .HasColumnName("Mass:TypeComments");

                entity.Property(e => e.Usage).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.MassFloors)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_MassFloor_DesignOption");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.MassFloorPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_MassFloor_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.MassFloorPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_MassFloor_PhaseDemolished");
            });

            modelBuilder.Entity<MassGlazing>(entity =>
            {
                entity.ToTable("MassGlazing");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.Property(e => e.MassComments)
                    .HasMaxLength(255)
                    .HasColumnName("Mass:Comments");

                entity.Property(e => e.MassFamily)
                    .HasMaxLength(255)
                    .HasColumnName("Mass:Family");

                entity.Property(e => e.MassFamilyandType)
                    .HasMaxLength(255)
                    .HasColumnName("Mass:FamilyandType");

                entity.Property(e => e.MassType)
                    .HasMaxLength(255)
                    .HasColumnName("Mass:Type");

                entity.Property(e => e.MassTypeComments)
                    .HasMaxLength(255)
                    .HasColumnName("Mass:TypeComments");

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.MassGlazings)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_MassGlazing_DesignOption");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.MassGlazingPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_MassGlazing_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.MassGlazingPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_MassGlazing_PhaseDemolished");
            });

            modelBuilder.Entity<MassInteriorWall>(entity =>
            {
                entity.ToTable("MassInteriorWall");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.MassComments)
                    .HasMaxLength(255)
                    .HasColumnName("Mass:Comments");

                entity.Property(e => e.MassFamily)
                    .HasMaxLength(255)
                    .HasColumnName("Mass:Family");

                entity.Property(e => e.MassFamilyandType)
                    .HasMaxLength(255)
                    .HasColumnName("Mass:FamilyandType");

                entity.Property(e => e.MassType)
                    .HasMaxLength(255)
                    .HasColumnName("Mass:Type");

                entity.Property(e => e.MassTypeComments)
                    .HasMaxLength(255)
                    .HasColumnName("Mass:TypeComments");

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.MassInteriorWalls)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_MassInteriorWall_DesignOption");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.MassInteriorWallPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_MassInteriorWall_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.MassInteriorWallPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_MassInteriorWall_PhaseDemolished");
            });

            modelBuilder.Entity<MassOpening>(entity =>
            {
                entity.ToTable("MassOpening");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.Property(e => e.MassComments)
                    .HasMaxLength(255)
                    .HasColumnName("Mass:Comments");

                entity.Property(e => e.MassFamily)
                    .HasMaxLength(255)
                    .HasColumnName("Mass:Family");

                entity.Property(e => e.MassFamilyandType)
                    .HasMaxLength(255)
                    .HasColumnName("Mass:FamilyandType");

                entity.Property(e => e.MassType)
                    .HasMaxLength(255)
                    .HasColumnName("Mass:Type");

                entity.Property(e => e.MassTypeComments)
                    .HasMaxLength(255)
                    .HasColumnName("Mass:TypeComments");

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.MassOpenings)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_MassOpening_DesignOption");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.MassOpeningPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_MassOpening_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.MassOpeningPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_MassOpening_PhaseDemolished");
            });

            modelBuilder.Entity<MassRoof>(entity =>
            {
                entity.ToTable("MassRoof");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.Property(e => e.MassComments)
                    .HasMaxLength(255)
                    .HasColumnName("Mass:Comments");

                entity.Property(e => e.MassFamily)
                    .HasMaxLength(255)
                    .HasColumnName("Mass:Family");

                entity.Property(e => e.MassFamilyandType)
                    .HasMaxLength(255)
                    .HasColumnName("Mass:FamilyandType");

                entity.Property(e => e.MassType)
                    .HasMaxLength(255)
                    .HasColumnName("Mass:Type");

                entity.Property(e => e.MassTypeComments)
                    .HasMaxLength(255)
                    .HasColumnName("Mass:TypeComments");

                entity.Property(e => e.SkylightWidthDepth).HasColumnName("SkylightWidth&Depth");

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.MassRoofs)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_MassRoof_DesignOption");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.MassRoofPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_MassRoof_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.MassRoofPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_MassRoof_PhaseDemolished");
            });

            modelBuilder.Entity<MassSkylight>(entity =>
            {
                entity.ToTable("MassSkylight");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.Property(e => e.MassComments)
                    .HasMaxLength(255)
                    .HasColumnName("Mass:Comments");

                entity.Property(e => e.MassFamily)
                    .HasMaxLength(255)
                    .HasColumnName("Mass:Family");

                entity.Property(e => e.MassFamilyandType)
                    .HasMaxLength(255)
                    .HasColumnName("Mass:FamilyandType");

                entity.Property(e => e.MassType)
                    .HasMaxLength(255)
                    .HasColumnName("Mass:Type");

                entity.Property(e => e.MassTypeComments)
                    .HasMaxLength(255)
                    .HasColumnName("Mass:TypeComments");

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.MassSkylights)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_MassSkylight_DesignOption");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.MassSkylightPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_MassSkylight_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.MassSkylightPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_MassSkylight_PhaseDemolished");
            });

            modelBuilder.Entity<MassType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.MassTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_MassTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.MassTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_MassTypes_OmniClassNumber");
            });

            modelBuilder.Entity<Material>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Grade).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Species).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");
            });

            modelBuilder.Entity<MaterialQuantity>(entity =>
            {
                entity.HasKey(e => new { e.ElementId, e.MaterialId, e.AsPaint });

                entity.HasOne(d => d.Material)
                    .WithMany(p => p.MaterialQuantities)
                    .HasForeignKey(d => d.MaterialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MaterialQuantities_MaterialId");
            });

            modelBuilder.Entity<MechanicalEquipment>(entity =>
            {
                entity.ToTable("MechanicalEquipment");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CircuitNumber).HasMaxLength(255);

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.Property(e => e.Panel).HasMaxLength(255);

                entity.Property(e => e.SystemClassification).HasMaxLength(255);

                entity.Property(e => e.SystemName).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.MechanicalEquipments)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_MechanicalEquipment_DesignOption");

                entity.HasOne(d => d.LevelNavigation)
                    .WithMany(p => p.MechanicalEquipments)
                    .HasForeignKey(d => d.Level)
                    .HasConstraintName("FK_MechanicalEquipment_Level");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.MechanicalEquipmentPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_MechanicalEquipment_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.MechanicalEquipmentPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_MechanicalEquipment_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.MechanicalEquipments)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_MechanicalEquipment_TypeId");
            });

            modelBuilder.Entity<MechanicalEquipmentOnWall>(entity =>
            {
                entity.ToTable("MechanicalEquipmentOnWall");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.HostName).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.HasOne(d => d.Host)
                    .WithMany(p => p.MechanicalEquipmentOnWalls)
                    .HasForeignKey(d => d.HostId)
                    .HasConstraintName("FK_MechanicalEquipmentOnWall_HostId");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.MechanicalEquipmentOnWall)
                    .HasForeignKey<MechanicalEquipmentOnWall>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MechanicalEquipmentOnWall_Id");
            });

            modelBuilder.Entity<MechanicalEquipmentType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.MechanicalEquipmentTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_MechanicalEquipmentTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.MechanicalEquipmentTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_MechanicalEquipmentTypes_OmniClassNumber");
            });

            modelBuilder.Entity<NeutralModeEnum>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<NurseCallDevice>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CircuitNumber).HasMaxLength(255);

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.ElectricalData).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.Property(e => e.Panel).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.NurseCallDevices)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_NurseCallDevices_DesignOption");

                entity.HasOne(d => d.LevelNavigation)
                    .WithMany(p => p.NurseCallDevices)
                    .HasForeignKey(d => d.Level)
                    .HasConstraintName("FK_NurseCallDevices_Level");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.NurseCallDevicePhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_NurseCallDevices_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.NurseCallDevicePhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_NurseCallDevices_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.NurseCallDevices)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_NurseCallDevices_TypeId");
            });

            modelBuilder.Entity<NurseCallDeviceType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.NurseCallDeviceTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_NurseCallDeviceTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.NurseCallDeviceTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_NurseCallDeviceTypes_OmniClassNumber");
            });

            modelBuilder.Entity<OmniClassNumber>(entity =>
            {
                entity.HasKey(e => e.OmniClassNumber1);

                entity.Property(e => e.OmniClassNumber1)
                    .HasMaxLength(255)
                    .HasColumnName("OmniClassNumber");

                entity.Property(e => e.OmniClassTitle).HasMaxLength(255);
            });

            modelBuilder.Entity<Opening>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<OpeningOnFloor>(entity =>
            {
                entity.ToTable("OpeningOnFloor");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.HostName).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.HasOne(d => d.Host)
                    .WithMany(p => p.OpeningOnFloors)
                    .HasForeignKey(d => d.HostId)
                    .HasConstraintName("FK_OpeningOnFloor_HostId");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.OpeningOnFloor)
                    .HasForeignKey<OpeningOnFloor>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OpeningOnFloor_Id");
            });

            modelBuilder.Entity<OpeningOnWall>(entity =>
            {
                entity.ToTable("OpeningOnWall");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.HostName).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.HasOne(d => d.Host)
                    .WithMany(p => p.OpeningOnWalls)
                    .HasForeignKey(d => d.HostId)
                    .HasConstraintName("FK_OpeningOnWall_HostId");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.OpeningOnWall)
                    .HasForeignKey<OpeningOnWall>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OpeningOnWall_Id");
            });

            modelBuilder.Entity<PanelScheduleTemplatesBranchPanel>(entity =>
            {
                entity.ToTable("PanelScheduleTemplatesBranchPanel");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.PanelScheduleTemplatesBranchPanels)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_PanelScheduleTemplatesBranchPanel_DesignOption");
            });

            modelBuilder.Entity<PanelScheduleTemplatesDataPanel>(entity =>
            {
                entity.ToTable("PanelScheduleTemplatesDataPanel");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.PanelScheduleTemplatesDataPanels)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_PanelScheduleTemplatesDataPanel_DesignOption");
            });

            modelBuilder.Entity<PanelScheduleTemplatesSwitchboard>(entity =>
            {
                entity.ToTable("PanelScheduleTemplatesSwitchboard");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.PanelScheduleTemplatesSwitchboards)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_PanelScheduleTemplatesSwitchboard_DesignOption");
            });

            modelBuilder.Entity<Parking>(entity =>
            {
                entity.ToTable("Parking");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.Parkings)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_Parking_DesignOption");

                entity.HasOne(d => d.LevelNavigation)
                    .WithMany(p => p.Parkings)
                    .HasForeignKey(d => d.Level)
                    .HasConstraintName("FK_Parking_Level");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.ParkingPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_Parking_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.ParkingPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_Parking_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Parkings)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_Parking_TypeId");
            });

            modelBuilder.Entity<ParkingType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.ParkingTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_ParkingTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.ParkingTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_ParkingTypes_OmniClassNumber");
            });

            modelBuilder.Entity<Phase>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<Pipe>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.InsulationType).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.Property(e => e.OverallSize).HasMaxLength(255);

                entity.Property(e => e.Size).HasMaxLength(255);

                entity.Property(e => e.SystemClassification).HasMaxLength(255);

                entity.Property(e => e.SystemName).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.Pipes)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_Pipes_DesignOption");

                entity.HasOne(d => d.FlowStateNavigation)
                    .WithMany(p => p.Pipes)
                    .HasForeignKey(d => d.FlowState)
                    .HasConstraintName("FK_Pipes_FlowState");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.PipePhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_Pipes_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.PipePhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_Pipes_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Pipes)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_Pipes_TypeId");
            });

            modelBuilder.Entity<PipeAccessory>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.InsulationType).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.Property(e => e.OverallSize).HasMaxLength(255);

                entity.Property(e => e.Size).HasMaxLength(255);

                entity.Property(e => e.SystemClassification).HasMaxLength(255);

                entity.Property(e => e.SystemName).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.PipeAccessories)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_PipeAccessories_DesignOption");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.PipeAccessoryPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_PipeAccessories_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.PipeAccessoryPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_PipeAccessories_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.PipeAccessories)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_PipeAccessories_TypeId");
            });

            modelBuilder.Entity<PipeAccessoryType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.PipeAccessoryTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_PipeAccessoryTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.PipeAccessoryTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_PipeAccessoryTypes_OmniClassNumber");
            });

            modelBuilder.Entity<PipeConnection>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.PipeConnections)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_PipeConnections_DesignOption");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.PipeConnectionPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_PipeConnections_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.PipeConnectionPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_PipeConnections_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.PipeConnections)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_PipeConnections_TypeId");
            });

            modelBuilder.Entity<PipeConnectionType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.PipeConnectionTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_PipeConnectionTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.PipeConnectionTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_PipeConnectionTypes_OmniClassNumber");
            });

            modelBuilder.Entity<PipeFitting>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.InsulationType).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.Property(e => e.OverallSize).HasMaxLength(255);

                entity.Property(e => e.Size).HasMaxLength(255);

                entity.Property(e => e.SystemClassification).HasMaxLength(255);

                entity.Property(e => e.SystemName).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.PipeFittings)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_PipeFittings_DesignOption");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.PipeFittingPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_PipeFittings_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.PipeFittingPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_PipeFittings_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.PipeFittings)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_PipeFittings_TypeId");
            });

            modelBuilder.Entity<PipeFittingType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.PipeFittingTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_PipeFittingTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.PipeFittingTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_PipeFittingTypes_OmniClassNumber");
            });

            modelBuilder.Entity<PipeFlowStateEnum>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<PipeInsulation>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.PipeInsulations)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_PipeInsulations_DesignOption");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.PipeInsulationPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_PipeInsulations_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.PipeInsulationPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_PipeInsulations_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.PipeInsulations)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_PipeInsulations_TypeId");
            });

            modelBuilder.Entity<PipeInsulationType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.PipeInsulationTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_PipeInsulationTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.PipeInsulationTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_PipeInsulationTypes_OmniClassNumber");
            });

            modelBuilder.Entity<PipeMaterial>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.PipeMaterials)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_PipeMaterials_DesignOption");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.PipeMaterialPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_PipeMaterials_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.PipeMaterialPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_PipeMaterials_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.PipeMaterials)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_PipeMaterials_TypeId");
            });

            modelBuilder.Entity<PipeMaterialType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.PipeMaterialTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_PipeMaterialTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.PipeMaterialTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_PipeMaterialTypes_OmniClassNumber");
            });

            modelBuilder.Entity<PipePlaceholder>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.InsulationType).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.Property(e => e.OverallSize).HasMaxLength(255);

                entity.Property(e => e.Size).HasMaxLength(255);

                entity.Property(e => e.SystemClassification).HasMaxLength(255);

                entity.Property(e => e.SystemName).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.PipePlaceholders)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_PipePlaceholders_DesignOption");

                entity.HasOne(d => d.FlowStateNavigation)
                    .WithMany(p => p.PipePlaceholders)
                    .HasForeignKey(d => d.FlowState)
                    .HasConstraintName("FK_PipePlaceholders_FlowState");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.PipePlaceholderPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_PipePlaceholders_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.PipePlaceholderPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_PipePlaceholders_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.PipePlaceholders)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_PipePlaceholders_TypeId");
            });

            modelBuilder.Entity<PipeSchedule>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.PipeSchedules)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_PipeSchedules_DesignOption");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.PipeSchedulePhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_PipeSchedules_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.PipeSchedulePhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_PipeSchedules_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.PipeSchedules)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_PipeSchedules_TypeId");
            });

            modelBuilder.Entity<PipeScheduleType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.PipeScheduleTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_PipeScheduleTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.PipeScheduleTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_PipeScheduleTypes_OmniClassNumber");
            });

            modelBuilder.Entity<PipeSegment>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ConnectionType).HasMaxLength(255);

                entity.Property(e => e.ScheduleType).HasColumnName("Schedule/Type");

                entity.Property(e => e.SegmentDescription).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.PipeSegments)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_PipeSegments_DesignOption");

                entity.HasOne(d => d.MaterialNavigation)
                    .WithMany(p => p.PipeSegments)
                    .HasForeignKey(d => d.Material)
                    .HasConstraintName("FK_PipeSegments_Material");
            });

            modelBuilder.Entity<PipeSystemTypeEnum>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<PipeType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.ScheduleType).HasColumnName("Schedule/Type");

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.PipeTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_PipeTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.PipeTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_PipeTypes_OmniClassNumber");
            });

            modelBuilder.Entity<PipingSystem>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.SystemEquipment).HasMaxLength(255);

                entity.Property(e => e.SystemName).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.PipingSystems)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_PipingSystems_DesignOption");
            });

            modelBuilder.Entity<PipingSystemType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Abbreviation).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.SystemClassification).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");
            });

            modelBuilder.Entity<Planting>(entity =>
            {
                entity.ToTable("Planting");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.Plantings)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_Planting_DesignOption");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.PlantingPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_Planting_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.PlantingPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_Planting_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Plantings)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_Planting_TypeId");
            });

            modelBuilder.Entity<PlantingType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.PlantingTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_PlantingTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.PlantingTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_PlantingTypes_OmniClassNumber");
            });

            modelBuilder.Entity<PlumbingFixture>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Drain).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.Property(e => e.SupplyFitting).HasMaxLength(255);

                entity.Property(e => e.SupplyPipe).HasMaxLength(255);

                entity.Property(e => e.SystemClassification).HasMaxLength(255);

                entity.Property(e => e.SystemName).HasMaxLength(255);

                entity.Property(e => e.Trap).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.PlumbingFixtures)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_PlumbingFixtures_DesignOption");

                entity.HasOne(d => d.LevelNavigation)
                    .WithMany(p => p.PlumbingFixtures)
                    .HasForeignKey(d => d.Level)
                    .HasConstraintName("FK_PlumbingFixtures_Level");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.PlumbingFixturePhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_PlumbingFixtures_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.PlumbingFixturePhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_PlumbingFixtures_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.PlumbingFixtures)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_PlumbingFixtures_TypeId");
            });

            modelBuilder.Entity<PlumbingFixtureOnWall>(entity =>
            {
                entity.ToTable("PlumbingFixtureOnWall");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.HostName).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.HasOne(d => d.Host)
                    .WithMany(p => p.PlumbingFixtureOnWalls)
                    .HasForeignKey(d => d.HostId)
                    .HasConstraintName("FK_PlumbingFixtureOnWall_HostId");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.PlumbingFixtureOnWall)
                    .HasForeignKey<PlumbingFixtureOnWall>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlumbingFixtureOnWall_Id");
            });

            modelBuilder.Entity<PlumbingFixtureType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Cwconnection).HasColumnName("CWConnection");

                entity.Property(e => e.Cwfu).HasColumnName("CWFU");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Hwconnection).HasColumnName("HWConnection");

                entity.Property(e => e.Hwfu).HasColumnName("HWFU");

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.Property(e => e.Wfu).HasColumnName("WFU");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.PlumbingFixtureTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_PlumbingFixtureTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.PlumbingFixtureTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_PlumbingFixtureTypes_OmniClassNumber");
            });

            modelBuilder.Entity<PointLoad>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Allnon0loads).HasMaxLength(255);

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.PointLoads)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_PointLoads_DesignOption");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.PointLoadPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_PointLoads_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.PointLoadPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_PointLoads_PhaseDemolished");
            });

            modelBuilder.Entity<PowerFactorStateTypeEnum>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<Profile>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.Profiles)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_Profiles_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.Profiles)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_Profiles_OmniClassNumber");
            });

            modelBuilder.Entity<ProjectInformation>(entity =>
            {
                entity.ToTable("ProjectInformation");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ClientName).HasMaxLength(255);

                entity.Property(e => e.ProjectAddress).HasMaxLength(255);

                entity.Property(e => e.ProjectIssueDate).HasMaxLength(255);

                entity.Property(e => e.ProjectName).HasMaxLength(255);

                entity.Property(e => e.ProjectNumber).HasMaxLength(255);

                entity.Property(e => e.ProjectStatus).HasMaxLength(255);
            });

            modelBuilder.Entity<PropertyLine>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.PropertyLines)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_PropertyLines_DesignOption");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.PropertyLines)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_PropertyLines_TypeId");
            });

            modelBuilder.Entity<PropertyLineType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.PropertyLineTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_PropertyLineTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.PropertyLineTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_PropertyLineTypes_OmniClassNumber");
            });

            modelBuilder.Entity<Railing>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.HasOne(d => d.BaseLevelNavigation)
                    .WithMany(p => p.Railings)
                    .HasForeignKey(d => d.BaseLevel)
                    .HasConstraintName("FK_Railings_BaseLevel");

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.Railings)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_Railings_DesignOption");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.RailingPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_Railings_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.RailingPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_Railings_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Railings)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_Railings_TypeId");
            });

            modelBuilder.Entity<RailingType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.RailingTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_RailingTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.RailingTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_RailingTypes_OmniClassNumber");
            });

            modelBuilder.Entity<Ramp>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.HasOne(d => d.BaseLevelNavigation)
                    .WithMany(p => p.RampBaseLevelNavigations)
                    .HasForeignKey(d => d.BaseLevel)
                    .HasConstraintName("FK_Ramps_BaseLevel");

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.Ramps)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_Ramps_DesignOption");

                entity.HasOne(d => d.MultistoryTopLevelNavigation)
                    .WithMany(p => p.RampMultistoryTopLevelNavigations)
                    .HasForeignKey(d => d.MultistoryTopLevel)
                    .HasConstraintName("FK_Ramps_MultistoryTopLevel");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.RampPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_Ramps_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.RampPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_Ramps_PhaseDemolished");

                entity.HasOne(d => d.TopLevelNavigation)
                    .WithMany(p => p.RampTopLevelNavigations)
                    .HasForeignKey(d => d.TopLevel)
                    .HasConstraintName("FK_Ramps_TopLevel");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Ramps)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_Ramps_TypeId");
            });

            modelBuilder.Entity<RampType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.RampTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_RampTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.RampTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_RampTypes_OmniClassNumber");
            });

            modelBuilder.Entity<RebarLayoutEnum>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<RebarOnColumn>(entity =>
            {
                entity.ToTable("RebarOnColumn");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.HostName).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.HasOne(d => d.Host)
                    .WithMany(p => p.RebarOnColumns)
                    .HasForeignKey(d => d.HostId)
                    .HasConstraintName("FK_RebarOnColumn_HostId");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.RebarOnColumn)
                    .HasForeignKey<RebarOnColumn>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RebarOnColumn_Id");
            });

            modelBuilder.Entity<RebarOnFloor>(entity =>
            {
                entity.ToTable("RebarOnFloor");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.HostName).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.HasOne(d => d.Host)
                    .WithMany(p => p.RebarOnFloors)
                    .HasForeignKey(d => d.HostId)
                    .HasConstraintName("FK_RebarOnFloor_HostId");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.RebarOnFloor)
                    .HasForeignKey<RebarOnFloor>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RebarOnFloor_Id");
            });

            modelBuilder.Entity<RebarOnFoundation>(entity =>
            {
                entity.ToTable("RebarOnFoundation");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.HostName).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.HasOne(d => d.Host)
                    .WithMany(p => p.RebarOnFoundations)
                    .HasForeignKey(d => d.HostId)
                    .HasConstraintName("FK_RebarOnFoundation_HostId");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.RebarOnFoundation)
                    .HasForeignKey<RebarOnFoundation>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RebarOnFoundation_Id");
            });

            modelBuilder.Entity<RebarOnFraming>(entity =>
            {
                entity.ToTable("RebarOnFraming");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.HostName).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.HasOne(d => d.Host)
                    .WithMany(p => p.RebarOnFramings)
                    .HasForeignKey(d => d.HostId)
                    .HasConstraintName("FK_RebarOnFraming_HostId");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.RebarOnFraming)
                    .HasForeignKey<RebarOnFraming>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RebarOnFraming_Id");
            });

            modelBuilder.Entity<RebarOnWall>(entity =>
            {
                entity.ToTable("RebarOnWall");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.HostName).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.HasOne(d => d.Host)
                    .WithMany(p => p.RebarOnWalls)
                    .HasForeignKey(d => d.HostId)
                    .HasConstraintName("FK_RebarOnWall_HostId");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.RebarOnWall)
                    .HasForeignKey<RebarOnWall>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RebarOnWall_Id");
            });

            modelBuilder.Entity<RebarStyleEnum>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<RevitDblinkInfo>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("RevitDBLinkInfo");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Value).HasMaxLength(255);
            });

            modelBuilder.Entity<Roof>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.HasOne(d => d.BaseLevelNavigation)
                    .WithMany(p => p.RoofBaseLevelNavigations)
                    .HasForeignKey(d => d.BaseLevel)
                    .HasConstraintName("FK_Roofs_BaseLevel");

                entity.HasOne(d => d.CutoffLevelNavigation)
                    .WithMany(p => p.RoofCutoffLevelNavigations)
                    .HasForeignKey(d => d.CutoffLevel)
                    .HasConstraintName("FK_Roofs_CutoffLevel");

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.Roofs)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_Roofs_DesignOption");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.RoofPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_Roofs_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.RoofPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_Roofs_PhaseDemolished");

                entity.HasOne(d => d.RafterCutNavigation)
                    .WithMany(p => p.Roofs)
                    .HasForeignKey(d => d.RafterCut)
                    .HasConstraintName("FK_Roofs_RafterCut");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Roofs)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_Roofs_TypeId");
            });

            modelBuilder.Entity<RoofType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.RoofTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_RoofTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.RoofTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_RoofTypes_OmniClassNumber");
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BaseFinish).HasMaxLength(255);

                entity.Property(e => e.CeilingFinish).HasMaxLength(255);

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Department).HasMaxLength(255);

                entity.Property(e => e.FloorFinish).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Number).HasMaxLength(255);

                entity.Property(e => e.Occupancy).HasMaxLength(255);

                entity.Property(e => e.Occupant).HasMaxLength(255);

                entity.Property(e => e.WallFinish).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.Rooms)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_Rooms_DesignOption");

                entity.HasOne(d => d.LevelNavigation)
                    .WithMany(p => p.Rooms)
                    .HasForeignKey(d => d.Level)
                    .HasConstraintName("FK_Rooms_Level");

                entity.HasOne(d => d.Phase)
                    .WithMany(p => p.Rooms)
                    .HasForeignKey(d => d.PhaseId)
                    .HasConstraintName("FK_Rooms_PhaseId");
            });

            modelBuilder.Entity<RoomAssociation>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.PhaseId, e.DesignOptionId });

                entity.HasOne(d => d.Phase)
                    .WithMany(p => p.RoomAssociations)
                    .HasForeignKey(d => d.PhaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RoomAssociations_PhaseId");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.RoomAssociations)
                    .HasForeignKey(d => d.RoomId)
                    .HasConstraintName("FK_RoomAssociations_RoomId");
            });

            modelBuilder.Entity<RoomFromToAssociation>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.PhaseId, e.DesignOptionId });

                entity.HasOne(d => d.FromRoomNavigation)
                    .WithMany(p => p.RoomFromToAssociationFromRoomNavigations)
                    .HasForeignKey(d => d.FromRoom)
                    .HasConstraintName("FK_RoomFromToAssociations_FromRoom");

                entity.HasOne(d => d.Phase)
                    .WithMany(p => p.RoomFromToAssociations)
                    .HasForeignKey(d => d.PhaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RoomFromToAssociations_PhaseId");

                entity.HasOne(d => d.ToRoomNavigation)
                    .WithMany(p => p.RoomFromToAssociationToRoomNavigations)
                    .HasForeignKey(d => d.ToRoom)
                    .HasConstraintName("FK_RoomFromToAssociations_ToRoom");
            });

            modelBuilder.Entity<RoomTag>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.RoomTagType).HasMaxLength(255);
            });

            modelBuilder.Entity<SecurityDevice>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CircuitNumber).HasMaxLength(255);

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.ElectricalData).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.Property(e => e.Panel).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.SecurityDevices)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_SecurityDevices_DesignOption");

                entity.HasOne(d => d.LevelNavigation)
                    .WithMany(p => p.SecurityDeviceLevelNavigations)
                    .HasForeignKey(d => d.Level)
                    .HasConstraintName("FK_SecurityDevices_Level");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.SecurityDevicePhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_SecurityDevices_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.SecurityDevicePhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_SecurityDevices_PhaseDemolished");

                entity.HasOne(d => d.ScheduleLevelNavigation)
                    .WithMany(p => p.SecurityDeviceScheduleLevelNavigations)
                    .HasForeignKey(d => d.ScheduleLevel)
                    .HasConstraintName("FK_SecurityDevices_ScheduleLevel");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.SecurityDevices)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_SecurityDevices_TypeId");
            });

            modelBuilder.Entity<SecurityDeviceType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.SecurityDeviceTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_SecurityDeviceTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.SecurityDeviceTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_SecurityDeviceTypes_OmniClassNumber");
            });

            modelBuilder.Entity<ServiceTypeEnum>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<Sheet>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ApprovedBy).HasMaxLength(255);

                entity.Property(e => e.AssemblyAssemblyCode)
                    .HasMaxLength(255)
                    .HasColumnName("Assembly:AssemblyCode");

                entity.Property(e => e.AssemblyAssemblyDescription)
                    .HasMaxLength(255)
                    .HasColumnName("Assembly:AssemblyDescription");

                entity.Property(e => e.AssemblyCost).HasColumnName("Assembly:Cost");

                entity.Property(e => e.AssemblyDescription)
                    .HasMaxLength(255)
                    .HasColumnName("Assembly:Description");

                entity.Property(e => e.AssemblyKeynote)
                    .HasMaxLength(255)
                    .HasColumnName("Assembly:Keynote");

                entity.Property(e => e.AssemblyManufacturer)
                    .HasMaxLength(255)
                    .HasColumnName("Assembly:Manufacturer");

                entity.Property(e => e.AssemblyModel)
                    .HasMaxLength(255)
                    .HasColumnName("Assembly:Model");

                entity.Property(e => e.AssemblyName)
                    .HasMaxLength(255)
                    .HasColumnName("Assembly:Name");

                entity.Property(e => e.AssemblyTypeComments)
                    .HasMaxLength(255)
                    .HasColumnName("Assembly:TypeComments");

                entity.Property(e => e.AssemblyTypeMark)
                    .HasMaxLength(255)
                    .HasColumnName("Assembly:TypeMark");

                entity.Property(e => e.AssemblyUrl)
                    .HasMaxLength(255)
                    .HasColumnName("Assembly:URL");

                entity.Property(e => e.CheckedBy).HasMaxLength(255);

                entity.Property(e => e.CurrentRevision).HasMaxLength(255);

                entity.Property(e => e.CurrentRevisionDate).HasMaxLength(255);

                entity.Property(e => e.CurrentRevisionDescription).HasMaxLength(255);

                entity.Property(e => e.CurrentRevisionIssuedBy).HasMaxLength(255);

                entity.Property(e => e.CurrentRevisionIssuedTo).HasMaxLength(255);

                entity.Property(e => e.Dependency).HasMaxLength(255);

                entity.Property(e => e.DesignedBy).HasMaxLength(255);

                entity.Property(e => e.DrawnBy).HasMaxLength(255);

                entity.Property(e => e.FilePath).HasMaxLength(255);

                entity.Property(e => e.ReferencingDetail).HasMaxLength(255);

                entity.Property(e => e.ReferencingSheet).HasMaxLength(255);

                entity.Property(e => e.Scale).HasMaxLength(255);

                entity.Property(e => e.SheetIssueDate).HasMaxLength(255);

                entity.Property(e => e.SheetName).HasMaxLength(255);

                entity.Property(e => e.SheetNumber).HasMaxLength(255);
            });

            modelBuilder.Entity<Site>(entity =>
            {
                entity.ToTable("Site");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.Sites)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_Site_DesignOption");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.SitePhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_Site_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.SitePhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_Site_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Sites)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_Site_TypeId");
            });

            modelBuilder.Entity<SiteType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.SiteTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_SiteTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.SiteTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_SiteTypes_OmniClassNumber");
            });

            modelBuilder.Entity<SlabEdge>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.SlabEdges)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_SlabEdges_DesignOption");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.SlabEdgePhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_SlabEdges_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.SlabEdgePhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_SlabEdges_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.SlabEdges)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_SlabEdges_TypeId");
            });

            modelBuilder.Entity<SlabEdgeType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.SlabEdgeTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_SlabEdgeTypes_AssemblyCode");

                entity.HasOne(d => d.MaterialNavigation)
                    .WithMany(p => p.SlabEdgeTypes)
                    .HasForeignKey(d => d.Material)
                    .HasConstraintName("FK_SlabEdgeTypes_Material");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.SlabEdgeTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_SlabEdgeTypes_OmniClassNumber");

                entity.HasOne(d => d.ProfileNavigation)
                    .WithMany(p => p.SlabEdgeTypes)
                    .HasForeignKey(d => d.Profile)
                    .HasConstraintName("FK_SlabEdgeTypes_Profile");
            });

            modelBuilder.Entity<Space>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.DesignHvacloadperarea).HasColumnName("DesignHVACLoadperarea");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Number).HasMaxLength(255);

                entity.Property(e => e.RoomName).HasMaxLength(255);

                entity.Property(e => e.RoomNumber).HasMaxLength(255);

                entity.HasOne(d => d.ConditionTypeNavigation)
                    .WithMany(p => p.Spaces)
                    .HasForeignKey(d => d.ConditionType)
                    .HasConstraintName("FK_Spaces_ConditionType");

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.Spaces)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_Spaces_DesignOption");

                entity.HasOne(d => d.LevelNavigation)
                    .WithMany(p => p.Spaces)
                    .HasForeignKey(d => d.Level)
                    .HasConstraintName("FK_Spaces_Level");

                entity.HasOne(d => d.Phase)
                    .WithMany(p => p.Spaces)
                    .HasForeignKey(d => d.PhaseId)
                    .HasConstraintName("FK_Spaces_PhaseId");

                entity.HasOne(d => d.SpaceTypeNavigation)
                    .WithMany(p => p.Spaces)
                    .HasForeignKey(d => d.SpaceType)
                    .HasConstraintName("FK_Spaces_SpaceType");
            });

            modelBuilder.Entity<SpaceAssociation>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.PhaseId, e.DesignOptionId });

                entity.HasOne(d => d.Phase)
                    .WithMany(p => p.SpaceAssociations)
                    .HasForeignKey(d => d.PhaseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SpaceAssociations_PhaseId");

                entity.HasOne(d => d.Space)
                    .WithMany(p => p.SpaceAssociations)
                    .HasForeignKey(d => d.SpaceId)
                    .HasConstraintName("FK_SpaceAssociations_SpaceId");
            });

            modelBuilder.Entity<SpaceTypeEnum>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<SpaceTypeSetting>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.SpaceTypeSettings)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_SpaceTypeSettings_DesignOption");
            });

            modelBuilder.Entity<SpecialtyEquipment>(entity =>
            {
                entity.ToTable("SpecialtyEquipment");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CircuitNumber).HasMaxLength(255);

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.Property(e => e.Panel).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.SpecialtyEquipments)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_SpecialtyEquipment_DesignOption");

                entity.HasOne(d => d.LevelNavigation)
                    .WithMany(p => p.SpecialtyEquipments)
                    .HasForeignKey(d => d.Level)
                    .HasConstraintName("FK_SpecialtyEquipment_Level");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.SpecialtyEquipmentPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_SpecialtyEquipment_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.SpecialtyEquipmentPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_SpecialtyEquipment_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.SpecialtyEquipments)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_SpecialtyEquipment_TypeId");
            });

            modelBuilder.Entity<SpecialtyEquipmentType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.SpecialtyEquipmentTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_SpecialtyEquipmentTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.SpecialtyEquipmentTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_SpecialtyEquipmentTypes_OmniClassNumber");
            });

            modelBuilder.Entity<Sprinkler>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.Property(e => e.SystemClassification).HasMaxLength(255);

                entity.Property(e => e.SystemName).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.Sprinklers)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_Sprinklers_DesignOption");

                entity.HasOne(d => d.LevelNavigation)
                    .WithMany(p => p.Sprinklers)
                    .HasForeignKey(d => d.Level)
                    .HasConstraintName("FK_Sprinklers_Level");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.SprinklerPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_Sprinklers_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.SprinklerPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_Sprinklers_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Sprinklers)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_Sprinklers_TypeId");
            });

            modelBuilder.Entity<SprinklerType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.KFactor).HasColumnName("K-Factor");

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.SprinklerTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_SprinklerTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.SprinklerTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_SprinklerTypes_OmniClassNumber");
            });

            modelBuilder.Entity<Stair>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.HasOne(d => d.BaseLevelNavigation)
                    .WithMany(p => p.StairBaseLevelNavigations)
                    .HasForeignKey(d => d.BaseLevel)
                    .HasConstraintName("FK_Stairs_BaseLevel");

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.Stairs)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_Stairs_DesignOption");

                entity.HasOne(d => d.MultistoryTopLevelNavigation)
                    .WithMany(p => p.StairMultistoryTopLevelNavigations)
                    .HasForeignKey(d => d.MultistoryTopLevel)
                    .HasConstraintName("FK_Stairs_MultistoryTopLevel");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.StairPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_Stairs_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.StairPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_Stairs_PhaseDemolished");

                entity.HasOne(d => d.TopLevelNavigation)
                    .WithMany(p => p.StairTopLevelNavigations)
                    .HasForeignKey(d => d.TopLevel)
                    .HasConstraintName("FK_Stairs_TopLevel");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Stairs)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_Stairs_TypeId");
            });

            modelBuilder.Entity<StairType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.StairTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_StairTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.StairTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_StairTypes_OmniClassNumber");
            });

            modelBuilder.Entity<StructuralColumn>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.HasOne(d => d.BaseLevelNavigation)
                    .WithMany(p => p.StructuralColumnBaseLevelNavigations)
                    .HasForeignKey(d => d.BaseLevel)
                    .HasConstraintName("FK_StructuralColumns_BaseLevel");

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.StructuralColumns)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_StructuralColumns_DesignOption");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.StructuralColumnPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_StructuralColumns_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.StructuralColumnPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_StructuralColumns_PhaseDemolished");

                entity.HasOne(d => d.TopLevelNavigation)
                    .WithMany(p => p.StructuralColumnTopLevelNavigations)
                    .HasForeignKey(d => d.TopLevel)
                    .HasConstraintName("FK_StructuralColumns_TopLevel");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.StructuralColumns)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_StructuralColumns_TypeId");
            });

            modelBuilder.Entity<StructuralColumnType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.StructuralColumnTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_StructuralColumnTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.StructuralColumnTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_StructuralColumnTypes_OmniClassNumber");
            });

            modelBuilder.Entity<StructuralFabricReinforcement>(entity =>
            {
                entity.ToTable("StructuralFabricReinforcement");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.FabricNumber).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.Property(e => e.Partition).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.StructuralFabricReinforcements)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_StructuralFabricReinforcement_DesignOption");

                entity.HasOne(d => d.LocationNavigation)
                    .WithMany(p => p.StructuralFabricReinforcements)
                    .HasForeignKey(d => d.Location)
                    .HasConstraintName("FK_StructuralFabricReinforcement_Location");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.StructuralFabricReinforcementPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_StructuralFabricReinforcement_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.StructuralFabricReinforcementPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_StructuralFabricReinforcement_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.StructuralFabricReinforcements)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_StructuralFabricReinforcement_TypeId");
            });

            modelBuilder.Entity<StructuralFabricReinforcementType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.PhysicalMaterialAsset).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.StructuralFabricReinforcementTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_StructuralFabricReinforcementTypes_AssemblyCode");

                entity.HasOne(d => d.MaterialNavigation)
                    .WithMany(p => p.StructuralFabricReinforcementTypes)
                    .HasForeignKey(d => d.Material)
                    .HasConstraintName("FK_StructuralFabricReinforcementTypes_Material");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.StructuralFabricReinforcementTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_StructuralFabricReinforcementTypes_OmniClassNumber");
            });

            modelBuilder.Entity<StructuralFoundation>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.StructuralFoundations)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_StructuralFoundations_DesignOption");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.StructuralFoundationPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_StructuralFoundations_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.StructuralFoundationPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_StructuralFoundations_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.StructuralFoundations)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_StructuralFoundations_TypeId");
            });

            modelBuilder.Entity<StructuralFoundationType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.StructuralFoundationTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_StructuralFoundationTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.StructuralFoundationTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_StructuralFoundationTypes_OmniClassNumber");
            });

            modelBuilder.Entity<StructuralFraming>(entity =>
            {
                entity.ToTable("StructuralFraming");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.StructuralFramings)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_StructuralFraming_DesignOption");

                entity.HasOne(d => d.LevelNavigation)
                    .WithMany(p => p.StructuralFramingLevelNavigations)
                    .HasForeignKey(d => d.Level)
                    .HasConstraintName("FK_StructuralFraming_Level");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.StructuralFramingPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_StructuralFraming_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.StructuralFramingPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_StructuralFraming_PhaseDemolished");

                entity.HasOne(d => d.ReferenceLevelNavigation)
                    .WithMany(p => p.StructuralFramingReferenceLevelNavigations)
                    .HasForeignKey(d => d.ReferenceLevel)
                    .HasConstraintName("FK_StructuralFraming_ReferenceLevel");

                entity.HasOne(d => d.StructuralUsageNavigation)
                    .WithMany(p => p.StructuralFramings)
                    .HasForeignKey(d => d.StructuralUsage)
                    .HasConstraintName("FK_StructuralFraming_StructuralUsage");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.StructuralFramings)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_StructuralFraming_TypeId");
            });

            modelBuilder.Entity<StructuralFramingType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.StructuralFramingTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_StructuralFramingTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.StructuralFramingTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_StructuralFramingTypes_OmniClassNumber");
            });

            modelBuilder.Entity<StructuralRebar>(entity =>
            {
                entity.ToTable("StructuralRebar");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.Property(e => e.ScheduleMark).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.StructuralRebars)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_StructuralRebar_DesignOption");

                entity.HasOne(d => d.HookAtEndNavigation)
                    .WithMany(p => p.StructuralRebarHookAtEndNavigations)
                    .HasForeignKey(d => d.HookAtEnd)
                    .HasConstraintName("FK_StructuralRebar_HookAtEnd");

                entity.HasOne(d => d.HookAtStartNavigation)
                    .WithMany(p => p.StructuralRebarHookAtStartNavigations)
                    .HasForeignKey(d => d.HookAtStart)
                    .HasConstraintName("FK_StructuralRebar_HookAtStart");

                entity.HasOne(d => d.LayoutRuleNavigation)
                    .WithMany(p => p.StructuralRebars)
                    .HasForeignKey(d => d.LayoutRule)
                    .HasConstraintName("FK_StructuralRebar_LayoutRule");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.StructuralRebarPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_StructuralRebar_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.StructuralRebarPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_StructuralRebar_PhaseDemolished");

                entity.HasOne(d => d.ShapeNavigation)
                    .WithMany(p => p.StructuralRebars)
                    .HasForeignKey(d => d.Shape)
                    .HasConstraintName("FK_StructuralRebar_Shape");

                entity.HasOne(d => d.StyleNavigation)
                    .WithMany(p => p.StructuralRebars)
                    .HasForeignKey(d => d.Style)
                    .HasConstraintName("FK_StructuralRebar_Style");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.StructuralRebars)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_StructuralRebar_TypeId");
            });

            modelBuilder.Entity<StructuralRebarBarType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.StirrupTieBendDiameter).HasColumnName("Stirrup/TieBendDiameter");

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.StructuralRebarBarTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_StructuralRebarBarTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.StructuralRebarBarTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_StructuralRebarBarTypes_OmniClassNumber");
            });

            modelBuilder.Entity<StructuralRebarHookType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.StructuralRebarHookTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_StructuralRebarHookTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.StructuralRebarHookTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_StructuralRebarHookTypes_OmniClassNumber");
            });

            modelBuilder.Entity<StructuralRebarShape>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.StructuralRebarShapes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_StructuralRebarShapes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.StructuralRebarShapes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_StructuralRebarShapes_OmniClassNumber");
            });

            modelBuilder.Entity<StructuralStiffener>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.StructuralStiffeners)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_StructuralStiffeners_DesignOption");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.StructuralStiffenerPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_StructuralStiffeners_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.StructuralStiffenerPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_StructuralStiffeners_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.StructuralStiffeners)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_StructuralStiffeners_TypeId");
            });

            modelBuilder.Entity<StructuralStiffenerType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.StructuralStiffenerTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_StructuralStiffenerTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.StructuralStiffenerTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_StructuralStiffenerTypes_OmniClassNumber");
            });

            modelBuilder.Entity<StructuralTruss>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.StructuralTrusses)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_StructuralTrusses_DesignOption");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.StructuralTrussPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_StructuralTrusses_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.StructuralTrussPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_StructuralTrusses_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.StructuralTrusses)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_StructuralTrusses_TypeId");
            });

            modelBuilder.Entity<StructuralTrussType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.StructuralTrussTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_StructuralTrussTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.StructuralTrussTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_StructuralTrussTypes_OmniClassNumber");
            });

            modelBuilder.Entity<SwitchSystem>(entity =>
            {
                entity.ToTable("SwitchSystem");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.SwitchId)
                    .HasMaxLength(255)
                    .HasColumnName("SwitchID");

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.SwitchSystems)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_SwitchSystem_DesignOption");
            });

            modelBuilder.Entity<TelephoneDevice>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CircuitNumber).HasMaxLength(255);

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.ElectricalData).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.Property(e => e.Panel).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.TelephoneDevices)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_TelephoneDevices_DesignOption");

                entity.HasOne(d => d.LevelNavigation)
                    .WithMany(p => p.TelephoneDevices)
                    .HasForeignKey(d => d.Level)
                    .HasConstraintName("FK_TelephoneDevices_Level");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.TelephoneDevicePhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_TelephoneDevices_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.TelephoneDevicePhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_TelephoneDevices_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.TelephoneDevices)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_TelephoneDevices_TypeId");
            });

            modelBuilder.Entity<TelephoneDeviceType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.TelephoneDeviceTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_TelephoneDeviceTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.TelephoneDeviceTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_TelephoneDeviceTypes_OmniClassNumber");
            });

            modelBuilder.Entity<Topography>(entity =>
            {
                entity.ToTable("Topography");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.NetcutFill).HasColumnName("Netcut/fill");

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.Topographies)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_Topography_DesignOption");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.TopographyPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_Topography_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.TopographyPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_Topography_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Topographies)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_Topography_TypeId");
            });

            modelBuilder.Entity<TopographyType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.TopographyTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_TopographyTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.TopographyTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_TopographyTypes_OmniClassNumber");
            });

            modelBuilder.Entity<View>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssociatedLevel).HasMaxLength(255);

                entity.Property(e => e.DisplayName).HasMaxLength(255);

                entity.Property(e => e.Family).HasMaxLength(255);

                entity.Property(e => e.FamilyandType).HasMaxLength(255);

                entity.Property(e => e.ScaleValue1).HasColumnName("ScaleValue1:");

                entity.Property(e => e.SheetName).HasMaxLength(255);

                entity.Property(e => e.SheetNumber).HasMaxLength(255);

                entity.Property(e => e.TitleonSheet).HasMaxLength(255);

                entity.Property(e => e.ViewName).HasMaxLength(255);

                entity.HasOne(d => d.PhaseNavigation)
                    .WithMany(p => p.Views)
                    .HasForeignKey(d => d.Phase)
                    .HasConstraintName("FK_Views_Phase");
            });

            modelBuilder.Entity<Voltage>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.Voltages)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_Voltages_DesignOption");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.VoltagePhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_Voltages_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.VoltagePhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_Voltages_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Voltages)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_Voltages_TypeId");
            });

            modelBuilder.Entity<VoltageType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.VoltageTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_VoltageTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.VoltageTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_VoltageTypes_OmniClassNumber");
            });

            modelBuilder.Entity<Wall>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.HasOne(d => d.BaseConstraintNavigation)
                    .WithMany(p => p.WallBaseConstraintNavigations)
                    .HasForeignKey(d => d.BaseConstraint)
                    .HasConstraintName("FK_Walls_BaseConstraint");

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.Walls)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_Walls_DesignOption");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.WallPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_Walls_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.WallPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_Walls_PhaseDemolished");

                entity.HasOne(d => d.StructuralUsageNavigation)
                    .WithMany(p => p.Walls)
                    .HasForeignKey(d => d.StructuralUsage)
                    .HasConstraintName("FK_Walls_StructuralUsage");

                entity.HasOne(d => d.TopConstraintNavigation)
                    .WithMany(p => p.WallTopConstraintNavigations)
                    .HasForeignKey(d => d.TopConstraint)
                    .HasConstraintName("FK_Walls_TopConstraint");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Walls)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_Walls_TypeId");
            });

            modelBuilder.Entity<WallSweep>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.WallSweeps)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_WallSweeps_DesignOption");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.WallSweepPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_WallSweeps_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.WallSweepPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_WallSweeps_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.WallSweeps)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_WallSweeps_TypeId");
            });

            modelBuilder.Entity<WallSweepType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.WallSweepTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_WallSweepTypes_AssemblyCode");

                entity.HasOne(d => d.MaterialNavigation)
                    .WithMany(p => p.WallSweepTypes)
                    .HasForeignKey(d => d.Material)
                    .HasConstraintName("FK_WallSweepTypes_Material");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.WallSweepTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_WallSweepTypes_OmniClassNumber");

                entity.HasOne(d => d.ProfileNavigation)
                    .WithMany(p => p.WallSweepTypes)
                    .HasForeignKey(d => d.Profile)
                    .HasConstraintName("FK_WallSweepTypes_Profile");
            });

            modelBuilder.Entity<WallType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.FireRating).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.WallTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_WallTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.WallTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_WallTypes_OmniClassNumber");
            });

            modelBuilder.Entity<WallUsageEnum>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<Window>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.Windows)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_Windows_DesignOption");

                entity.HasOne(d => d.LevelNavigation)
                    .WithMany(p => p.Windows)
                    .HasForeignKey(d => d.Level)
                    .HasConstraintName("FK_Windows_Level");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.WindowPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_Windows_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.WindowPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_Windows_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Windows)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_Windows_TypeId");
            });

            modelBuilder.Entity<WindowType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.ConstructionType).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.Operation).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.WindowTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_WindowTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.WindowTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_WindowTypes_OmniClassNumber");
            });

            modelBuilder.Entity<WindowWall>(entity =>
            {
                entity.HasKey(e => e.WindowId);

                entity.ToTable("WindowWall");

                entity.Property(e => e.WindowId).ValueGeneratedNever();

                entity.Property(e => e.WallName).HasMaxLength(255);

                entity.Property(e => e.WindowName).HasMaxLength(255);

                entity.HasOne(d => d.Wall)
                    .WithMany(p => p.WindowWalls)
                    .HasForeignKey(d => d.WallId)
                    .HasConstraintName("FK_WindowWall_WallId");

                entity.HasOne(d => d.Window)
                    .WithOne(p => p.WindowWall)
                    .HasForeignKey<WindowWall>(d => d.WindowId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WindowWall_WindowId");
            });

            modelBuilder.Entity<Wire>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CircuitDescription).HasMaxLength(255);

                entity.Property(e => e.CircuitLoadName).HasMaxLength(255);

                entity.Property(e => e.Circuits).HasMaxLength(255);

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.Property(e => e.Panel).HasMaxLength(255);

                entity.Property(e => e.WireSize).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.Wires)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_Wires_DesignOption");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.WirePhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_Wires_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.WirePhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_Wires_PhaseDemolished");

                entity.HasOne(d => d.TypeNavigation)
                    .WithMany(p => p.Wires)
                    .HasForeignKey(d => d.Type)
                    .HasConstraintName("FK_Wires_Type");

                entity.HasOne(d => d.Type1)
                    .WithMany(p => p.Wires)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_Wires_TypeId");
            });

            modelBuilder.Entity<WireInsulation>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.WireInsulations)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_WireInsulations_DesignOption");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.WireInsulationPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_WireInsulations_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.WireInsulationPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_WireInsulations_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.WireInsulations)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_WireInsulations_TypeId");
            });

            modelBuilder.Entity<WireInsulationType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.WireInsulationTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_WireInsulationTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.WireInsulationTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_WireInsulationTypes_OmniClassNumber");
            });

            modelBuilder.Entity<WireMaterial>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.WireMaterials)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_WireMaterials_DesignOption");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.WireMaterialPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_WireMaterials_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.WireMaterialPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_WireMaterials_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.WireMaterials)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_WireMaterials_TypeId");
            });

            modelBuilder.Entity<WireMaterialType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.WireMaterialTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_WireMaterialTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.WireMaterialTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_WireMaterialTypes_OmniClassNumber");
            });

            modelBuilder.Entity<WireTemperatureRating>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Mark).HasMaxLength(255);

                entity.HasOne(d => d.DesignOptionNavigation)
                    .WithMany(p => p.WireTemperatureRatings)
                    .HasForeignKey(d => d.DesignOption)
                    .HasConstraintName("FK_WireTemperatureRatings_DesignOption");

                entity.HasOne(d => d.PhaseCreatedNavigation)
                    .WithMany(p => p.WireTemperatureRatingPhaseCreatedNavigations)
                    .HasForeignKey(d => d.PhaseCreated)
                    .HasConstraintName("FK_WireTemperatureRatings_PhaseCreated");

                entity.HasOne(d => d.PhaseDemolishedNavigation)
                    .WithMany(p => p.WireTemperatureRatingPhaseDemolishedNavigations)
                    .HasForeignKey(d => d.PhaseDemolished)
                    .HasConstraintName("FK_WireTemperatureRatings_PhaseDemolished");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.WireTemperatureRatings)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_WireTemperatureRatings_TypeId");
            });

            modelBuilder.Entity<WireTemperatureRatingType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.WireTemperatureRatingTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_WireTemperatureRatingTypes_AssemblyCode");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.WireTemperatureRatingTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_WireTemperatureRatingTypes_OmniClassNumber");
            });

            modelBuilder.Entity<WireType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssemblyCode).HasMaxLength(255);

                entity.Property(e => e.ConduitType).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FamilyName).HasMaxLength(255);

                entity.Property(e => e.Keynote).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.MaxSize).HasMaxLength(255);

                entity.Property(e => e.Model).HasMaxLength(255);

                entity.Property(e => e.OmniClassNumber).HasMaxLength(255);

                entity.Property(e => e.TypeComments).HasMaxLength(255);

                entity.Property(e => e.TypeMark).HasMaxLength(255);

                entity.Property(e => e.TypeName).HasMaxLength(255);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .HasColumnName("URL");

                entity.HasOne(d => d.AssemblyCodeNavigation)
                    .WithMany(p => p.WireTypes)
                    .HasForeignKey(d => d.AssemblyCode)
                    .HasConstraintName("FK_WireTypes_AssemblyCode");

                entity.HasOne(d => d.NeutralSizeNavigation)
                    .WithMany(p => p.WireTypes)
                    .HasForeignKey(d => d.NeutralSize)
                    .HasConstraintName("FK_WireTypes_NeutralSize");

                entity.HasOne(d => d.OmniClassNumberNavigation)
                    .WithMany(p => p.WireTypes)
                    .HasForeignKey(d => d.OmniClassNumber)
                    .HasConstraintName("FK_WireTypes_OmniClassNumber");
            });

            modelBuilder.Entity<WiringTypeEnum>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
