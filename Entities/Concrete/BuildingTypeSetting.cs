using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class BuildingTypeSetting
    {
        public int Id { get; set; }
        public int? DesignOption { get; set; }

        public virtual DesignOption DesignOptionNavigation { get; set; }
    }
}
