using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class InternalAreaLoad
    {
        public int Id { get; set; }
        public int? PhaseCreated { get; set; }
        public int? PhaseDemolished { get; set; }
        public int? DesignOption { get; set; }
        public string Description { get; set; }
        public string Comments { get; set; }
        public int? Nature { get; set; }
        public string Allnon0loads { get; set; }
        public double? Area { get; set; }
        public double? Fz3 { get; set; }
        public double? Fy3 { get; set; }
        public double? Fx3 { get; set; }
        public double? Fz2 { get; set; }
        public double? Fy2 { get; set; }
        public double? Fx2 { get; set; }
        public double? Fz1 { get; set; }
        public double? Fy1 { get; set; }
        public double? Fx1 { get; set; }
        public int? IsReaction { get; set; }
        public int? LoadCase { get; set; }

        public virtual DesignOption DesignOptionNavigation { get; set; }
        public virtual Phase PhaseCreatedNavigation { get; set; }
        public virtual Phase PhaseDemolishedNavigation { get; set; }
    }
}
