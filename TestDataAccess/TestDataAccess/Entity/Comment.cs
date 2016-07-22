using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestDataAccess.Entity
{
    public class Comment : BaseEntity
    {
        [Required]
        public int UserId { get; set; }

        public virtual User User { get; set; }

        [Required]
        public int BookId { get; set; }

        public virtual Book Book { get; set; }

        [Required]
        public DateTime Time { get; set; }

        [Required]
        public byte Rate { get; set; }

        [Required]
        public string Message { get; set; }

        [Required]
        public string ShortMessage { get; set; }

        public Comment()
        {
        }

        public Comment(User user, Book book, DateTime time, byte rate, string message, string shortMessage)
        {
            User = user;
            UserId = user.Id;
            Book = book;
            BookId = book.Id;
            Time = time;
            Rate = rate;
            Message = message;
            ShortMessage = shortMessage;
        }
    }
}