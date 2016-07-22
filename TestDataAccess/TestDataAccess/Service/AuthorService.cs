using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestDataAccess.Entity;
using TestDataAccess.Utils;

namespace TestDataAccess.Service
{
    public class AuthorService
    {
        public Author FindById(int id)
        {
            var q = (from a in C.DbContext.Authors
                where a.Id == id
                select a).FirstOrDefault();
            return q;
        }

        public T test<T>(int id)
        {
            var q = (from a in C.DbContext.Books
                     where a.Id == id
                     select a).FirstOrDefault();
            return q;
        }

        public List<Author> FindAllAuthors()
        {
            var q = (from a in C.DbContext.Authors
                select a).ToList();
            return q;
        }
    }
}