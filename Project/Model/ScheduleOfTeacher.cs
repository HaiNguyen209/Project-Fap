using System;
using System.Collections.Generic;

#nullable disable

namespace Project.Model
{
    public partial class ScheduleOfTeacher
    {
        public string Id { get; set; }
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public int? SlotId { get; set; }
        public string TeacherId { get; set; }

        public virtual Slot Slot { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
