using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AptechWatch.Entity
{
    public class Category : BaseEntity
    {
        [Required]
        public string Title { get; set; }

        public Category()
        {
        }

        public Category(string title)
        {
            Title = title;
        }
    }
}