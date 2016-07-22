using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestDataAccess.Entity;
using TestDataAccess.Models;
using TestDataAccess.Utils;

namespace TestDataAccess.Controllers
{
    public class AccController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            if (C.UserService.IsUserLogin())
            {
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Login", "Acc");
        }

        public ActionResult Login(string message, string fromUrl)
        {
            if (message != null) TempData["message"] = message;
            if (fromUrl != null) TempData["fromUrl"] = fromUrl;
            return View();
        }

        [HttpPost]
        public ActionResult Login(string userName, string password, string fromUrl)
        {
            var user = C.UserService.FindUserByUserNamePassword(userName, password);
            if (user == null)
            {
                TempData["message"] = "User name or password is wrong";
                return View();
            }
            C.UserService.SetCurrentUser(user);
            if (fromUrl == null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                try
                {
                    return Redirect(fromUrl);
                }
                catch (Exception)
                {
                    return View("~/Views/NotFound.cshtml");
                }
            }
        }

        public ActionResult Logout()
        {
            C.UserService.DeleteCurrentUser();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Signup(string userName, string password, string realName)
        {
            User user = new User(userName, password, realName);
            Result<User> result = C.UserService.Add(user);
            ViewBag.message = result.Message;
            if (result.IsSuccess)
            {
                return View("SignupSuccess");
            }
            return View();
        }
    }
}