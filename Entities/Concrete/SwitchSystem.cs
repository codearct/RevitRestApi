using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class SwitchSystem
    {
        public int Id { get; set; }
        public int? DesignOption { get; set; }
        public string SwitchId { get; set; }
        public string Comments { get; set; }

        public virtual DesignOption DesignOptionNavigation { get; set; }
    }
}
