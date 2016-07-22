using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TestDataAccess.Entity;
using TestDataAccess.Utils;

namespace TestDataAccess.Service
{
    public abstract class AbstractService<T> : DbSet<T> where T : BaseEntity
    {
        public T FindById(int id)
        {
            return (from a in this where a.Id == id select a).SingleOrDefault();
        }
    }
}