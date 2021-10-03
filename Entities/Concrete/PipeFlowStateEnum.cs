using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class PipeFlowStateEnum
    {
        public PipeFlowStateEnum()
        {
            FlexPipes = new HashSet<FlexPipe>();
            PipePlaceholders = new HashSet<PipePlaceholder>();
            Pipes = new HashSet<Pipe>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<FlexPipe> FlexPipes { get; set; }
        public virtual ICollection<PipePlaceholder> PipePlaceholders { get; set; }
        public virtual ICollection<Pipe> Pipes { get; set; }
    }
}
