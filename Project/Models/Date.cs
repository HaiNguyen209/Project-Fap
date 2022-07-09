using System;
using System.Collections.Generic;

#nullable disable

namespace Project.Models
{
    public partial class Date
    {
        public Date()
        {
            ScheduleOfStudents = new HashSet<ScheduleOfStudent>();
            ScheduleOfTeachers = new HashSet<ScheduleOfTeacher>();
        }

        public int Id { get; set; }
        public DateTime? Date1 { get; set; }

        public virtual ICollection<ScheduleOfStudent> ScheduleOfStudents { get; set; }
        public virtual ICollection<ScheduleOfTeacher> ScheduleOfTeachers { get; set; }
    }
}
