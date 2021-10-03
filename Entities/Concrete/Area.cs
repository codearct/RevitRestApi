using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class Area
    {
        public int Id { get; set; }
        public int? AreaSchemeId { get; set; }
        public string AreaType { get; set; }
        public string Comments { get; set; }
        public double? Perimeter { get; set; }
        public int? Level { get; set; }
        public double? Area1 { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }

        public virtual AreaScheme AreaScheme { get; set; }
        public virtual Level LevelNavigation { get; set; }
    }
}
