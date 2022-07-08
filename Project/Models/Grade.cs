using System;
using System.Collections.Generic;

#nullable disable

namespace Project.Models
{
    public partial class Grade
    {
        public Grade()
        {
            Attendances = new HashSet<Attendance>();
        }

        public string Id { get; set; }
        public string ClassName { get; set; }
        public int? QuantityStudents { get; set; }

        public virtual ICollection<Attendance> Attendances { get; set; }
    }
}
