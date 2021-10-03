using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class PipeSegment
    {
        public int Id { get; set; }
        public int? DesignOption { get; set; }
        public string SegmentDescription { get; set; }
        public string ConnectionType { get; set; }
        public double? Roughness { get; set; }
        public int? ScheduleType { get; set; }
        public int? Material { get; set; }

        public virtual DesignOption DesignOptionNavigation { get; set; }
        public virtual Material MaterialNavigation { get; set; }
    }
}
