using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestDataAccess.Entity;
using TestDataAccess.Utils;

namespace TestDataAccess.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        public ActionResult Index()
        {
            return View(C.CartService.FindBookCartdByUser(C.UserService.GetCurrentUser()));
        }

        [HttpPost]
        public ActionResult AddBookToCart(int bookId, string fromUrl)
        {
            if (C.UserService.IsUserLogin())
            {
                Book book = C.BookService.FindBookById(bookId);
                if (book == null) return Json(new AjaxResponse(false, "No book with id " + bookId, null));
                C.CartService.Add(new Cart(C.UserService.GetCurrentUser(), book, DateTime.Now));
                return Json(new AjaxResponse(true, book.Title + " has been added to cart", null));
            }
            else
            {
                TempData["message"] = "Please login before adding to cart";
                return Json(new AjaxResponse(false, "", Url.Action("Login", "Acc", new {fromUrl})));
            }
        }

        [HttpPost]
        public ActionResult RemoveBookFromCart(int bookId, string fromUrl)
        {
            if (C.UserService.IsUserLogin())
            {
                Book book = C.BookService.FindBookById(bookId);
                if (book == null) return Json(new AjaxResponse(false, "No book with id " + bookId, null));
                Cart cart = C.CartService.FindCartByUserBook(C.UserService.GetCurrentUser(), book);
                if (cart == null) return Json(new AjaxResponse(false, "No cart exists", null));
                C.CartService.Remove(cart);
                return Json(new AjaxResponse(true, book.Title + " has been removed from cart", null));
            }
            else
            {
                TempData["message"] = "Please login before remove from cart";
                return Json(new AjaxResponse(false, "", Url.Action("Login", "Acc", new { fromUrl })));
            }
        }
    }
}