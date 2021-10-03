using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class DuctSystemType
    {
        public int Id { get; set; }
        public int? RiseDropSymbol { get; set; }
        public string Abbreviation { get; set; }
        public string SystemClassification { get; set; }
        public string TypeComments { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
    }
}
