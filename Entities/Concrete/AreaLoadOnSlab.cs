using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class AreaLoadOnSlab
    {
        public int AreaLoadId { get; set; }
        public int? SlabId { get; set; }

        public virtual AreaLoad AreaLoad { get; set; }
        public virtual Floor Slab { get; set; }
    }
}
