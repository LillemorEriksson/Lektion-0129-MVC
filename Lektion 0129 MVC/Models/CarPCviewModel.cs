using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lektion_0129_MVC.Models
{
    public class CarPCviewModel
    {
        public List<Car> Cars { get; set; }
        public List<Computer> Computer { get; set; }

        public string SearchCar { get; set; }
        public string SearchPC { get; set; }

        public CarPCviewModel()
        {
            SearchCar = "";
            SearchPC = "";
        } 
    }
}