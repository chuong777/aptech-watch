using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestDataAccess.Entity;
using TestDataAccess.Utils;

namespace TestDataAccess.Controllers
{
    public class CommentController : Controller
    {
        // GET: Comment
        public ActionResult Index()
        {
            if (C.UserService.IsUserLogin())
            {
                return View(C.CommentService.FindBookCommentedByUser(C.UserService.GetCurrentUser()));
            }
            else
            {
                TempData["message"] = "Please login before comment";
                return RedirectToAction("Login", "Acc");
            }
        }

        public ActionResult CommentForABook(int bookId, byte rate, string message, string shortMessage,
            string fromUrl)
        {
            Book book = C.BookService.FindBookById(bookId);
            if (book == null) return Json(new AjaxResponse(false, "Can't find book with id " + bookId, null));
            if (C.UserService.IsUserLogin())
            {
                if (rate == 0 || message == null || shortMessage == null)
                {
                    return Json(new AjaxResponse(false, "Some field is null, try again", null));
                }
                Comment comment = new Comment(C.UserService.GetCurrentUser(), book, DateTime.Now, rate, message, shortMessage);
                C.CommentService.Add(comment);
                return Json(new AjaxResponse(true, "Your comment has been posted", null));
            }
            else
            {
                TempData["message"] = "Please login before comment";
                return Json(new AjaxResponse(false, "", Url.Action("Login", "Acc", new {fromUrl})));
            }
        }
    }
}