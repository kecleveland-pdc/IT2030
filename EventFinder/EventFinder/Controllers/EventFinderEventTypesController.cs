using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EventFinder.Models;

namespace EventFinder.Controllers
{
    public class EventFinderEventTypesController : Controller
    {
        private EventFinderDB db = new EventFinderDB();

        // GET: EventFinderEventTypes
        public ActionResult Index()
        {
            return View(db.EventFinderEventTypes.ToList());
        }

        // GET: EventFinderEventTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EventFinderEventType eventFinderEventType = db.EventFinderEventTypes.Find(id);
            if (eventFinderEventType == null)
            {
                return HttpNotFound();
            }
            return View(eventFinderEventType);
        }

        // GET: EventFinderEventTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EventFinderEventTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EventFinderEventTypeID,EventType")] EventFinderEventType eventFinderEventType)
        {
            if (ModelState.IsValid)
            {
                db.EventFinderEventTypes.Add(eventFinderEventType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(eventFinderEventType);
        }

        // GET: EventFinderEventTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EventFinderEventType eventFinderEventType = db.EventFinderEventTypes.Find(id);
            if (eventFinderEventType == null)
            {
                return HttpNotFound();
            }
            return View(eventFinderEventType);
        }

        // POST: EventFinderEventTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EventFinderEventTypeID,EventType")] EventFinderEventType eventFinderEventType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eventFinderEventType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(eventFinderEventType);
        }

        // GET: EventFinderEventTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EventFinderEventType eventFinderEventType = db.EventFinderEventTypes.Find(id);
            if (eventFinderEventType == null)
            {
                return HttpNotFound();
            }
            return View(eventFinderEventType);
        }

        // POST: EventFinderEventTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EventFinderEventType eventFinderEventType = db.EventFinderEventTypes.Find(id);
            db.EventFinderEventTypes.Remove(eventFinderEventType);
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
