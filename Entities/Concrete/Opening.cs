using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class Opening
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? LevelId { get; set; }
        public int? HostId { get; set; }

        public virtual OpeningOnFloor OpeningOnFloor { get; set; }
        public virtual OpeningOnWall OpeningOnWall { get; set; }
    }
}
