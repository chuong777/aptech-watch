using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestDataAccess.Utils;

namespace TestDataAccess.Controllers
{
    public class ViewController : Controller
    {
        // GET: View
        public ActionResult Index()
        {
            return View(C.ViewService.FindBookViewedByUser(C.UserService.GetCurrentUser()));
        }
    }
}