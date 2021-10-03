using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class Door
    {
        public int Id { get; set; }
        public int? TypeId { get; set; }
        public int? PhaseCreated { get; set; }
        public int? PhaseDemolished { get; set; }
        public int? DesignOption { get; set; }
        public string Comments { get; set; }
        public int? HostId { get; set; }
        public int? Level { get; set; }
        public double? HeadHeight { get; set; }
        public double? SillHeight { get; set; }
        public string FrameMaterial { get; set; }
        public string FrameType { get; set; }
        public string Finish { get; set; }
        public string Mark { get; set; }
        public string HingeSet { get; set; }
        public string LockFunction { get; set; }
        public int? EgressHardware { get; set; }
        public int? Closer { get; set; }
        public int? Stop { get; set; }
        public int? Kickplates { get; set; }
        public int? HoldOpen { get; set; }

        public virtual DesignOption DesignOptionNavigation { get; set; }
        public virtual Level LevelNavigation { get; set; }
        public virtual Phase PhaseCreatedNavigation { get; set; }
        public virtual Phase PhaseDemolishedNavigation { get; set; }
        public virtual DoorType Type { get; set; }
        public virtual DoorWall DoorWall { get; set; }
    }
}
