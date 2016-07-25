using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AptechWatch.Entity
{
    public class WatchTag : BaseEntity
    {
        [Required]
        public int WatchId { get; set; }
        [Required]
        public int TagId { get; set; }

        public WatchTag()
        {

        }
    }
}