using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class SpaceTypeSetting
    {
        public int Id { get; set; }
        public int? DesignOption { get; set; }

        public virtual DesignOption DesignOptionNavigation { get; set; }
    }
}
