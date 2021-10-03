using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class OpeningOnFloor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? HostId { get; set; }
        public string HostName { get; set; }

        public virtual Floor Host { get; set; }
        public virtual Opening IdNavigation { get; set; }
    }
}
