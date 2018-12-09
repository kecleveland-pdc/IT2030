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
    public class EventFinderManagerController : Controller
    {
        private EventFinderDB db = new EventFinderDB();

        // GET: EventFinderManager
        public ActionResult Index()
        {
            var eventFinderEvents = db.EventFinderEvents.Include(e => e.EventType);
            return View("Index");
        }

        public ActionResult SearchByEventTypeEventLocation(string eventType)
        {
            var events = GetEventsByEventLocationEventType(eventType);
            return PartialView("_SearchByQueries", events);
        }

        private List<EventFinderEvent> GetEventsByEventLocationEventType(string eventType)
        {
            return db.EventFinderEvents.Where(e => e.EventType.EventType.Contains(eventType)
                                             ).ToList();
        }

        public ActionResult LastMinuteDeals()
        {
            var lastMinuteDeals = GetLastMinuteDeals();
            return PartialView("_LastMinuteDeals", lastMinuteDeals);
        }

        private List<EventFinderEvent> GetLastMinuteDeals()
        {
            var currentDate = DateTime.Now;
            var futureDate = DateTime.Now.AddDays(50);
            //StartDate is later than Now
            //StartDate is before date in future
            var lastMinuteDeals = db.EventFinderEvents.Where(a => (DateTime.Compare(a.StartDate, currentDate) >= 0)
                                         && (DateTime.Compare(a.StartDate, futureDate) <= 0)).ToList();
            return lastMinuteDeals;
        }

        // GET: EventFinderManager/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EventFinderEvent eventFinderEvent = db.EventFinderEvents.Find(id);
            if (eventFinderEvent == null)
            {
                return HttpNotFound();
            }
            return View("Index");
        }

        // GET: EventFinderManager/Create
        public ActionResult Create()
        {
            ViewBag.EventFinderEventTypeID = new SelectList(db.EventFinderEventTypes, "EventFinderEventTypeID", "EventType");
            return View();
        }

        // POST: EventFinderManager/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EventFinderEventID,EventFinderEventTypeID,Title,StartDate,EndDate,MaxTickets,AvailableTickets,ZipCode,OrganizerEmail")] EventFinderEvent eventFinderEvent)
        {
            if (ModelState.IsValid)
            {
                db.EventFinderEvents.Add(eventFinderEvent);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EventFinderEventTypeID = new SelectList(db.EventFinderEventTypes, "EventFinderEventTypeID", "EventType", eventFinderEvent.EventFinderEventTypeID);
            return View(eventFinderEvent);
        }

        // GET: EventFinderManager/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EventFinderEvent eventFinderEvent = db.EventFinderEvents.Find(id);
            if (eventFinderEvent == null)
            {
                return HttpNotFound();
            }
            ViewBag.EventFinderEventTypeID = new SelectList(db.EventFinderEventTypes, "EventFinderEventTypeID", "EventType", eventFinderEvent.EventFinderEventTypeID);
            return View(eventFinderEvent);
        }

        // POST: EventFinderManager/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EventFinderEventID,EventFinderEventTypeID,Title,StartDate,EndDate,MaxTickets,AvailableTickets,ZipCode,OrganizerEmail")] EventFinderEvent eventFinderEvent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eventFinderEvent).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EventFinderEventTypeID = new SelectList(db.EventFinderEventTypes, "EventFinderEventTypeID", "EventType", eventFinderEvent.EventFinderEventTypeID);
            return View(eventFinderEvent);
        }

        // GET: EventFinderManager/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EventFinderEvent eventFinderEvent = db.EventFinderEvents.Find(id);
            if (eventFinderEvent == null)
            {
                return HttpNotFound();
            }
            return View(eventFinderEvent);
        }

        // POST: EventFinderManager/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EventFinderEvent eventFinderEvent = db.EventFinderEvents.Find(id);
            db.EventFinderEvents.Remove(eventFinderEvent);
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
