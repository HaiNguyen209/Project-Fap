using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Project.Models
{
    public partial class Account
    {
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false , ErrorMessage = "Username is not empty")]
        public string UserName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Password is not empty")]
        [MaxLength(6,ErrorMessage = "Password less than 6 character")]
        public string Password { get; set; }
        public int? RoleId { get; set; }

        public Account(int id, string userName, string password, int? roleId, Role role)
        {
            Id = id;
            UserName = userName;
            Password = password;
            RoleId = roleId;
            Role = role;
        }

        public Account()
        {
        }

        public virtual Role Role { get; set; }

    }

}
