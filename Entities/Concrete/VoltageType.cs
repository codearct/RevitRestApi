using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class VoltageType
    {
        public VoltageType()
        {
            Voltages = new HashSet<Voltage>();
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
        public double? ActualVoltage { get; set; }
        public double? MinimumVoltage { get; set; }
        public double? MaximumVoltage { get; set; }

        public virtual AssemblyCode AssemblyCodeNavigation { get; set; }
        public virtual OmniClassNumber OmniClassNumberNavigation { get; set; }
        public virtual ICollection<Voltage> Voltages { get; set; }
    }
}
