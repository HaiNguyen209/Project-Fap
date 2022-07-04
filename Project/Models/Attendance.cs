using System;
using System.Collections.Generic;

#nullable disable

namespace Project.Models
{
    public partial class Attendance
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RollNumber { get; set; }
        public string Code { get; set; }
        public string Image { get; set; }
        public bool? Status { get; set; }
    }
}
