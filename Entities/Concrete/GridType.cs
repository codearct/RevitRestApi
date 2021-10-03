using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class GridType
    {
        public GridType()
        {
            Grids = new HashSet<Grid>();
        }

        public int Id { get; set; }
        public string TypeName { get; set; }
        public int? Symbol { get; set; }
        public int? CenterSegment { get; set; }
        public int? CenterSegmentPattern { get; set; }
        public int? CenterSegmentColor { get; set; }
        public int? CenterSegmentWeight { get; set; }
        public double? EndSegmentsLength { get; set; }
        public int? EndSegmentPattern { get; set; }
        public int? EndSegmentColor { get; set; }
        public int? EndSegmentWeight { get; set; }
        public int? PlanViewSymbolsEnd1Default { get; set; }
        public int? PlanViewSymbolsEnd2Default { get; set; }
        public int? NonPlanViewSymbolsDefault { get; set; }

        public virtual ICollection<Grid> Grids { get; set; }
    }
}
