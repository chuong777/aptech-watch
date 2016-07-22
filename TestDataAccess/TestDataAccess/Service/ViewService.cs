using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestDataAccess.Entity;
using TestDataAccess.Utils;

namespace TestDataAccess.Service
{
    public class ViewService
    { 
        public View Add(View view)
        {
            C.DbContext.Views.Add(view);
            C.DbContext.SaveChanges();
            C.BookService.IncreaseViewCountBy1(view.Book);
            return view;
        }

        public List<Book> FindBookViewedByUser(User user)
        {
            var q = (from a in C.DbContext.Views
                     where a.UserId == user.Id
                     select a.Book).ToList();
            return q;
        }
    }
}