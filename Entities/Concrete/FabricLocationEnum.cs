using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class FabricLocationEnum
    {
        public FabricLocationEnum()
        {
            StructuralFabricReinforcements = new HashSet<StructuralFabricReinforcement>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<StructuralFabricReinforcement> StructuralFabricReinforcements { get; set; }
    }
}
