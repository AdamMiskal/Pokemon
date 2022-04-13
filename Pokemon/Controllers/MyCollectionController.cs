using Pokemon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Net;
using System.Data.SqlClient;
using Microsoft.AspNet.Identity;

namespace Pokemon.Controllers
{
    public class MyCollectionController : Controller
    {
         ApplicationDbContext db = new ApplicationDbContext();

        // GET: MyCollection
        public ActionResult Index()
        {
          
           var keepo = db.Users.Find(User.Identity.GetUserId());
           var cards = db.Cards.Where(x => x.ApplicationUserId == keepo.Id).Include(x=>x.Image).Include(x=>x.PokemonTypes).ToList();
            
            return View(cards);
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



