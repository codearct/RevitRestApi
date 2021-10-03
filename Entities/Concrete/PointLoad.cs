using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class PointLoad
    {
        public int Id { get; set; }
        public int? PhaseCreated { get; set; }
        public int? PhaseDemolished { get; set; }
        public int? DesignOption { get; set; }
        public string Description { get; set; }
        public string Comments { get; set; }
        public int? Nature { get; set; }
        public string Allnon0loads { get; set; }
        public double? Mz { get; set; }
        public double? My { get; set; }
        public double? Mx { get; set; }
        public double? Fz { get; set; }
        public double? Fy { get; set; }
        public double? Fx { get; set; }
        public int? IsReaction { get; set; }
        public int? LoadCase { get; set; }

        public virtual DesignOption DesignOptionNavigation { get; set; }
        public virtual Phase PhaseCreatedNavigation { get; set; }
        public virtual Phase PhaseDemolishedNavigation { get; set; }
    }
}
