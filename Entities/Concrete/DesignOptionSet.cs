using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class DesignOptionSet
    {
        public int Id { get; set; }
        public int? PrimaryOptionId { get; set; }
        public string Name { get; set; }

        public virtual DesignOption PrimaryOption { get; set; }
    }
}
