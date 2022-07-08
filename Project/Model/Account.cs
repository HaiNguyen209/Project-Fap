using System;
using System.Collections.Generic;

#nullable disable

namespace Project.Model
{
    public partial class Account
    {
        public Account()
        {
            Students = new HashSet<Student>();
            Teachers = new HashSet<Teacher>();
        }

        public string UserName { get; set; }
        public string Password { get; set; }
        public int? RoleId { get; set; }

        public virtual Role Role { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}
