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
        public string Name { get; set; }
        public int DiscountId { get; set; }
        public int CategoryId { get; set; }
        public int PhotoType { get; set; }
        public int PhotoUrlId { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<WishList> WishLists { get; set; }
        public virtual ICollection<ViewList> ViewLists { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; } 
        public virtual ICollection<WatchTag> WatchTags { get; set; } 
        public double Price { get; set; }

        public Watch()
        {
        }

        public Watch(string name, double price, int categoryId, int brandId)
        {
            Name = name;
            Price = price;
            CategoryId = categoryId;
            BrandId = brandId;
        }
    }
}