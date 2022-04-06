using Pokemon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Pokemon.Models.HelperModels;
using Microsoft.AspNet.Identity;
using Pokemon.Repository;

namespace Pokemon.Controllers
{
    public class MarketplaceController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Marketplace


        public ActionResult Index()
        {
            //var market = db.Cards.Where(x => x.Market == true).Include(x=>x.PokemonTypes).Include(x=>x.User).ToList();
            var market = db.Cards.Include(x => x.PokemonTypes).Include(x => x.User).ToList();
            return View(market);
        }



        //Card userId seller-->buyer
        //Value--> afere8ei apo to banalnce tou buyer
        //value--> proste8ei sto seller

        public ActionResult BuyCard(int? id, int price)
        {
            Card card = db.Cards.Find(id);

            var buyer = db.Users.Find(User.Identity.GetUserId());
            var owner = db.Users.Find(card.ApplicationUserId);
            var searchAdmin = db.Users.FirstOrDefault(x => x.Email == "admin@gmail.com");
            var resultId = searchAdmin.Id;
            var admin = db.Users.Find(resultId);
            






            if (id == null)
            {

                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);

            }



            
            if (card == null)
            {
                return HttpNotFound();

            }
            if (buyer.Balance >= price)
            {
                BuyCardTranferMoney.TranferMoney(owner, buyer, admin, price);
            }
            else
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);

            }


            card.ApplicationUserId = User.Identity.GetUserId();

            card.Market = false;

            db.SaveChanges();

            return RedirectToAction("Index", "Mycollection");


        }


        public ActionResult Listcard(int? CardId, int? Price)
        {
            Card card = db.Cards.Find(CardId);


            card.Price = Price;
            card.Market = true;

            db.SaveChanges();
            return RedirectToAction("Index", "Mycollection");
        }

        public ActionResult CancelList(int? CardId)
        {
            var card = db.Cards.Find(CardId);

            if (card.Price == null)
            {

            }
            else
            {
                card.Price = null;
            }


            card.Market = false;
            db.SaveChanges();
            return RedirectToAction("Index", "Mycollection");
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