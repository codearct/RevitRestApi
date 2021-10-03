using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class LineLoadOnBeam
    {
        public int LineLoadId { get; set; }
        public int? BeamId { get; set; }

        public virtual StructuralFraming Beam { get; set; }
        public virtual LineLoad LineLoad { get; set; }
    }
}
