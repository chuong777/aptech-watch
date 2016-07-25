using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AptechWatch.Entity
{
    public class Category
    {
        [Required]
        public String Title { get; set; }

        public Category()
        {
        }

        public Category(string title)
        {
            Title = title;
        }
    }
}