using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class View
    {
        public int Id { get; set; }
        public string Family { get; set; }
        public string FamilyandType { get; set; }
        public int? PhaseFilter { get; set; }
        public int? PartsVisibility { get; set; }
        public int? DetailLevel { get; set; }
        public int? SunPath { get; set; }
        public string DisplayName { get; set; }
        public string SheetName { get; set; }
        public string SheetNumber { get; set; }
        public int? Orientation { get; set; }
        public string AssociatedLevel { get; set; }
        public int? Discipline { get; set; }
        public int? DisplayModel { get; set; }
        public int? ViewScale { get; set; }
        public int? ScaleValue1 { get; set; }
        public string TitleonSheet { get; set; }
        public string ViewName { get; set; }
        public int? Phase { get; set; }

        public virtual Phase PhaseNavigation { get; set; }
    }
}
