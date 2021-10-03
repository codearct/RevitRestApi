using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class AnalyzesAsTypeEnum
    {
        public AnalyzesAsTypeEnum()
        {
            Floors = new HashSet<Floor>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Floor> Floors { get; set; }
    }
}
