using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class Wire
    {
        public int Id { get; set; }
        public int? TypeId { get; set; }
        public int? PhaseCreated { get; set; }
        public int? PhaseDemolished { get; set; }
        public int? DesignOption { get; set; }
        public string CircuitDescription { get; set; }
        public string CircuitLoadName { get; set; }
        public int? NumberofConductors { get; set; }
        public int? TickMarks { get; set; }
        public string Panel { get; set; }
        public string Circuits { get; set; }
        public int? Type { get; set; }
        public int? HotConductors { get; set; }
        public int? NeutralConductors { get; set; }
        public int? GroundConductors { get; set; }
        public string WireSize { get; set; }
        public string Comments { get; set; }
        public string Mark { get; set; }

        public virtual DesignOption DesignOptionNavigation { get; set; }
        public virtual Phase PhaseCreatedNavigation { get; set; }
        public virtual Phase PhaseDemolishedNavigation { get; set; }
        public virtual WireType Type1 { get; set; }
        public virtual WiringTypeEnum TypeNavigation { get; set; }
    }
}
