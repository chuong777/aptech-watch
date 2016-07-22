using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestDataAccess.Entity
{
    public class Buy : BaseEntity
    {
        [Required]
        public int BookId { get; set; }

        public virtual Book Book { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public DateTime Time { get; set; }


        [Required]
        public int BillId { get; set; }

        public virtual Bill Bill { get; set; }

        public Buy()
        {
        }

        public Buy(Book book, int price, int quantity, DateTime time, Bill bill)
        {
            Book = book;
            BookId = book.Id;
            Price = price;
            Quantity = quantity;
            Time = time;
            Bill = bill;
            BillId = bill.Id;
        }
    }
}