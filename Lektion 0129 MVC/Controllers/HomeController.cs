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
        public ActionResult Mattetabel()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Mattetabel(int multi)
        {
            List<int> nummerna = new List<int>();

            if (Session["vilkaNummer"] != null)
            {
                            // type-cast
                nummerna = (List<int>)Session["vilkaNummer"];
            }

            nummerna.Add(multi);// lägga till nya nummer
            Session["vilkaNummer"] = nummerna;// spara listan med nummer


            ViewBag.multi = multi;

            return View();
        }
    }
}