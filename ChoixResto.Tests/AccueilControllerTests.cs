using System;
using System.Collections.Generic;
using System.Web.Mvc;
using ChoixResto.Controllers;
using ChoixResto.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChoixResto.Tests
{
    [TestClass]
    public class AccueilControllerTests
    {
        [TestMethod]
        public void AccueilController_IndexPost_RenvoiActionVote()
        {
            using (IDal dal = new DalEnDur())
            {
                AccueilController controller = new AccueilController(dal);

                RedirectToRouteResult resultat = (RedirectToRouteResult)controller.IndexPost();

                Assert.AreEqual("Index", resultat.RouteValues["action"]);
                Assert.AreEqual("Vote", resultat.RouteValues["controller"]);
                List<Resultats> resultats = dal.ObtenirLesResultats(1);
                Assert.IsNotNull(resultats);
            }
        }
    }
}