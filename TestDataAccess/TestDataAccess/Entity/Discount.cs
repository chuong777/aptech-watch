using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestDataAccess.Entity
{
    public class Discount : BaseEntity
    {
        [Required]
        public int BookId { get; set; }

        public virtual Book Book { get; set; }

        [Required]
        public int Percent { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }

        public Discount()
        {
        }

        public Discount(Book book, int percent, DateTime startTime, DateTime endTime)
        {
            Book = book;
            BookId = book.Id;
            Percent = percent;
            StartTime = startTime;
            EndTime = endTime;
        }
    }
}