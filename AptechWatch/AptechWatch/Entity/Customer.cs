using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AptechWatch.Entity
{
    public class Customer:BaseEntity
    {
        [Required]
        public string Realname { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public virtual ICollection<Watch> Views { get; set; }
        public virtual ICollection<Watch> Wishes { get; set; }
        public virtual ICollection<Watch> Carts { get; set; }
        public virtual ICollection<Watch> Chats { get; set; }
    }
}