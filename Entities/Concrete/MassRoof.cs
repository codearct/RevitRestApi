using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class MassRoof
    {
        public int Id { get; set; }
        public int? PhaseCreated { get; set; }
        public int? PhaseDemolished { get; set; }
        public int? DesignOption { get; set; }
        public int? Values { get; set; }
        public double? SkylightWidthDepth { get; set; }
        public double? TargetPercentageSkylights { get; set; }
        public int? Underground { get; set; }
        public double? MassRoofArea { get; set; }
        public int? Subcategory { get; set; }
        public int? ConceptualTypes { get; set; }
        public int? GraphicalAppearance { get; set; }
        public string MassComments { get; set; }
        public string MassTypeComments { get; set; }
        public string MassFamilyandType { get; set; }
        public string MassFamily { get; set; }
        public string MassType { get; set; }
        public string Comments { get; set; }
        public string Mark { get; set; }

        public virtual DesignOption DesignOptionNavigation { get; set; }
        public virtual Phase PhaseCreatedNavigation { get; set; }
        public virtual Phase PhaseDemolishedNavigation { get; set; }
    }
}
