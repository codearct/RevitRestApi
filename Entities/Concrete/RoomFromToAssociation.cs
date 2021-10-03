using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class RoomFromToAssociation
    {
        public int Id { get; set; }
        public int PhaseId { get; set; }
        public int DesignOptionId { get; set; }
        public int? FromRoom { get; set; }
        public int? ToRoom { get; set; }

        public virtual Room FromRoomNavigation { get; set; }
        public virtual Phase Phase { get; set; }
        public virtual Room ToRoomNavigation { get; set; }
    }
}
