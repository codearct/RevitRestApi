﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ViewModel.RoomVM
{
    public class RoomViewModel
    {
        public string DesignOption { get; set; } //mapping
        public string Phase { get; set; } //mapping
        public string Comments { get; set; }
        public double Volume { get; set; }
        public double Perimeter { get; set; }
        public string Level { get; set; } //mapping
        public string Occupancy { get; set; }
        public string Department { get; set; }
        public string BaseFinish { get; set; }
        public string CeilingFinish { get; set; }
        public string WallFinish { get; set; }
        public string FloorFinish { get; set; }
        public double Area { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public double UnboundedHeight { get; set; }
        public string Occupant { get; set; }

        public ICollection<string> RoomAssociations { get; set; } //mapping
        public ICollection<string> ToRoomAssociations { get; set; }
        public ICollection<string> FromRoomAssociations { get; set; } //mapping
    }
}
