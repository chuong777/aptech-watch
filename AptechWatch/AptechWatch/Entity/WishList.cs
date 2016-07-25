using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AptechWatch.Entity
{
    public class WishList : BaseEntity
    {
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public int WatchId { get; set; }
        [Required]
        public DateTime Time { get; set; }

        public WishList()
        {

        }

        public WishList(DateTime time)
        {
        }
    }
}