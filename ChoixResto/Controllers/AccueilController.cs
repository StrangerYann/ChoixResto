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
        
        [HttpPost]
        public ActionResult Index(int Test)
        {
            Dal dal = new Dal();
            int newIndex=dal.CreerUnSondage();
            return new VoteController().Index(newIndex);
        }
    }
}