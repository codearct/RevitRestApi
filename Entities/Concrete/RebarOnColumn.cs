using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class RebarOnColumn
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? HostId { get; set; }
        public string HostName { get; set; }

        public virtual StructuralColumn Host { get; set; }
        public virtual StructuralRebar IdNavigation { get; set; }
    }
}
