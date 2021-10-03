using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class WallUsageEnum
    {
        public WallUsageEnum()
        {
            Walls = new HashSet<Wall>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Wall> Walls { get; set; }
    }
}
