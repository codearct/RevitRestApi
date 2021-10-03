using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class DoorWall
    {
        public int DoorId { get; set; }
        public string DoorName { get; set; }
        public int? WallId { get; set; }
        public string WallName { get; set; }

        public virtual Door Door { get; set; }
        public virtual Wall Wall { get; set; }
    }
}
