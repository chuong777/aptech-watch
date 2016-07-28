using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AptechWatch.Models;
using AptechWatch.Service;

namespace AptechWatch.Controllers
{
    public class WatchController : Controller
    {
        private WatchService watchService { get; set; }
        public WatchController()
        {
            watchService = new WatchService();
        }
       
        // GET: Watch
        public ActionResult Index()
        {
            var listWatchs = watchService.FindAllWatches();
            var model = new WatchModel();
            return View(listWatchs);
        }

        [HttpPost]
        public ActionResult FindWatchByCategoryId(int id)
        {
            var listWatchs = this.watchService.FindAllWatchesByCategory(id);
            ViewBag.listWatchs = listWatchs;
            //Don't know can sent list via RedirectToAction or not, need confirm here
            return RedirectToAction("Index","Watch");
        }
        //GET Create Watch
        public ActionResult CreateWatch()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateWatch(WatchModel watchModel)
        {
            if (watchModel != null)
            {
                var createWatch = this.watchService.CreateWatch(watchModel);
                if (createWatch)
                {
                    //Need to do some message here to notification to user
                    //For example :
                    ViewBag.Message = "Create Watch Successfully !";
                    return View();
                }
            }
            //Show message to warning user missing something
            ViewBag.Message = "Create Watch failed, check for more information !";
            return View();
        }

        [HttpPost]
        public ActionResult DeleteWatch(int id)
        {
            var deleteWatch = this.watchService.DeleteWatch(id);
            if (deleteWatch)
            {
                //Message
                ViewBag.Message = "Delete Watch Successfully !";
                return RedirectToAction("Index", "Watch");
            }
            //Message
            ViewBag.Message = "Can't Delete Watch !";
            return RedirectToAction("Index", "Watch");
        }
        // GET Edit Watch
        public ActionResult EditWatch(WatchModel watchModel)
        {
            if (watchModel != null)
            {
                var editWatch = this.watchService.UpdateWatch(watchModel);
                if (editWatch)
                {
                    ViewBag.Message = "Edit Watch Successfully !";
                    return View();
                }

            }
            ViewBag.Message = "Can't edit Watch, check input for more information!";
            return View();
        }
    }
}