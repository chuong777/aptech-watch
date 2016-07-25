using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AptechWatch.Entity
{
    public class Chat: BaseEntity
    {
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public int Admin { get; set; }
        [Required]
        public String Name { get; set; }
        public String Email { get; set; }
        public String Phone { get; set; }
        public List<String> Message { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        public virtual List<Message> Messages { get; set; }

        public Chat()
        {
        }

        public Chat(int customerId, int admin, string name, string email, string phone, List<string> message, DateTime startDate)
        {
            CustomerId = customerId;
            Admin = admin;
            Name = name;
            Email = email;
            Phone = phone;
            Message = message;
            StartDate = startDate;
        }
    }
}