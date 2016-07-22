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
    public class SearchController : Controller
    {
        // GET: Search
        public ActionResult Index()
        {
            ViewBag.categories = C.CategoryService.FindAllCategories();
            ViewBag.authors = C.AuthorService.FindAllAuthors();
            return View();
        }

        [HttpGet]
        public ActionResult SearchAll(SearchM searchM)
        {
            List<Book> books = C.SearchService.SearchBooks(searchM.Keyword, searchM.CategoryName, searchM.AuthorName);
            return PartialView("BookListPartial", books);
        }
    }
}