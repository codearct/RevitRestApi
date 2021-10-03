using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class DistributionSystemType
    {
        public DistributionSystemType()
        {
            DistributionSystems = new HashSet<DistributionSystem>();
        }

        public int Id { get; set; }
        public string Keynote { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string TypeComments { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public string OmniClassNumber { get; set; }
        public string AssemblyCode { get; set; }
        public string FamilyName { get; set; }
        public string TypeName { get; set; }
        public string TypeMark { get; set; }
        public double? Cost { get; set; }
        public int? LinetoLineVoltage { get; set; }
        public int? LinetoGroundVoltage { get; set; }
        public int? Phase { get; set; }
        public int? Configuration { get; set; }
        public int? Wires { get; set; }

        public virtual AssemblyCode AssemblyCodeNavigation { get; set; }
        public virtual ElectricalPhaseConfigurationEnum ConfigurationNavigation { get; set; }
        public virtual OmniClassNumber OmniClassNumberNavigation { get; set; }
        public virtual ElectricalPhaseEnum PhaseNavigation { get; set; }
        public virtual ICollection<DistributionSystem> DistributionSystems { get; set; }
    }
}
