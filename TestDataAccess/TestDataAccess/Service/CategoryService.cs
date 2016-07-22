using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestDataAccess.Entity;
using TestDataAccess.Utils;

namespace TestDataAccess.Service
{
    public class CategoryService
    {
        public Category FindById(int id)
        {
            var q = (from a in C.DbContext.Categories
                where a.Id == id
                select a).FirstOrDefault();
            return q;
        }

        public List<Category> FindAllCategories()
        {
            var q = (from a in C.DbContext.Categories
                select a).ToList();
            return q;
        }
    }
}