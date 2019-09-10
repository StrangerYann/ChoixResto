using ChoixResto.Models;
using ChoixResto.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChoixResto.Controllers
{
    public class AccueilController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        /*public ActionResult Index(int selektor)
        {
            if (selektor == 0)
                return new RestaurantController().Index();
            if (selektor == 1)
                return new RestaurantController().CreerRestaurant();
            else
                return View("Error");
        }*/
    }
}