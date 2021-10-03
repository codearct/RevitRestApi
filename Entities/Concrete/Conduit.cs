using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class Conduit
    {
        public int Id { get; set; }
        public int? DesignOption { get; set; }
        public int? PhaseCreated { get; set; }
        public int? PhaseDemolished { get; set; }
        public int? TypeId { get; set; }
        public string ServiceType { get; set; }
        public string Comments { get; set; }
        public string Mark { get; set; }
        public double? OutsideDiameter { get; set; }
        public double? InsideDiameter { get; set; }
        public double? BottomElevation { get; set; }
        public double? TopElevation { get; set; }
        public double? DiameterTradeSize { get; set; }
        public double? Length { get; set; }
        public string Size { get; set; }

        public virtual DesignOption DesignOptionNavigation { get; set; }
        public virtual Phase PhaseCreatedNavigation { get; set; }
        public virtual Phase PhaseDemolishedNavigation { get; set; }
        public virtual ConduitType Type { get; set; }
    }
}
