using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class EaveCutterTypeEnum
    {
        public EaveCutterTypeEnum()
        {
            Roofs = new HashSet<Roof>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Roof> Roofs { get; set; }
    }
}
