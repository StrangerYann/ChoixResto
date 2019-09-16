using ChoixResto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChoixResto.Controllers
{
    public class VoteController : Controller
    {
        // GET: Vote
        public ActionResult browserCheck()
        {
            var browserID = Request.Browser.Browser;
            ViewData["browserID"] = browserID;
            Dal dal = new Dal();
            var otherInfo = dal.ObtenirUtilisateur(browserID);
            ViewData["infoName"] = otherInfo.Prenom;
            ViewData["infoMDP"] = otherInfo.MotDePasse;

            return View();
        }

        public ActionResult Index(int? id)
        {
            if (id.HasValue)
            {
                Dal dal = new Dal();
                List<Resto> listeDesRestaurants = dal.ObtientTousLesRestaurants();
                return View(listeDesRestaurants);
            }
            else
                return HttpNotFound();
        }

        [HttpPost]
        public ActionResult Index()
        {
            Dal dal = new Dal();

            dal.CreerUnSondage();

            return RedirectToAction("Index");


        }
    }
}