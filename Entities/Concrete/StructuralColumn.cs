using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class StructuralColumn
    {
        public StructuralColumn()
        {
            RebarOnColumns = new HashSet<RebarOnColumn>();
        }

        public int Id { get; set; }
        public int? TypeId { get; set; }
        public int? PhaseCreated { get; set; }
        public int? PhaseDemolished { get; set; }
        public int? DesignOption { get; set; }
        public double? EstimatedReinforcementVolume { get; set; }
        public double? Volume { get; set; }
        public string Comments { get; set; }
        public double? TopOffset { get; set; }
        public double? BaseOffset { get; set; }
        public int? TopLevel { get; set; }
        public int? BaseLevel { get; set; }
        public int? AnalyzeAs { get; set; }
        public double? Length { get; set; }
        public string Mark { get; set; }

        public virtual Level BaseLevelNavigation { get; set; }
        public virtual DesignOption DesignOptionNavigation { get; set; }
        public virtual Phase PhaseCreatedNavigation { get; set; }
        public virtual Phase PhaseDemolishedNavigation { get; set; }
        public virtual Level TopLevelNavigation { get; set; }
        public virtual StructuralColumnType Type { get; set; }
        public virtual ICollection<RebarOnColumn> RebarOnColumns { get; set; }
    }
}
