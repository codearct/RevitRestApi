using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class Sheet
    {
        public int Id { get; set; }
        public string AssemblyKeynote { get; set; }
        public string AssemblyAssemblyDescription { get; set; }
        public double? AssemblyCost { get; set; }
        public string AssemblyTypeMark { get; set; }
        public string AssemblyAssemblyCode { get; set; }
        public string AssemblyDescription { get; set; }
        public string AssemblyUrl { get; set; }
        public string AssemblyTypeComments { get; set; }
        public string AssemblyManufacturer { get; set; }
        public string AssemblyModel { get; set; }
        public string AssemblyName { get; set; }
        public int? GuideGrid { get; set; }
        public int? CurrentRevisionIssued { get; set; }
        public string CurrentRevisionIssuedBy { get; set; }
        public string CurrentRevisionIssuedTo { get; set; }
        public string CurrentRevisionDate { get; set; }
        public string CurrentRevisionDescription { get; set; }
        public string CurrentRevision { get; set; }
        public string FilePath { get; set; }
        public string ApprovedBy { get; set; }
        public string DesignedBy { get; set; }
        public int? AppearsInSheetList { get; set; }
        public string CheckedBy { get; set; }
        public string DrawnBy { get; set; }
        public string Scale { get; set; }
        public string SheetNumber { get; set; }
        public string SheetName { get; set; }
        public string SheetIssueDate { get; set; }
        public string Dependency { get; set; }
        public string ReferencingDetail { get; set; }
        public string ReferencingSheet { get; set; }
        public int? LeftClipActive { get; set; }
    }
}
