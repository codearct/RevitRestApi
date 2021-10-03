using Core.Entities;
using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class RoomAssociation
    {
        public int Id { get; set; }
        public int PhaseId { get; set; }
        public int DesignOptionId { get; set; }
        public int? RoomId { get; set; }

        public virtual Phase Phase { get; set; }
        public virtual Room Room { get; set; }
    }
}
