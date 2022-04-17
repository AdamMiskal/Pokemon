using Microsoft.Ajax.Utilities;
using Pokemon.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Pokemon.Controllers
{
    public class CardDatabaseController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext() ;
        // GET: CardDatabase
        public ActionResult Index()
        {
            // .Include(x => x.PokemonTypes)
            var cards = db.Cards.Where(x => x.SerialNumber == 1).Include(x => x.Image).Include(x => x.PokemonTypes).DistinctBy(x=>x.Name).OrderBy(x=>x.pkdxNum).ToList();

             

            return View(cards);
        }


        public ActionResult CardDetails(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            //Card card = db.Cards.Find(id);
            Card card = db.Cards.Where(x => x.CardId == id).Include(x => x.Image).Include(x => x.PokemonTypes).SingleOrDefault();

            if (card == null)
            {
                return HttpNotFound();
            }

            

            return View(card);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}