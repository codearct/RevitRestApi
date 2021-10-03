using Core.Entities;
using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class Level
    {
        public Level()
        {
            Areas = new HashSet<Area>();
            Caseworks = new HashSet<Casework>();
            Ceilings = new HashSet<Ceiling>();
            Columns1BaseLevelNavigations = new HashSet<Columns1>();
            Columns1TopLevelNavigations = new HashSet<Columns1>();
            CommunicationDevices = new HashSet<CommunicationDevice>();
            DataDevices = new HashSet<DataDevice>();
            Doors = new HashSet<Door>();
            ElectricalEquipments = new HashSet<ElectricalEquipment>();
            ElectricalFixtures = new HashSet<ElectricalFixture>();
            ElementLevels = new HashSet<ElementLevel>();
            FireAlarmDevices = new HashSet<FireAlarmDevice>();
            Floors = new HashSet<Floor>();
            FurnitureSystems = new HashSet<FurnitureSystem>();
            Furnitures = new HashSet<Furniture>();
            GenericModels = new HashSet<GenericModel>();
            LightingDevices = new HashSet<LightingDevice>();
            LightingFixtures = new HashSet<LightingFixture>();
            MechanicalEquipments = new HashSet<MechanicalEquipment>();
            NurseCallDevices = new HashSet<NurseCallDevice>();
            Parkings = new HashSet<Parking>();
            PlumbingFixtures = new HashSet<PlumbingFixture>();
            Railings = new HashSet<Railing>();
            RampBaseLevelNavigations = new HashSet<Ramp>();
            RampMultistoryTopLevelNavigations = new HashSet<Ramp>();
            RampTopLevelNavigations = new HashSet<Ramp>();
            RoofBaseLevelNavigations = new HashSet<Roof>();
            RoofCutoffLevelNavigations = new HashSet<Roof>();
            Rooms = new HashSet<Room>();
            SecurityDeviceLevelNavigations = new HashSet<SecurityDevice>();
            SecurityDeviceScheduleLevelNavigations = new HashSet<SecurityDevice>();
            Spaces = new HashSet<Space>();
            SpecialtyEquipments = new HashSet<SpecialtyEquipment>();
            Sprinklers = new HashSet<Sprinkler>();
            StairBaseLevelNavigations = new HashSet<Stair>();
            StairMultistoryTopLevelNavigations = new HashSet<Stair>();
            StairTopLevelNavigations = new HashSet<Stair>();
            StructuralColumnBaseLevelNavigations = new HashSet<StructuralColumn>();
            StructuralColumnTopLevelNavigations = new HashSet<StructuralColumn>();
            StructuralFramingLevelNavigations = new HashSet<StructuralFraming>();
            StructuralFramingReferenceLevelNavigations = new HashSet<StructuralFraming>();
            TelephoneDevices = new HashSet<TelephoneDevice>();
            WallBaseConstraintNavigations = new HashSet<Wall>();
            WallTopConstraintNavigations = new HashSet<Wall>();
            Windows = new HashSet<Window>();
        }

        public int Id { get; set; }
        public int? TypeId { get; set; }
        public int? DesignOption { get; set; }
        public string Name { get; set; }
        public double? Elevation { get; set; }

        public virtual DesignOption DesignOptionNavigation { get; set; }
        public virtual LevelType Type { get; set; }
        public virtual ICollection<Area> Areas { get; set; }
        public virtual ICollection<Casework> Caseworks { get; set; }
        public virtual ICollection<Ceiling> Ceilings { get; set; }
        public virtual ICollection<Columns1> Columns1BaseLevelNavigations { get; set; }
        public virtual ICollection<Columns1> Columns1TopLevelNavigations { get; set; }
        public virtual ICollection<CommunicationDevice> CommunicationDevices { get; set; }
        public virtual ICollection<DataDevice> DataDevices { get; set; }
        public virtual ICollection<Door> Doors { get; set; }
        public virtual ICollection<ElectricalEquipment> ElectricalEquipments { get; set; }
        public virtual ICollection<ElectricalFixture> ElectricalFixtures { get; set; }
        public virtual ICollection<ElementLevel> ElementLevels { get; set; }
        public virtual ICollection<FireAlarmDevice> FireAlarmDevices { get; set; }
        public virtual ICollection<Floor> Floors { get; set; }
        public virtual ICollection<FurnitureSystem> FurnitureSystems { get; set; }
        public virtual ICollection<Furniture> Furnitures { get; set; }
        public virtual ICollection<GenericModel> GenericModels { get; set; }
        public virtual ICollection<LightingDevice> LightingDevices { get; set; }
        public virtual ICollection<LightingFixture> LightingFixtures { get; set; }
        public virtual ICollection<MechanicalEquipment> MechanicalEquipments { get; set; }
        public virtual ICollection<NurseCallDevice> NurseCallDevices { get; set; }
        public virtual ICollection<Parking> Parkings { get; set; }
        public virtual ICollection<PlumbingFixture> PlumbingFixtures { get; set; }
        public virtual ICollection<Railing> Railings { get; set; }
        public virtual ICollection<Ramp> RampBaseLevelNavigations { get; set; }
        public virtual ICollection<Ramp> RampMultistoryTopLevelNavigations { get; set; }
        public virtual ICollection<Ramp> RampTopLevelNavigations { get; set; }
        public virtual ICollection<Roof> RoofBaseLevelNavigations { get; set; }
        public virtual ICollection<Roof> RoofCutoffLevelNavigations { get; set; }
        public virtual ICollection<Room> Rooms { get; set; }
        public virtual ICollection<SecurityDevice> SecurityDeviceLevelNavigations { get; set; }
        public virtual ICollection<SecurityDevice> SecurityDeviceScheduleLevelNavigations { get; set; }
        public virtual ICollection<Space> Spaces { get; set; }
        public virtual ICollection<SpecialtyEquipment> SpecialtyEquipments { get; set; }
        public virtual ICollection<Sprinkler> Sprinklers { get; set; }
        public virtual ICollection<Stair> StairBaseLevelNavigations { get; set; }
        public virtual ICollection<Stair> StairMultistoryTopLevelNavigations { get; set; }
        public virtual ICollection<Stair> StairTopLevelNavigations { get; set; }
        public virtual ICollection<StructuralColumn> StructuralColumnBaseLevelNavigations { get; set; }
        public virtual ICollection<StructuralColumn> StructuralColumnTopLevelNavigations { get; set; }
        public virtual ICollection<StructuralFraming> StructuralFramingLevelNavigations { get; set; }
        public virtual ICollection<StructuralFraming> StructuralFramingReferenceLevelNavigations { get; set; }
        public virtual ICollection<TelephoneDevice> TelephoneDevices { get; set; }
        public virtual ICollection<Wall> WallBaseConstraintNavigations { get; set; }
        public virtual ICollection<Wall> WallTopConstraintNavigations { get; set; }
        public virtual ICollection<Window> Windows { get; set; }
    }
}
