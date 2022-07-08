using System;
using System.Collections.Generic;

#nullable disable

namespace Project.Models
{
    public partial class Student
    {
        public Student()
        {
            Attendances = new HashSet<Attendance>();
            ScheduleOfStudents = new HashSet<ScheduleOfStudent>();
        }

        public string UserName { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime? Birthdate { get; set; }
        public bool? Gender { get; set; }
        public string RollNumber { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }

        public virtual Account UserNameNavigation { get; set; }
        public virtual ICollection<Attendance> Attendances { get; set; }
        public virtual ICollection<ScheduleOfStudent> ScheduleOfStudents { get; set; }
    }
}
