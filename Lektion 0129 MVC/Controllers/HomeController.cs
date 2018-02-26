using Lektion_0129_MVC.Models;
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
            Car myCar = new Car() { Brand = "Saab", Model = "900", MaxSpeed = 246 };
            Boat myBoat = new Boat() { Id = 1, Name = "Titanic", Info = "Sunken" };
            CarBoatViewModel vm = new CarBoatViewModel() { Car = myCar, Boat = myBoat };

            return View(vm);
        }

        public ActionResult About()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Mattetabel()
        {
            HttpCookie myCookie = Request.Cookies.Get("CookieNummber");
            if (myCookie != null)
            {
                List<int> nummerna = new List<int>();
                string[] stringNumbers = myCookie.Value.Split('q');// man kan skriva var istället för string men det är tydligare med string
                foreach (var item in stringNumbers)
                {
                    nummerna.Add(int.Parse(item));
                }
                Session["vilkaNummer"] = nummerna;
            }
            return View();
        }

        [HttpPost]
        public ActionResult Mattetabel(int multi)
        {
            HttpCookie myCookie;
            List<int> nummerna = new List<int>();//syan heter List

            if (Session["vilkaNummer"] != null)
            {
                // type-cast
                nummerna = (List<int>)Session["vilkaNummer"];
            }
            else
            {
                myCookie = Request.Cookies.Get("CookieNummber");
                if (myCookie != null)
                {
                    string[] stringNumbers = myCookie.Value.Split('q');// man kan skriva var istället för string men det är tydligare med string
                    foreach (var item in stringNumbers)
                    {
                        nummerna.Add(int.Parse(item));
                    }
                }
            }
            nummerna.Add(multi);// lägga till nya nummer
            Session["vilkaNummer"] = nummerna;// spara listan med nummer

            myCookie = new HttpCookie("CookieNumbers");
            myCookie.Expires = DateTime.Now.AddHours(1);

            foreach (int item in nummerna)
            {
                myCookie.Value += item.ToString() + 'q';
            }

            myCookie.Value = myCookie.Value.Remove(myCookie.Value.Length - 1, 1);

            Response.Cookies.Add(myCookie);

            ViewBag.multi = multi;

            return View();
        }

        public ActionResult Main()
        {
            List<Car> dbCars = new List<Car>()
            {
                new Car() { Brand= "saab", Model="900", MaxSpeed=240},
                new Car() { Brand= "volvo", Model="240", MaxSpeed=200},
                new Car() { Brand= "Volvo", Model="v60", MaxSpeed=400},
                new Car() { Brand= "saab", Model="900", MaxSpeed=240},
                new Car() { Brand= "saab", Model="900", MaxSpeed=240}
            };

            List<Computer> dbPCs = new List<Computer>()
        {
            new Computer(){ Id= 1, Name= "Lenovo", CUP= "i7 6700HQ", Ram=8, Info="Powerfull Laptop" },
            new Computer(){ Id= 2, Name= "Dell", CUP= "i5 6600U", Ram=8, Info="Media Laptop" },
            new Computer(){ Id= 3, Name= "HP", CUP= "i7 7700k", Ram=16, Info="Powerfull Laptop" }

        };

            CarPCviewModel vw = new CarPCviewModel();
            vw.Cars = dbCars;
            vw.Computer = dbPCs;

            return View(vw);
        }

    }
}