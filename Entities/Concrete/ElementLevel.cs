using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class ElementLevel
    {
        public int ElementId { get; set; }
        public string ElementName { get; set; }
        public int? LevelId { get; set; }
        public string LevelName { get; set; }

        public virtual Level Level { get; set; }
    }
}
