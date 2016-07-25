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
        public String RealName { get; set;  }
        [Required]
        public String UserName { get; set; }
        [Required]
        public String Email { get; set; }
        [Required]
        public String Password { get; set; }
        [Required]
        public String Address { get; set; }
        [Required]
        public String Phone { get; set; }
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