using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AptechWatch.Entity
{
    public class Watch : BaseEntity
    {
        [Required]
        public int BrandId { get; set; }

        public virtual Brand Brand { get; set; }

        [Required]
        public double Price { get; set; }

        public Watch()
        {
        }
    }
}