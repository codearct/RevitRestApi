using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class DuctSystem
    {
        public int Id { get; set; }
        public int? DesignOption { get; set; }
        public int? TypeId { get; set; }
        public int? NumberofElements { get; set; }
        public string SystemEquipment { get; set; }
        public string SystemName { get; set; }
        public double? Flow { get; set; }
        public string Comments { get; set; }

        public virtual DesignOption DesignOptionNavigation { get; set; }
    }
}
