using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestDataAccess.Entity
{
    public class Author : BaseEntity
    {
//        public int a { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime Dob { get; set; }

        public virtual ICollection<Book> Books { get; set; }

        public Author()
        {
        }

        public Author(string name, DateTime dob)
        {
            Name = name;
            Dob = dob;
        }
    }
}