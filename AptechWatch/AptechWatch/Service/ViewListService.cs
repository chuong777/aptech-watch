using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AptechWatch.Dao;
using AptechWatch.Entity;

namespace AptechWatch.Service
{
    public class ViewListService : BaseService<ViewList>
    {
        public ViewListService() : base(new ViewListDao())
        {
        }
    }
}