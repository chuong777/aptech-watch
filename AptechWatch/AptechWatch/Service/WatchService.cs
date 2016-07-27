using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AptechWatch.Dao;
using AptechWatch.Entity;
using AptechWatch.Models;
using AptechWatch.Utils;

namespace AptechWatch.Service
{
    public class WatchService : BaseService<Watch>
    {
        public WatchService() : base(new WatchDao())
        {
           
        }
        public Watch FindWatchByName(string name)
        {
            var result = (from a in C.DbContext.Watches
                     where a.Name == name
                     select a).FirstOrDefault();
            return result;
        }
        public Watch FindWatchById(int id)
        {
            var result = (from a in C.DbContext.Watches
                     where a.Id == id
                     select a).FirstOrDefault();
            return result;
        }

        public Watch FindWatchByNameAndId(string name,int id)
        {
            var result = (from a in C.DbContext.Watches
                     where a.Id == id && a.Name == name
                     select a).FirstOrDefault();
            return result;
        }

        public List<Watch> FindAllWatchesByCategory(int id)
        {
            var result = (from a in C.DbContext.Watches
                          where a.CategoryId == id
                          select a).ToList();
            return result;
        } 

        public List<Watch> FindAllWatches()
        {
            var result = (from a in C.DbContext.Watches
                   select a).ToList();
            return result;
        }

        public bool CreateWatch(WatchModel watchModel)
        {
            //Check Watch based on name (can check name && id)
            Watch checkWatch = FindWatchByName(watchModel.Name);
            if (watchModel.Name != null && watchModel.Price > 0)
            {
                if (watchModel.Name == checkWatch.Name)
                {
                    //Mean Watch's exist can't create new
                    return false;
                }
                else
                {
                    //Create new Watch if not exist
                    Watch newWatch = new Watch(watchModel.Name,watchModel.Price,watchModel.CategoryId,watchModel.BrandId);
                    C.DbContext.Watches.Add(newWatch);
                    C.DbContext.SaveChanges();
                }
            }
            return true;
        }

        public bool DeleteWatch(int id)
        {
            Watch checkWatch = FindWatchById(id);
            if (checkWatch != null)
            {
                C.DbContext.Watches.Remove(checkWatch);
                C.DbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool UpdateWatch(WatchModel watchModel)
        {
            //Check watch based on Name(can check name && id)
            Watch checkWatch = FindWatchByName(watchModel.Name);
            //Name or Id equals, will update Watch
            if (checkWatch.Name == watchModel.Name || checkWatch.Id == watchModel.Id) 
            {
                Watch updateWatch = new Watch(
                    checkWatch.Name = watchModel.Name,
                    checkWatch.Price = watchModel.Price,
                    checkWatch.CategoryId = watchModel.CategoryId,
                    checkWatch.BrandId = watchModel.BrandId);
                C.DbContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}