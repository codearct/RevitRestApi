using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class AreaScheme
    {
        public AreaScheme()
        {
            Areas = new HashSet<Area>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Area> Areas { get; set; }
    }
}
