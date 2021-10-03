using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class CurtainWallPanelOnWall
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? HostId { get; set; }
        public string HostName { get; set; }

        public virtual Wall Host { get; set; }
        public virtual CurtainPanel IdNavigation { get; set; }
    }
}
