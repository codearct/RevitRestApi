using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class Roof
    {
        public Roof()
        {
            CurtainWallPanelOnRoofs = new HashSet<CurtainWallPanelOnRoof>();
            GenericModelOnRoofs = new HashSet<GenericModelOnRoof>();
        }

        public int Id { get; set; }
        public int? TypeId { get; set; }
        public int? PhaseCreated { get; set; }
        public int? PhaseDemolished { get; set; }
        public int? DesignOption { get; set; }
        public double? Volume { get; set; }
        public double? Area { get; set; }
        public string Comments { get; set; }
        public int? RafterorTruss { get; set; }
        public double? FasciaDepth { get; set; }
        public int? RafterCut { get; set; }
        public int? BaseLevel { get; set; }
        public double? CutoffOffset { get; set; }
        public int? CutoffLevel { get; set; }
        public double? BaseOffsetFromLevel { get; set; }
        public string Mark { get; set; }

        public virtual Level BaseLevelNavigation { get; set; }
        public virtual Level CutoffLevelNavigation { get; set; }
        public virtual DesignOption DesignOptionNavigation { get; set; }
        public virtual Phase PhaseCreatedNavigation { get; set; }
        public virtual Phase PhaseDemolishedNavigation { get; set; }
        public virtual EaveCutterTypeEnum RafterCutNavigation { get; set; }
        public virtual RoofType Type { get; set; }
        public virtual ICollection<CurtainWallPanelOnRoof> CurtainWallPanelOnRoofs { get; set; }
        public virtual ICollection<GenericModelOnRoof> GenericModelOnRoofs { get; set; }
    }
}
