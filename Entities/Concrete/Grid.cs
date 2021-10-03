using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class Grid
    {
        public int Id { get; set; }
        public int? TypeId { get; set; }
        public string Name { get; set; }
        public int? ScopeBox { get; set; }

        public virtual GridType Type { get; set; }
    }
}
