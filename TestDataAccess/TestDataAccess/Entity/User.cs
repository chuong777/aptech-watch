using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestDataAccess.Entity
{
    public class User : BaseEntity
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string RealName { get; set; }

        public virtual ICollection<Bill> Bills { get; set; }

        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }

        public virtual ICollection<Love> Loves { get; set; }

        public virtual ICollection<View> Views { get; set; }

        public User()
        {
        }

        public User(string userName, string password, string realName)
        {
            UserName = userName;
            Password = password;
            RealName = realName;
        }
    }
}