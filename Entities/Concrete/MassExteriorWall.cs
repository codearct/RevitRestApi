using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class MassExteriorWall
    {
        public int Id { get; set; }
        public int? PhaseCreated { get; set; }
        public int? PhaseDemolished { get; set; }
        public int? DesignOption { get; set; }
        public int? Values { get; set; }
        public double? TargetSillHeight { get; set; }
        public double? ShadeDepth { get; set; }
        public int? GlazingisShaded { get; set; }
        public double? TargetPercentageGlazing { get; set; }
        public int? Underground { get; set; }
        public double? MassExteriorWallArea { get; set; }
        public int? Subcategory { get; set; }
        public int? ConceptualTypes { get; set; }
        public int? GraphicalAppearance { get; set; }
        public string MassComments { get; set; }
        public string MassTypeComments { get; set; }
        public string MassFamilyandType { get; set; }
        public string MassFamily { get; set; }
        public string MassType { get; set; }

        public virtual DesignOption DesignOptionNavigation { get; set; }
        public virtual Phase PhaseCreatedNavigation { get; set; }
        public virtual Phase PhaseDemolishedNavigation { get; set; }
    }
}
