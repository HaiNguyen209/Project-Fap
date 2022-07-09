using System;
using System.Collections.Generic;

#nullable disable

namespace Project.Models
{
    public partial class ScheduleOfStudent
    {
        public int Id { get; set; }
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public int? DateId { get; set; }
        public string Room { get; set; }
        public string StudentId { get; set; }
        public int? SlotId { get; set; }

        public virtual Date Date { get; set; }
        public virtual Slot Slot { get; set; }
        public virtual Student Student { get; set; }
    }
}
