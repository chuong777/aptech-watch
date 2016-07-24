using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AptechWatch.Entity
{
    public class Admin : BaseEntity
    {
        // Role = 0 is super, 1 is normal
        public int Role { get; set; }
        [Required]
        public string RealName { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        public string Email { get; set; }
        public int PhotoType { get; set; }
        public virtual ICollection<Watch> News { get; set; }
        public virtual ICollection<Watch> Chats { get; set; }
    }
}