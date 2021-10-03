using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class MechanicalEquipment
    {
        public int Id { get; set; }
        public int? TypeId { get; set; }
        public int? PhaseCreated { get; set; }
        public int? PhaseDemolished { get; set; }
        public int? DesignOption { get; set; }
        public string SystemClassification { get; set; }
        public string SystemName { get; set; }
        public string Comments { get; set; }
        public int? HostId { get; set; }
        public int? Level { get; set; }
        public string Mark { get; set; }
        public string CircuitNumber { get; set; }
        public string Panel { get; set; }

        public virtual DesignOption DesignOptionNavigation { get; set; }
        public virtual Level LevelNavigation { get; set; }
        public virtual Phase PhaseCreatedNavigation { get; set; }
        public virtual Phase PhaseDemolishedNavigation { get; set; }
        public virtual MechanicalEquipmentType Type { get; set; }
        public virtual MechanicalEquipmentOnWall MechanicalEquipmentOnWall { get; set; }
    }
}
