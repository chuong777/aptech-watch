using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AptechWatch.Entity
{
    public class Cart : BaseEntity
    {
        [Required]
        public int CustomerId { get; set; }
       [Required]
       public int WatchId { get; set; }

        public Cart()
        {
        }
    }
}