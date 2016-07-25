using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AptechWatch.Entity
{
    public class Discount:BaseEntity
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Precent { get; set; }
        public ICollection<Watch> Watches { get; set; }

        public Discount()
        {

        }
        public Discount(DateTime startDate, DateTime endDate)
        {
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}