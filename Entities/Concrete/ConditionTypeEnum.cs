using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class ConditionTypeEnum
    {
        public ConditionTypeEnum()
        {
            Spaces = new HashSet<Space>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Space> Spaces { get; set; }
    }
}
