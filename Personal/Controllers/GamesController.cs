using Personal.Models.UniversalModels;
using Personal.Tests.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Personal.Controllers
{
    public class GamesController : Controller
    {
        readonly TestModels tests = new TestModels();
        // GET: Games
        public ActionResult Index()
        {
#if DEBUG
            var tables = tests.GetTablesTest();
#else

#endif
            return View(tables);
        }

        [HttpGet]
        public ActionResult Table(TableModel table)
        {
            if (ModelState.IsValid)
            {
                return View(table);
            }

            return View();
        }

        public ActionResult Card()
        {
            List<CardModel> Cards = new List<CardModel>
            {
                new CardModel(Suits.Heart, Values.Ace),
                new CardModel(Suits.Spade, Values.Seven)
            };
            
            return View(Cards);
        }

        public ActionResult Player()
        {
            return View();
        }

        public ActionResult WaterstoneHero()
        {
            return View();
        }
    }
}