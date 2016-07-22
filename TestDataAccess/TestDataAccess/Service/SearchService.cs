using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestDataAccess.Entity;
using TestDataAccess.Utils;

namespace TestDataAccess.Service
{
    public class SearchService
    {
        public List<Book> SearchBooks(string keyword, string categoryName, string authorName)
        {
            var q = (from a in C.DbContext.Books
                     where a.Title.ToLower() == keyword.ToLower()
                     select a).ToList();
            List<Book> books = new List<Book>();
            foreach (var book in q)
            {
                if ((categoryName == null || book.Category.Name.ToLower().Equals(categoryName.ToLower()))
                    && (authorName == null || book.Author.Name.ToLower().Equals(authorName.ToLower())))
                {
                    books.Add(book);
                }
            }
            return books;
        }
    }
}