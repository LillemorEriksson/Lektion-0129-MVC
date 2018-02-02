using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lektion_0129_MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        [HttpGet]
        public ActionResult TestingForm()
        {
            return View();
        }

        [ HttpPost]
        public ActionResult TestingForm(int multi)
        {
            ViewBag.multi = multi;

            return View();
        }
    }
}