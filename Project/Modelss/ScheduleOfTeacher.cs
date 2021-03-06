using System;
using System.Collections.Generic;

#nullable disable

namespace Project.Modelss
{
    public partial class ScheduleOfTeacher
    {
        public string Id { get; set; }
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public int? DateId { get; set; }
        public string Room { get; set; }
        public int? SlotId { get; set; }
        public string GradeId { get; set; }
        public string TeacherId { get; set; }

        public virtual Date Date { get; set; }
        public virtual Grade Grade { get; set; }
        public virtual Slot Slot { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
