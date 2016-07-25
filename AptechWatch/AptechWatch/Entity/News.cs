using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AptechWatch.Entity
{
    public class News: BaseEntity
    {
        [Required]
        public String Content { get; set; }
        [Required]
        public  DateTime Date { get; set; }
        [Required]
        public int AdminId { get; set; }

        public News()
        {

        }

        public News(string content, DateTime date)
        {
            Content = content;
            Date = date;
        }
    }
}