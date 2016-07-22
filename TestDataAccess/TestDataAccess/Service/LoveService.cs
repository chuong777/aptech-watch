using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestDataAccess.Entity;
using TestDataAccess.Utils;

namespace TestDataAccess.Service
{
    public class LoveService
    {
        public Love FindLoveByUserBook(User user, Book book)
        {
            var q = (from a in C.DbContext.Loves
                where a.UserId == user.Id && a.BookId == book.Id
                select a).FirstOrDefault();
            return q;
        }

        public List<Book> FindBookLovedByUser(User user)
        {
            var q = (from a in C.DbContext.Loves
                where a.UserId == user.Id
                select a.Book).ToList();
            return q;
        }

        public Love Add(Love love)
        {
            C.DbContext.Loves.Add(love);
            C.DbContext.SaveChanges();
            C.BookService.IncreaseLoveCountBy1(love.Book);
            return love;
        }

        public Love Remove(Love love)
        {
            C.DbContext.Loves.Remove(love);
            C.DbContext.SaveChanges();
            return love;
        }

        public Love IsCurrentUserLovedBook(Book book)
        {
            if (!C.UserService.IsUserLogin()) return null;
            if (C.UserService.GetCurrentUser().Loves == null) return null;
            foreach (Love love in C.UserService.GetCurrentUser().Loves)
            {
                if (love.BookId == book.Id) return love;
            }
            return null;
        }
    }
}