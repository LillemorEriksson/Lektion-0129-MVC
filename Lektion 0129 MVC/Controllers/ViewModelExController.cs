using Lektion_0129_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lektion_0129_MVC.Controllers
{
    public class ViewModelExController : Controller
    {
        static List<Car> dbCars = new List<Car>()
            {
                new Car() { Brand= "saab", Model="900", MaxSpeed=240},
                new Car() { Brand= "volvo", Model="240", MaxSpeed=200},
                new Car() { Brand= "Volvo", Model="v60", MaxSpeed=400},
                new Car() { Brand= "saab", Model="900", MaxSpeed=240},
                new Car() { Brand= "saab", Model="900", MaxSpeed=240}
            };

        static List<Computer> dbPCs = new List<Computer>()
        {
            new Computer(){ Id= 1, Name= "Lenovo", CUP= "i7 6700HQ", Ram=8, Info="Powerfull Laptop" },
            new Computer(){ Id= 2, Name= "Dell", CUP= "i5 6600U", Ram=8, Info="Media Laptop" },
            new Computer(){ Id= 3, Name= "HP", CUP= "i7 7700k", Ram=16, Info="Powerfull Laptop" }

        };

        // GET: ViewModelEx
        public ActionResult Index()
        {
            CarPCviewModel vw = new CarPCviewModel();
            vw.Cars = dbCars;
            vw.Computer = dbPCs;

            return View(vw);
        }

        public ActionResult AjaxCars()
        {
            return PartialView(dbCars);
        }
    }
}