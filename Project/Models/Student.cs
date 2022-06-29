using System;
using System.Collections.Generic;

#nullable disable

namespace Project.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? Birthdate { get; set; }
        public bool? Gender { get; set; }
        public string Rollnumber { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }
    }
}
