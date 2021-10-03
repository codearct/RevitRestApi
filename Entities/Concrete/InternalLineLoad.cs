using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class InternalLineLoad
    {
        public int Id { get; set; }
        public int? PhaseCreated { get; set; }
        public int? PhaseDemolished { get; set; }
        public int? DesignOption { get; set; }
        public string Description { get; set; }
        public string Comments { get; set; }
        public int? Nature { get; set; }
        public string Allnon0loads { get; set; }
        public double? Length { get; set; }
        public double? Mz2 { get; set; }
        public double? My2 { get; set; }
        public double? Mx2 { get; set; }
        public double? Mz1 { get; set; }
        public double? My1 { get; set; }
        public double? Mx1 { get; set; }
        public double? Fz2 { get; set; }
        public double? Fy2 { get; set; }
        public double? Fx2 { get; set; }
        public double? Fz1 { get; set; }
        public double? Fy1 { get; set; }
        public double? Fx1 { get; set; }
        public int? IsReaction { get; set; }
        public int? UniformLoad { get; set; }
        public int? LoadCase { get; set; }

        public virtual DesignOption DesignOptionNavigation { get; set; }
        public virtual Phase PhaseCreatedNavigation { get; set; }
        public virtual Phase PhaseDemolishedNavigation { get; set; }
    }
}
