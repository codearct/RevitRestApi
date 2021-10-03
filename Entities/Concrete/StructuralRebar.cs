using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class StructuralRebar
    {
        public int Id { get; set; }
        public int? TypeId { get; set; }
        public int? PhaseCreated { get; set; }
        public int? PhaseDemolished { get; set; }
        public int? DesignOption { get; set; }
        public double? EstimatedReinforcementVolume { get; set; }
        public double? StandardBendDiameter { get; set; }
        public string ScheduleMark { get; set; }
        public int? Style { get; set; }
        public double? BarLength { get; set; }
        public int? Shape { get; set; }
        public double? Spacing { get; set; }
        public int? Quantity { get; set; }
        public int? LayoutRule { get; set; }
        public int? HookAtEnd { get; set; }
        public int? HookAtStart { get; set; }
        public double? TotalBarLength { get; set; }
        public double? BarDiameter { get; set; }
        public string Comments { get; set; }
        public string Mark { get; set; }

        public virtual DesignOption DesignOptionNavigation { get; set; }
        public virtual StructuralRebarHookType HookAtEndNavigation { get; set; }
        public virtual StructuralRebarHookType HookAtStartNavigation { get; set; }
        public virtual RebarLayoutEnum LayoutRuleNavigation { get; set; }
        public virtual Phase PhaseCreatedNavigation { get; set; }
        public virtual Phase PhaseDemolishedNavigation { get; set; }
        public virtual StructuralRebarShape ShapeNavigation { get; set; }
        public virtual RebarStyleEnum StyleNavigation { get; set; }
        public virtual StructuralRebarBarType Type { get; set; }
        public virtual RebarOnColumn RebarOnColumn { get; set; }
        public virtual RebarOnFloor RebarOnFloor { get; set; }
        public virtual RebarOnFoundation RebarOnFoundation { get; set; }
        public virtual RebarOnFraming RebarOnFraming { get; set; }
        public virtual RebarOnWall RebarOnWall { get; set; }
    }
}
