using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Project.Model
{
    public partial class Student
    {
        public Student()
        {
            Attendances = new HashSet<Attendance>();
            ScheduleOfStudents = new HashSet<ScheduleOfStudent>();
        }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Username is not empty")]

        public string UserName { get; set; }

        public string Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Name is not empty")]

        public string Name { get; set; }


        public DateTime? Birthdate { get; set; }
        public bool? Gender { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "RollNumber is not empty")]

        public string RollNumber { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Address is not empty")]

        public string Address { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Phone is not empty")]
        public string Phone { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Email is not empty")]

        public string Email { get; set; }
        public string Image { get; set; }

        public virtual Account UserNameNavigation { get; set; }
        public virtual ICollection<Attendance> Attendances { get; set; }
        public virtual ICollection<ScheduleOfStudent> ScheduleOfStudents { get; set; }
    }
}
