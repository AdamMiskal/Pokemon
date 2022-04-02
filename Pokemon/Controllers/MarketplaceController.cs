using Pokemon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Pokemon.Models.HelperModels;
using Microsoft.AspNet.Identity;

namespace Pokemon.Controllers
{
    public class MarketplaceController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Marketplace
        public ActionResult Index()
        {
            var market = db.Cards.Where(x => x.Market == true).Include(x=>x.PokemonTypes).Include(x=>x.User).ToList();
            return View(market);
        }


        //Card userId seller-->buyer
        //Value--> afere8ei apo to banalnce tou buyer
        //value--> proste8ei sto seller

       public ActionResult BuyCard(int? id)
       {



            if (id==null)
            {

                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);

            }

            Card card = db.Cards.Find(id);

            if (card==null)
            {
                return HttpNotFound();

            }
            card.ApplicationUserId = User.Identity.GetUserId();

            card.Market = false;

            //var card = db.Cards.Find(model.Value);

            //card.ApplicationUserId = model.BuyerId;




            //if (user.Balance < model.PackValue)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);//tha to allaksoume me ena view diko mas
            //}

            //var cards = db.Cards.Where(c => c.ApplicationUserId == null).ToList();
            //var newPack = CreatePack.NewPack(model.PackValue, cards, model.UserId);
            db.SaveChanges();
           
            return RedirectToAction("Index","Mycollection");
          

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