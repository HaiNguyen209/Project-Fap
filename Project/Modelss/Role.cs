using System;
using System.Collections.Generic;

#nullable disable

namespace Project.Modelss
{
    public partial class Role
    {
        public Role()
        {
            Accounts = new HashSet<Account>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
    }
}
