using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using AptechWatch.Entity;
using AptechWatch.Exception;
using AptechWatch.Utils;
using Microsoft.Ajax.Utilities;
using TestDataAccess.Utils;

namespace AptechWatch.Dao
{
    public abstract class BaseDao<T> : DbSet<T> where T : BaseEntity
    {
        private DbSet<T> DbSet = C.DbContext.GetRightDbSet<T>();

        public T FindById(int id)
        {
            return (from item in DbSet where item.Id == id select item).SingleOrDefault();
        }

        public ICollection<T> FindAll()
        {
            var q = (from item in DbSet select item).ToList();
            return q;
        }

        public T Insert(T entity)
        {
            DbSet.Add(entity);
            C.DbContext.SaveChanges();
            return entity;
        }

        public T Update(T entity)
        {
            C.DbContext.SaveChanges();
            return entity;
        }

        public T Delete(T entity)
        {
            DbSet.Remove(entity);
            C.DbContext.SaveChanges();
            return entity;
        }

        public T Delete(int id)
        {
            T entity = FindById(id);
            if (entity == null) throw new NotFoundWithIdEx(typeof(T).Name);
            DbSet.Remove(entity);
            C.DbContext.SaveChanges();
            return entity;
        }
    }
}