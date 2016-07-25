using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AptechWatch.Entity
{
    public class Order : BaseEntity
    {
        [Required]
        public DateTime Time { get; set; }
        [Required]
        public int Customer { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        public Order()
        {

        }

        public Order(DateTime time, string name, int customer, string address, string phone)
        {
            Time = time;
            Name = name;
            Customer = customer;
            Address = address;
            Phone = phone;
        }
    }
}