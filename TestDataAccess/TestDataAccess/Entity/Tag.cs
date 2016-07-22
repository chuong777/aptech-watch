using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestDataAccess.Entity
{
    public class Tag : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        public virtual ICollection<BookTag> BookTags { get; set; }

        public Tag()
        {
        }

        public Tag(string name)
        {
            Name = name;
        }
    }
}