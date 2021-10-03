using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class PlumbingFixtureType
    {
        public PlumbingFixtureType()
        {
            PlumbingFixtures = new HashSet<PlumbingFixture>();
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
        public double? Wfu { get; set; }
        public double? Hwfu { get; set; }
        public double? Cwfu { get; set; }
        public int? VentConnection { get; set; }
        public int? WasteConnection { get; set; }
        public int? Cwconnection { get; set; }
        public int? Hwconnection { get; set; }

        public virtual AssemblyCode AssemblyCodeNavigation { get; set; }
        public virtual OmniClassNumber OmniClassNumberNavigation { get; set; }
        public virtual ICollection<PlumbingFixture> PlumbingFixtures { get; set; }
    }
}
