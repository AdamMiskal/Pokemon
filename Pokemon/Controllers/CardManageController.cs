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
    public class CardManageController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: CardManage
        public ActionResult Index(int? cardId, string name, int? serialNumber, int? attack, int? defence, Rarity? rarity)
        {
            var cards = db.Cards.ToList();
            if (!string.IsNullOrEmpty(name))
            {
                cards = cards.Where(a => a.Name.ToUpper().Contains(name.ToUpper())).ToList();
            }
            if (!(serialNumber is null))
            {
                cards = cards.Where(a => a.SerialNumber.Equals(serialNumber)).ToList();
            }
            if (!(attack is null))
            {
                cards = cards.Where(a => a.Attack.Equals(attack)).ToList();
            }
            if (!(defence is null))
            {
                cards = cards.Where(a => a.Defence.Equals(defence)).ToList();
            }
            if (!(rarity is null))
            {
                cards = cards.Where(a => a.Rarity.Equals(rarity)).ToList();
            }
            return View(cards.ToList());
            //return View(db.Cards.ToList());

        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Card cards = db.Cards.Find(id);
            if (cards == null)
            {
                return HttpNotFound();
            }
            return View(cards);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Card cards = db.Cards.Find(id);
            if (cards == null)
            {
                return HttpNotFound();
            }
            return View(cards);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int? id)
        {
            Card cards = db.Cards.Find(id);
            db.Cards.Remove(cards);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Create()
        {
            return View();
        }

        // POST: AppUsers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CardId,Name,Description,SerialNumber,Attack,Defence,Rarity")] Card cards)
        {
            if (ModelState.IsValid)
            {
                db.Cards.Add(cards);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cards);
        }
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Card cards = db.Cards.Find(id);
            if (cards == null)
            {
                return HttpNotFound();
            }
            return View(cards);
        }

        // POST: AppUsers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CardId,Name,SerialNumber,Attack,Defence,Rarity")] Card cards)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cards).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
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