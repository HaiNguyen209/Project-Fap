using System;
using System.Collections.Generic;

#nullable disable

namespace Project.Modelss
{
    public partial class Grade
    {
        public Grade()
        {
            Attendances = new HashSet<Attendance>();
            ScheduleOfStudents = new HashSet<ScheduleOfStudent>();
            ScheduleOfTeachers = new HashSet<ScheduleOfTeacher>();
        }

        public string Id { get; set; }
        public string ClassName { get; set; }
        public int? QuantityStudents { get; set; }

        public virtual ICollection<Attendance> Attendances { get; set; }
        public virtual ICollection<ScheduleOfStudent> ScheduleOfStudents { get; set; }
        public virtual ICollection<ScheduleOfTeacher> ScheduleOfTeachers { get; set; }
    }
}
