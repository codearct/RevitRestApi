using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class ServiceTypeEnum
    {
        public ServiceTypeEnum()
        {
            Hvaczones = new HashSet<Hvaczone>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Hvaczone> Hvaczones { get; set; }
    }
}
