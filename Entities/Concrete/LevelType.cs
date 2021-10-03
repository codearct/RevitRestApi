using Core.Entities;
using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class LevelType
    {
        public LevelType()
        {
            Levels = new HashSet<Level>();
        }

        public int Id { get; set; }

        public virtual ICollection<Level> Levels { get; set; }
    }
}
