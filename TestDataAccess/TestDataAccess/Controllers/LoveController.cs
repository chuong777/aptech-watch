using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestDataAccess.Entity;
using TestDataAccess.Utils;

namespace TestDataAccess.Controllers
{
    public class LoveController : Controller
    {
        // GET: Love
        public ActionResult Index()
        {
            return View(C.LoveService.FindBookLovedByUser(C.UserService.GetCurrentUser()));
        }

        [HttpPost]
        public ActionResult AddBookToLove(int bookId, string fromUrl)
        {
            if (C.UserService.IsUserLogin())
            {
                Book book = C.BookService.FindBookById(bookId);
                if (book == null) return Json(new AjaxResponse(false, "No book with id " + bookId, null));
                C.LoveService.Add(new Love(C.UserService.GetCurrentUser(), book, DateTime.Now));
                return Json(new AjaxResponse(true, book.Title + " has been added to love", null));
            }
            else
            {
                TempData["message"] = "Please login before adding to love";
                return Json(new AjaxResponse(false, "", Url.Action("Login", "Acc", new { fromUrl })));
                ;
            }
        }

        [HttpPost]
        public ActionResult RemoveBookFromLove(int bookId, string fromUrl)
        {
            if (C.UserService.IsUserLogin())
            {
                Book book = C.BookService.FindBookById(bookId);
                if (book == null) return Json(new AjaxResponse(false, "No book with id " + bookId, null));
                Love love = C.LoveService.FindLoveByUserBook(C.UserService.GetCurrentUser(), book);
                if (love == null) return Json(new AjaxResponse(false, "No love exists", null));
                C.LoveService.Remove(love);
                return Json(new AjaxResponse(true, book.Title + " has been removed from love", null));
            }
            else
            {
                TempData["message"] = "Please login before remove from love";
                return Json(new AjaxResponse(false, "", Url.Action("Login", "Acc", new { fromUrl })));
                ;
            }
        }
    }
}