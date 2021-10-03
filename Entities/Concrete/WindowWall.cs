using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class WindowWall
    {
        public int WindowId { get; set; }
        public string WindowName { get; set; }
        public int? WallId { get; set; }
        public string WallName { get; set; }

        public virtual Wall Wall { get; set; }
        public virtual Window Window { get; set; }
    }
}
