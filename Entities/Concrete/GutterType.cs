﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class GutterType
    {
        public GutterType()
        {
            Gutters = new HashSet<Gutter>();
        }

        public int Id { get; set; }
        public string Keynote { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string TypeComments { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public string OmniClassNumber { get; set; }
        public string AssemblyCode { get; set; }
        public string FamilyName { get; set; }
        public string TypeName { get; set; }
        public string TypeMark { get; set; }
        public double? Cost { get; set; }
        public int? Profile { get; set; }
        public int? Material { get; set; }

        public virtual AssemblyCode AssemblyCodeNavigation { get; set; }
        public virtual Material MaterialNavigation { get; set; }
        public virtual OmniClassNumber OmniClassNumberNavigation { get; set; }
        public virtual Profile ProfileNavigation { get; set; }
        public virtual ICollection<Gutter> Gutters { get; set; }
    }
}
