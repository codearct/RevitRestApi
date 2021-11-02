using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ViewModel.DoorVM
{
    public class DoorViewModel
    {
        public string DoorType { get; set; }
        public string Level { get; set; }
        public string Wall { get; set; }
        public int HostId { get; set; }
        public double HeadHeight { get; set; }
        public double SillHeight { get; set; }
        public string FrameMaterial { get; set; }
        public string FrameType { get; set; }
        public string Finish { get; set; }
        public string Mark { get; set; }
        public string HingeSet { get; set; }
        public string LockFunction { get; set; }
        public int EgressHardware { get; set; }
        public int Closer { get; set; }
        public int Stop { get; set; }
        public int Kickplates { get; set; }
        public int HoldOpen { get; set; }
        public  string DesignOption { get; set; }      
        public  string PhaseCreated { get; set; }
        public  string PhaseDemolished { get; set; }
        public string Comments { get; set; }


    }
}
