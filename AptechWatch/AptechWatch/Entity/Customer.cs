using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AptechWatch.Entity
{
    public class Customer : BaseEntity
    {
        [Required]
        public string RealName { get; set;  }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Phone { get; set; }
        public int PhotoType { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<ViewList> ViewLists { get; set; }
        public virtual ICollection<Chat> Chats { get; set; }
        public virtual ICollection<WishList> WishLists { get; set; }

        public Customer()
        {
            
        }

        public Customer(string realName, string userName, string password, string address, string email, string phone, int photoType)
        {
            RealName = realName;
            UserName = userName;
            Password = password;
            Address = address;
            Email = email;
            Phone = phone;
            PhotoType = photoType;
        }
    }
}