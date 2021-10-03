using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class ProjectInformation
    {
        public int Id { get; set; }
        public string ProjectIssueDate { get; set; }
        public string ProjectStatus { get; set; }
        public string ClientName { get; set; }
        public string ProjectAddress { get; set; }
        public string ProjectName { get; set; }
        public string ProjectNumber { get; set; }
    }
}
