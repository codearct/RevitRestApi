using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Concrete
{
    public partial class RoomTag
    {
        public int Id { get; set; }
        public string RoomTagType { get; set; }
        public int? RoomId { get; set; }
        public int? ViewId { get; set; }
    }
}
