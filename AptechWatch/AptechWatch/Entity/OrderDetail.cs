using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AptechWatch.Entity
{
    public class OrderDetail : BaseEntity
    {
        [Required]
        public int OrderId { get; set; }
        [Required]
        public int WatchId { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int Quantity { get; set; }

        public OrderDetail()
        {

        }

        public OrderDetail(int orderId, int watchId, int quantity, double price)
        {
            OrderId = orderId;
            WatchId = watchId;
            Quantity = quantity;
            Price = price;
        }
    }
}