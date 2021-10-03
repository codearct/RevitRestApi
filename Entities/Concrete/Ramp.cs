using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class Ramp
    {
        public int Id { get; set; }
        public int? TypeId { get; set; }
        public int? PhaseCreated { get; set; }
        public int? PhaseDemolished { get; set; }
        public int? DesignOption { get; set; }
        public string Comments { get; set; }
        public int? MultistoryTopLevel { get; set; }
        public double? TopOffset { get; set; }
        public double? BaseOffset { get; set; }
        public double? Width { get; set; }
        public int? TopLevel { get; set; }
        public int? BaseLevel { get; set; }
        public string Mark { get; set; }

        public virtual Level BaseLevelNavigation { get; set; }
        public virtual DesignOption DesignOptionNavigation { get; set; }
        public virtual Level MultistoryTopLevelNavigation { get; set; }
        public virtual Phase PhaseCreatedNavigation { get; set; }
        public virtual Phase PhaseDemolishedNavigation { get; set; }
        public virtual Level TopLevelNavigation { get; set; }
        public virtual RampType Type { get; set; }
    }
}
