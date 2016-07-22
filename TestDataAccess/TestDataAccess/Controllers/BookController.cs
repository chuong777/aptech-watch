using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestDataAccess.Entity;
using TestDataAccess.Utils;

namespace TestDataAccess.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Detail(int bookId)
        {
            Book book = C.BookService.FindBookById(bookId);
            if (book == null) return View("~/Views/NotFound.cshtml");
            ViewBag.relatedBooks = C.BookService.GetRelatedBooks(book, 10);
            C.BookService.IncreaseViewCountBy1(book);
            return View(book);
        }
    }
}