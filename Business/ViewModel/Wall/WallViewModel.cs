using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ViewModel.Wall
{
    public class WallViewModel
    {
        public string WallType { get; set; }
        public string PhaseCreated { get; set; } //mapping
        public string PhaseDemolished { get; set; } //mapping
        public string DesignOption { get; set; } //mapping
        public double EstimatedReinforcementVolume { get; set; }
        public double Volume { get; set; } //mapping
        public double Area { get; set; } //mapping
        public string Comments { get; set; }
        public double Length { get; set; } //mapping
        public string Mark { get; set; }
        public string StructuralUsage { get; set; } //mapping
        public double TopOffset { get; set; } //mapping
        public double BaseOffset { get; set; } //mapping
        public string BaseConstraint { get; set; }  //mapping
        public double UnconnectedHeight { get; set; } //mapping
        public string TopConstraint { get; set; } //mapping
        public int RoomBounding { get; set; }

        public ICollection<string> CaseworkOnWalls { get; set; } //mapping
        public ICollection<string> CurtainWallPanelOnWalls { get; set; } //mapping
        public ICollection<string> DoorOnWalls { get; set; } //mapping
        public ICollection<string> GenericModelOnWalls { get; set; } //mapping
        public ICollection<string> LightingFixtureOnWalls { get; set; } //mapping
        public ICollection<string> MechanicalEquipmentOnWalls { get; set; } //mapping
        public ICollection<string> OpeningOnWalls { get; set; } //mapping
        public ICollection<string> PlumbingFixtureOnWalls { get; set; } //mapping
        public ICollection<string> RebarOnWalls { get; set; } //mapping
        public ICollection<string> WindowOnWalls { get; set; } //mapping
    }
}
