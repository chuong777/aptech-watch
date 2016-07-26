using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using AptechWatch.Models;
using AptechWatch.Service;

namespace AptechWatch.Controllers
{
    public class AdminController : Controller
    {
        private AdminService adminService { get; set; }

        public AdminController()
        {
            adminService = new AdminService();
        }

        public ActionResult Index()
        {
            if (!string.IsNullOrEmpty(Request.Cookies["CustomerUsername"]?.Value))
            {
                return RedirectToAction("Index", "Home");
            }
            var model = new UserModel();

            return View(model);
        }

        public ActionResult Login(UserModel user)
        {
            if (adminService.Login(user))
            {
                Response.Cookies["CustomerUsername"].Value = user.Username;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}