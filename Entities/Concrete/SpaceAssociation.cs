using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class SpaceAssociation
    {
        public int Id { get; set; }
        public int PhaseId { get; set; }
        public int DesignOptionId { get; set; }
        public int? SpaceId { get; set; }

        public virtual Phase Phase { get; set; }
        public virtual Space Space { get; set; }
    }
}
