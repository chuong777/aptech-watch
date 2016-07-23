using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AptechWatch.Entity;
using AptechWatch.Exception;
using AptechWatch.Utils;

namespace AptechWatch.Controllers
{
    public class TestController : BaseController
    {
        // GET: Test
        public ActionResult Index()
        {
            try
            {
                C.BrandService.Delete(4);
            }
            catch (NotFoundWithIdEx e)
            {
                Debug.WriteLine(e);
            }
            
            return View();
        }
    }
}