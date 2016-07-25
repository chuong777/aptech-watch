using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AptechWatch.Entity
{
    public class Comment: BaseEntity
    {
        public float Rate { get; set; }
        public String Content { get; set; }
        public String Title { get; set; }
        public int ParentComment { get; set; }
        public Customer Customer;

        public Comment()
        {
        }

        public Comment(float rate, string content, string title, int parentComment, Customer customer)
        {
            Rate = rate;
            Content = content;
            Title = title;
            ParentComment = parentComment;
            Customer = customer;
        }
    }
}