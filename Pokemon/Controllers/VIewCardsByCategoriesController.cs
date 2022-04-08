using Pokemon.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pokemon.Controllers
{
    public class VIewCardsByCategoriesController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult AllCardsByRarity(Rarity rarity)
        {

            var cards = db.Cards.Where(x => x.Rarity == rarity).Include(x => x.Image).Include(x=>x.PokemonTypes).ToList();


            if (cards.Count<=1)
            {
                return RedirectToAction("Index", "Errors", new { message = "there are not excist other with this rarity" });
            }
            return View(cards);
        }
    }
}