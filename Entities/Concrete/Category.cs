using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class Category
    {
        public Category()
        {
            Assemblies = new HashSet<Assembly>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? MaterialId { get; set; }

        public virtual Material Material { get; set; }
        public virtual ICollection<Assembly> Assemblies { get; set; }
    }
}
