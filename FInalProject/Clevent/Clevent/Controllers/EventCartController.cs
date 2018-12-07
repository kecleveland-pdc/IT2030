using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Clevent.Models;

namespace Clevent.Controllers
{
    public class EventCartController : Controller
    {
        private CleventDB db = new CleventDB();

        // GET: EventCart
        public ActionResult Index()
        {
            return View(db.EventCarts.ToList());
        }

        // GET: EventCart/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EventCart eventCart = db.EventCarts.Find(id);
            if (eventCart == null)
            {
                return HttpNotFound();
            }
            return View(eventCart);
        }

        // GET: EventCart/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EventCart/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EventCartID,Count,DateCreated,OrderNumber")] EventCart eventCart)
        {
            if (ModelState.IsValid)
            {
                db.EventCarts.Add(eventCart);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(eventCart);
        }

        // GET: EventCart/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EventCart eventCart = db.EventCarts.Find(id);
            if (eventCart == null)
            {
                return HttpNotFound();
            }
            return View(eventCart);
        }

        // POST: EventCart/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EventCartID,Count,DateCreated,OrderNumber")] EventCart eventCart)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eventCart).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(eventCart);
        }

        // GET: EventCart/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EventCart eventCart = db.EventCarts.Find(id);
            if (eventCart == null)
            {
                return HttpNotFound();
            }
            return View(eventCart);
        }

        // POST: EventCart/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EventCart eventCart = db.EventCarts.Find(id);
            db.EventCarts.Remove(eventCart);
            db.SaveChanges();
            return RedirectToAction("Index");
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
