using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class Wall
    {
        public Wall()
        {
            CaseworkOnWalls = new HashSet<CaseworkOnWall>();
            CurtainWallPanelOnWalls = new HashSet<CurtainWallPanelOnWall>();
            DoorWalls = new HashSet<DoorWall>();
            GenericModelOnWalls = new HashSet<GenericModelOnWall>();
            LightingFixtureOnWalls = new HashSet<LightingFixtureOnWall>();
            MechanicalEquipmentOnWalls = new HashSet<MechanicalEquipmentOnWall>();
            OpeningOnWalls = new HashSet<OpeningOnWall>();
            PlumbingFixtureOnWalls = new HashSet<PlumbingFixtureOnWall>();
            RebarOnWalls = new HashSet<RebarOnWall>();
            WindowWalls = new HashSet<WindowWall>();
        }

        public int Id { get; set; }
        public int? TypeId { get; set; }
        public int? PhaseCreated { get; set; }
        public int? PhaseDemolished { get; set; }
        public int? DesignOption { get; set; }
        public double? EstimatedReinforcementVolume { get; set; }
        public double? Volume { get; set; }
        public double? Area { get; set; }
        public string Comments { get; set; }
        public double? Length { get; set; }
        public string Mark { get; set; }
        public int? StructuralUsage { get; set; }
        public double? TopOffset { get; set; }
        public double? BaseOffset { get; set; }
        public int? BaseConstraint { get; set; }
        public double? UnconnectedHeight { get; set; }
        public int? TopConstraint { get; set; }
        public int? RoomBounding { get; set; }

        public virtual Level BaseConstraintNavigation { get; set; }
        public virtual DesignOption DesignOptionNavigation { get; set; }
        public virtual Phase PhaseCreatedNavigation { get; set; }
        public virtual Phase PhaseDemolishedNavigation { get; set; }
        public virtual WallUsageEnum StructuralUsageNavigation { get; set; }
        public virtual Level TopConstraintNavigation { get; set; }
        public virtual WallType Type { get; set; }
        public virtual ICollection<CaseworkOnWall> CaseworkOnWalls { get; set; }
        public virtual ICollection<CurtainWallPanelOnWall> CurtainWallPanelOnWalls { get; set; }
        public virtual ICollection<DoorWall> DoorWalls { get; set; }
        public virtual ICollection<GenericModelOnWall> GenericModelOnWalls { get; set; }
        public virtual ICollection<LightingFixtureOnWall> LightingFixtureOnWalls { get; set; }
        public virtual ICollection<MechanicalEquipmentOnWall> MechanicalEquipmentOnWalls { get; set; }
        public virtual ICollection<OpeningOnWall> OpeningOnWalls { get; set; }
        public virtual ICollection<PlumbingFixtureOnWall> PlumbingFixtureOnWalls { get; set; }
        public virtual ICollection<RebarOnWall> RebarOnWalls { get; set; }
        public virtual ICollection<WindowWall> WindowWalls { get; set; }
    }
}
