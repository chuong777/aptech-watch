using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Web;
using TestDataAccess.Entity;
using TestDataAccess.Utils;

namespace TestDataAccess.Service
{
    public class BookService
    {
        public Book FindBookById(int id)
        {
            var q = (from a in C.DbContext.Books
                where a.Id == id
                select a).FirstOrDefault();
            return q;
        }

        public List<Book> FindBooksByCategory(Category category)
        {
            return FindBooksByCategory(category.Id);
        }

        public List<Book> FindBooksByCategory(int categoryId)
        {
            var q = (from a in C.DbContext.Books
                where a.CategoryId == categoryId
                select a).ToList();
            return q;
        }

        public Book IncreaseViewCountBy1(Book book)
        {
            book.ViewCount++;
            C.DbContext.SaveChanges();
            return book;
        }

        public Book IncreaseLoveCountBy1(Book book)
        {
            book.LoveCount++;
            C.DbContext.SaveChanges();
            return book;
        }

        public Book IncreaseCartCountBy1(Book book)
        {
            book.CartCount++;
            C.DbContext.Books.Attach(book);
            var entry = C.DbContext.Entry(book);
            entry.Property(e => e.CartCount).IsModified = true;
            C.DbContext.SaveChanges();
            return book;
        }

        public Book RateForBook(Book book, float rating)
        {
            book.CommentCount++;
            book.Rating = (book.Rating*(book.CommentCount - 1) + rating)/book.CommentCount;
            C.DbContext.SaveChanges();
            return book;
        }

        public List<Book> GetRelatedBooks(Book book, int limit)
        {
            List<Book> books = new List<Book>();
            foreach (var bookTag in book.BookTags)
            {
                foreach (var tag in bookTag.Tag.BookTags)
                {
                    books.Add(tag.Book);
                }
            }
            List<Book> sortedBooks = books.OrderBy(i => i.ViewCount).ToList();
            List<Book> resultBooks = new List<Book>();
            int count = 0;
            foreach (var b in sortedBooks)
            {
                if (count < limit && book.Id != b.Id)
                {
                    resultBooks.Add(b);
                }
                count++;
            }
            return resultBooks;
        }
    }
}