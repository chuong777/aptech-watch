using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AptechWatch.Entity
{
    public class Admin : BaseEntity
    {
        public bool IsSuperAdmin { get; set; }
        public string Realname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int PhotoUrl { get; set; }
        public virtual List<News> News { get; set; }
        public virtual List<Chat> Chats { get; set; }

        public Admin()
        {
        }
    }
}