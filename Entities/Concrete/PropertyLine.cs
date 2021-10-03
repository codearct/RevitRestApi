using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class PropertyLine
    {
        public int Id { get; set; }
        public int? TypeId { get; set; }
        public int? DesignOption { get; set; }
        public double? Area { get; set; }
        public string Comments { get; set; }
        public string Name { get; set; }
        public string Mark { get; set; }

        public virtual DesignOption DesignOptionNavigation { get; set; }
        public virtual PropertyLineType Type { get; set; }
    }
}
