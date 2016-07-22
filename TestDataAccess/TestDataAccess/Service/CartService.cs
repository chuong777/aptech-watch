using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestDataAccess.Entity;
using TestDataAccess.Utils;

namespace TestDataAccess.Service
{
    public class CartService
    {
        public Cart Add(Cart cart)
        {
            C.DbContext.Carts.Add(cart);
            C.DbContext.SaveChanges();
            C.BookService.IncreaseCartCountBy1(cart.Book);
            return cart;
        }

        public Cart FindCartByUserBook(User user, Book book)
        {
            var q = (from a in C.DbContext.Carts
                     where a.UserId == user.Id && a.BookId == book.Id
                     select a).FirstOrDefault();
            return q;
        }

        public List<Book> FindBookCartdByUser(User user)
        {
            var q = (from a in C.DbContext.Carts
                     where a.UserId == user.Id
                     select a.Book).ToList();
            return q;
        }

        public Cart Remove(Cart cart)
        {
            C.DbContext.Carts.Remove(cart);
            C.DbContext.SaveChanges();
            return cart;
        }

        public Cart IsCurrentUserCartedBook(Book book)
        {
            if (!C.UserService.IsUserLogin()) return null;
            if (C.UserService.GetCurrentUser().Carts == null) return null;
            foreach (Cart cart in C.UserService.GetCurrentUser().Carts)
            {
                if (cart.BookId == book.Id) return cart;
            }
            return null;
        }
    }
}