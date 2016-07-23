using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AptechWatch.Dao;
using AptechWatch.Entity;

namespace AptechWatch.Service
{
    public class BrandService : BaseService<Brand>
    {
        public BrandService() : base(new BrandDao())
        {
        }
    }
}