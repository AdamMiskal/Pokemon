using Pokemon.Models;
using Pokemon.Models.HelperModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Pokemon.Controllers.API
{
    public class CardStatisticsController : ApiController
    {
        ApplicationDbContext db;

        public CardStatisticsController()
        {
            db = new ApplicationDbContext();
        }

        public List<CardStatsApiModel> GetCardDetails(string name)
        {
            var totalCards = db.Cards.Where(c => c.Name == name).Count();
            var CardsForSale = db.Cards.Where(c => c.Name == name).Where(c=>c.Market==true).Count();
            var CardsHidden = db.Cards.Where(c => c.Name == name).Where(c=>c.ApplicationUserId==null).Count();
            var CardsNotForSale = totalCards - CardsForSale - CardsHidden;
            CardStatsApiModel Forsale = new CardStatsApiModel() { label = "For Sale", y = CardsForSale };
            CardStatsApiModel Hidden = new CardStatsApiModel() { label = "Hidden in Packs", y = CardsHidden };
            CardStatsApiModel NotForSale = new CardStatsApiModel() { label = "Not gor Sale", y = CardsNotForSale };
            List<CardStatsApiModel> test = new List<CardStatsApiModel>() { Forsale, Hidden, NotForSale };

            return test;
        }
    }
}
