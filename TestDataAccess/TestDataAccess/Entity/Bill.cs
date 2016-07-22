using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestDataAccess.Entity
{
    public class Bill : BaseEntity
    {
        [Required]
        public int UserId { get; set; }

        public virtual User User { get; set; }

        [Required]
        public DateTime Time { get; set; }

        [Required]
        public virtual ICollection<Buy> Buys { get; set; }

        public Bill()
        {
        }

        public Bill(int userId, User user, DateTime time, ICollection<Buy> buys)
        {
            UserId = userId;
            User = user;
            Time = time;
            Buys = buys;
        }
    }
}