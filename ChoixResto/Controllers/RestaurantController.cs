using ChoixResto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace ChoixResto.Controllers
{
    public class RestaurantController : Controller
    {
        private IDal dal;

        public RestaurantController() : this(new Dal())
        {
        }

        public RestaurantController(IDal dalIoc)
        {
            dal = dalIoc;
        }

        public ActionResult Index()
        {
            List<Resto> listeDesRestaurants = dal.ObtientTousLesRestaurants();
            return View(listeDesRestaurants);
        }

        public ActionResult CreerRestaurant()
        {
            return View();
        }

        [HttpPost]
        /*
        [Authorize(Roles="Administrateur")]
        https://openclassrooms.com/en/courses/1730206-apprenez-asp-net-mvc/2098931-gerer-l-authentification
        système de rôle ~ mécanisme gestion des rôles ASP.NET ~ changer @Authorize @param input
        */
        public ActionResult CreerRestaurant(Resto resto)
        {
            if (dal.RestaurantExiste(resto.Nom))
            {
                ModelState.AddModelError("Nom", "Ce nom de restaurant existe déjà");
                return View(resto);
            }
            if (!ModelState.IsValid)
                return View(resto);
            dal.CreerRestaurant(resto.Nom, resto.Telephone);
            return RedirectToAction("Index");
        }

        public ActionResult ModifierRestaurant(int? id)
        {
            if (id.HasValue)
            {
                Resto restaurant = dal.ObtientTousLesRestaurants().FirstOrDefault(r => r.Id == id.Value);
                if (restaurant == null)
                    return View("Error");
                return View(restaurant);
            }
            else
                return HttpNotFound();
        }

        [HttpPost]
        public ActionResult ModifierRestaurant(Resto resto)
        {
            if (!ModelState.IsValid)
                return View(resto);
            dal.ModifierRestaurant(resto.Id, resto.Nom, resto.Telephone);
            return RedirectToAction("Index");
        }
    }
}