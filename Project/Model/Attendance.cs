using System;
using System.Collections.Generic;

#nullable disable

namespace Project.Model
{
    public partial class Attendance
    {
        public string TeacherId { get; set; }
        public int Id { get; set; }
        public string StudentId { get; set; }
        public string ClassId { get; set; }
        public string Name { get; set; }
        public string RollNumber { get; set; }
        public string Code { get; set; }
        public bool? Status { get; set; }

        public virtual Grade Class { get; set; }
        public virtual Student Student { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
