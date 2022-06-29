using System;
using System.Collections.Generic;

#nullable disable

namespace Project.Models
{
    public partial class Schedule
    {
        public int Id { get; set; }
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public int? SlotId { get; set; }

        public virtual Slot Slot { get; set; }
    }
}
