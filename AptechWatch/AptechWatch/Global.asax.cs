using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AptechWatch.Utils;
using TestDataAccess.Utils;

namespace AptechWatch
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            MyDbInitializer initializer = new MyDbInitializer();
            initializer.InitializeDatabase(C.DbContext);
            System.Data.Entity.Database.SetInitializer(initializer);
        }
    }
}
