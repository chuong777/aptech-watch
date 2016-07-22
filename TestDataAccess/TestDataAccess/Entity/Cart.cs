using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestDataAccess.Entity
{
    public class Cart : BaseEntity
    {
        [Required]
        public int UserId { get; set; }

        public virtual User User { get; set; }

        [Required]
        public int BookId { get; set; }

        public virtual Book Book { get; set; }

        [Required]
        public DateTime Time { get; set; }

        public Cart()
        {
        }

        public Cart(User user, Book book, DateTime time)
        {
            User = user;
            UserId = user.Id;
            Book = book;
            BookId = book.Id;
            Time = time;
        }
    }
}