using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class LightingFixtureOnCeiling
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? HostId { get; set; }
        public string HostName { get; set; }

        public virtual Ceiling Host { get; set; }
        public virtual LightingFixture IdNavigation { get; set; }
    }
}
