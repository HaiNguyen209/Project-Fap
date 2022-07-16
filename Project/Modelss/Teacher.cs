using System;
using System.Collections.Generic;

#nullable disable

namespace Project.Modelss
{
    public partial class Teacher
    {
        public Teacher()
        {
            Attendances = new HashSet<Attendance>();
            ScheduleOfTeachers = new HashSet<ScheduleOfTeacher>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }

        public virtual Account UserNameNavigation { get; set; }
        public virtual ICollection<Attendance> Attendances { get; set; }
        public virtual ICollection<ScheduleOfTeacher> ScheduleOfTeachers { get; set; }
    }
}
