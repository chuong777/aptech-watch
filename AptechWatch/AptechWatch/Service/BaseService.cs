using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AptechWatch.Dao;
using AptechWatch.Entity;
using AptechWatch.Utils;

namespace AptechWatch.Service
{
    public abstract class BaseService<T> where T : BaseEntity
    {
        private BaseDao<T> BaseDao;

        protected BaseService(BaseDao<T> baseDao)
        {
            BaseDao = baseDao;
        }

        public T FindById(int id)
        {
            return BaseDao.FindById(id);
        }

        public T Insert(T entity)
        {
            return BaseDao.Insert(entity);
        }

        public T Delete(T entity)
        {
            return BaseDao.Delete(entity);
        }

        public T Delete(int id)
        {
            return BaseDao.Delete(id);
        }
    }
}