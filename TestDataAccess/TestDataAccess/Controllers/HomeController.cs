using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestDataAccess.Entity;
using TestDataAccess.Utils;

namespace TestDataAccess.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Category> categories = C.CategoryService.FindAllCategories();
            ViewBag.categories = categories;
            IDictionary<Category, List<Book>> booksByCategory = new Dictionary<Category, List<Book>>();
            foreach (var category in categories)
            {
                List<Book> books = C.BookService.FindBooksByCategory(category);
                booksByCategory.Add(category, books);
            }
            ViewBag.booksByCategory = booksByCategory;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}