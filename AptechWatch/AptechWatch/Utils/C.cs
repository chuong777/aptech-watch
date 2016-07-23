using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using AptechWatch.Service;

namespace AptechWatch.Utils
{
    public class C
    {
        public static MVCDbContext DbContext = new MVCDbContext();
        public static BrandService BrandService = new BrandService();
        public static DataFormatter DataFormatter = new DataFormatter();
    }
}