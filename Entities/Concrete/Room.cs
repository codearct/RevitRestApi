using Core.Entities;
using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class Room:IEntity
    {
        public Room()
        {
            RoomAssociations = new HashSet<RoomAssociation>();
            RoomFromToAssociationFromRoomNavigations = new HashSet<RoomFromToAssociation>();
        }
        public int Id { get; set; }
        public int? DesignOption { get; set; }
        public int? PhaseId { get; set; }
        public string Comments { get; set; }
        public double? Volume { get; set; }
        public double? Perimeter { get; set; } 
        public int? Level { get; set; }
        public string Occupancy { get; set; }
        public string Department { get; set; }
        public string BaseFinish { get; set; }
        public string CeilingFinish { get; set; }
        public string WallFinish { get; set; }
        public string FloorFinish { get; set; }
        public double? Area { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public double? UnboundedHeight { get; set; }
        public string Occupant { get; set; }

        public virtual DesignOption DesignOptionNavigation { get; set; }
        public virtual Level LevelNavigation { get; set; }
        public virtual Phase Phase { get; set; }
        public virtual ICollection<RoomAssociation> RoomAssociations { get; set; }
        public virtual ICollection<RoomFromToAssociation> RoomFromToAssociationFromRoomNavigations { get; set; }
        public virtual ICollection<RoomFromToAssociation> RoomFromToAssociationToRoomNavigations { get; set; }
    }
}
