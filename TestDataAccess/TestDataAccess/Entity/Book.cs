using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestDataAccess.Entity
{
    public class Book : BaseEntity
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public int AuthorId { get; set; }

        public virtual Author Author { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int TotalPage { get; set; }

        [Required]
        public DateTime PublishTime { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public string ImageFileName { get; set; }

        public int ViewCount { get; set; }
        public int LoveCount { get; set; }
        public int CartCount { get; set; }
        public int BuyCount { get; set; }
        public int CommentCount { get; set; }
        public float Rating { get; set; }

        public virtual ICollection<BookTag> BookTags { get; set; }

        public virtual ICollection<Cart> Carts { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        public virtual ICollection<Discount> Discounts { get; set; }

        public virtual ICollection<Love> Loves { get; set; }

        public virtual ICollection<View> Views { get; set; }

        public Book()
        {
        }

        public Book(string title, int price, Author author, string description, int totalPage,
            DateTime publishTime, Category category, int quantity, string imageFileName)
        {
            Title = title;
            Price = price;
            Author = author;
            this.AuthorId = author.Id;
            Description = description;
            TotalPage = totalPage;
            PublishTime = publishTime;
            Category = category;
            this.CategoryId = category.Id;
            Quantity = quantity;
            ImageFileName = imageFileName;
        }

        public Discount GetCurrentDiscout()
        {
            if (Discounts == null) return null;
            DateTime now = DateTime.Now;
            foreach (Discount discount in Discounts)
            {
                if (DateTime.Compare(now, discount.StartTime) > 0 && DateTime.Compare(now, discount.EndTime) < 0)
                {
                    return discount;
                }
            }
            return null;
        }
    }
}