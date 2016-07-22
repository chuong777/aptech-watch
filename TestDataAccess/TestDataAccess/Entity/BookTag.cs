using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestDataAccess.Entity
{
    public class BookTag : BaseEntity
    {
        [Required]
        public int BookId { get; set; }

        public virtual Book Book { get; set; }

        [Required]
        public int TagId { get; set; }

        public virtual Tag Tag { get; set; }

        public BookTag()
        {
        }

        public BookTag(Book book, Tag tag)
        {
            Book = book;
            BookId = book.Id;
            Tag = tag;
            TagId = tag.Id;
        }
    }
}