using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class MaterialQuantity
    {
        public int ElementId { get; set; }
        public int MaterialId { get; set; }
        public int AsPaint { get; set; }
        public double? Area { get; set; }
        public double? Volume { get; set; }

        public virtual Material Material { get; set; }
    }
}
