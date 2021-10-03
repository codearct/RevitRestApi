using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class StructuralRebarShape
    {
        public StructuralRebarShape()
        {
            StructuralRebars = new HashSet<StructuralRebar>();
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
        public int? Material { get; set; }
        public int? HookAtEnd { get; set; }
        public int? HookAtStart { get; set; }
        public int? Style { get; set; }
        public int? HookOrientationAtEnd { get; set; }
        public int? HookOrientationAtStart { get; set; }
        public int? BaseFinishingTurns { get; set; }
        public int? TopFinishingTurns { get; set; }
        public double? Height { get; set; }
        public double? Pitch { get; set; }

        public virtual AssemblyCode AssemblyCodeNavigation { get; set; }
        public virtual OmniClassNumber OmniClassNumberNavigation { get; set; }
        public virtual ICollection<StructuralRebar> StructuralRebars { get; set; }
    }
}
