using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AptechWatch.Models;
using AptechWatch.Service;

namespace AptechWatch.Controllers
{
    public class CustomerController : Controller
    {
        private CustomerService customerService { get; set; }

        public CustomerController()
        {
            customerService = new CustomerService();
        }

        // GET: Customer
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
            if (ModelState.IsValid)
            {
                if (customerService.Login(user))
                {
                    Response.Cookies["CustomerUsername"].Value = user.Username;
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
            return View("Index", user);
        }

        public ActionResult Register()
        {
            if (!string.IsNullOrEmpty(Request.Cookies["CustomerUsername"]?.Value))
            {
                return RedirectToAction("Index");
            }
            var model = new UserModel();

            return View(model);
        }

        [HttpPost]
        public ActionResult Register(UserModel user)
        {
            if (ModelState.IsValid) return RedirectToAction(customerService.Register(user) ? "Index" : "Register");
            return View("Register", user);
        }
    }
}