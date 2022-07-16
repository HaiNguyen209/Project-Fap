using System;
using System.Collections.Generic;

#nullable disable

namespace Project.Modelss
{
    public partial class Slot
    {
        public Slot()
        {
            ScheduleOfStudents = new HashSet<ScheduleOfStudent>();
            ScheduleOfTeachers = new HashSet<ScheduleOfTeacher>();
        }

        public int Id { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }

        public virtual ICollection<ScheduleOfStudent> ScheduleOfStudents { get; set; }
        public virtual ICollection<ScheduleOfTeacher> ScheduleOfTeachers { get; set; }
    }
}
