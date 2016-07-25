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
        public String Name { get; set; }
        public String Phone { get; set; }
        public String Address { get; set; }
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