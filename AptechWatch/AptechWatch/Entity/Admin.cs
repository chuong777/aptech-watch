using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AptechWatch.Entity
{
    public class Admin : BaseEntity
    {
        [Required]
        public int Role { get; set; }
        [Required]
        public string RealName { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Emaill { get; set; }
        public int PhotoType { get; set; }
        public int PhotoUrl { get; set; }
        public virtual ICollection<News> Newses { get; set; }
        public virtual ICollection<Chat> Chats { get; set; }

        public Admin()
        {

        }

        public Admin(int role, string realName, string userName, string password, string emaill, int photoType, int photoUrl)
        {
            Role = role;
            RealName = realName;
            UserName = userName;
            Password = password;
            Emaill = emaill;
            PhotoType = photoType;
            PhotoUrl = photoUrl;
        }
    }
}