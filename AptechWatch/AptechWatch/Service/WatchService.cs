using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AptechWatch.Dao;
using AptechWatch.Entity;

namespace AptechWatch.Service
{
    public class WatchService : BaseService<Watch>
    {
        public WatchService() : base(new WatchDao())
        {
        }
    }
}