using System;
using System.Collections.Generic;

#nullable disable

namespace Project.Models
{
    public partial class Role
    {
        public Role()
        {
            Accounts = new HashSet<Account>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public Role(int id, string name, ICollection<Account> accounts)
        {
            Id = id;
            Name = name;
            Accounts = accounts;
        }

        public virtual ICollection<Account> Accounts { get; set; }
    }
}
