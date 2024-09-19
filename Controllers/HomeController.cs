using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Auctions.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.active = "Index";
            return View();
        }

        public ActionResult Catalogue()
        {
            ViewBag.active = "Index";
            return View();
        }

        public ActionResult Lot()
        {
            ViewBag.active = "Index";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.active = "About";
            ViewBag.Message = "DDWT Auction page";
            return View();
        }


    }
}