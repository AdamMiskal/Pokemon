using Pokemon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Net;
using System.Data.SqlClient;

namespace Pokemon.Controllers
{
    public class MyCollectionController : Controller
    {
         ApplicationDbContext db = new ApplicationDbContext();

        // GET: MyCollection
        public ActionResult Index()
        {
            //var keepo = db.Users.Join(db.Cards, u => u.Id, c => c.ApplicationUserId, (u, c) => new { u, c }).ToList();

            // var kfd = db.Users.ToList().Find(u => u.UserName == "admin@gmail.com").Cards;
            var keepo = db.Users.Include(x=>x.Cards).ToList();
            

            return View(keepo);
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



//var keepo = db.Users.Join(db.Cards, u => u.Id, c => c.ApplicationUserId, (u, c) => new { u, c }).ToList();
//
//
//
//UserCard uc = new UserCard()
//{
//    cards = keepo.Select(x => x.c).ToList(),
//    users = keepo.Select(x => x.u).ToList()
//
//
//};
//var keepo = db.Users.Select(x => x.Cards).ToList();
//var keepo = db.Cards.Include(x => x.User).ToList();

// IList<string> studentList = new List<string>();
// studentList.Add( "Bill" );
// studentList.Add("Steve" );
// studentList.Add("Ram" );
//
// ViewData["students"] = studentList;

//UserCard kee = new UserCard();
//
//
//var c1 = new Card() { Name = "keeo" };
//var c2 = new Card() { Name = "kereo" };
//var c3 = new Card() { Name = "keerfo" };
//var gregor = new List<Card>();
//gregor.Add(c1);
//gregor.Add(c2);
//gregor.Add(c3);
//
//var annamaria = new ApplicationUser() {Email="keepo@gmail.com" };
////annamaria.Cards = gregor;
//kee.cards = gregor;
//ViewData["gregorMaria"] = kee;


//static private string GetConnectionString()
//{
//    // To avoid storing the connection string in your code,
//    // you can retrieve it from a configuration file.
//    return "Data Source=.;Initial Catalog=PokemonDatabase;Integrated Security=True;";
//
//    string commandtext = "SELECT bla FROM items WHERE main = 1";
//}
//
//private static void CreateCommand(string queryString, string connectionString)
//{
//    using (SqlConnection connection = new SqlConnection(
//               connectionString))
//    {
//        SqlCommand command = new SqlCommand(queryString, connection);
//        command.Connection.Open();
//        command.ExecuteNonQuery();
//    }
//}