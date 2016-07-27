using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AptechWatch.Models
{
    public class WatchModel : BaseModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public int BrandId { get; set; }
        public int DiscountId { get; set; }
        public int PhotoUrlId { get; set; }
    }
}