﻿using System;
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
    public class EventController : Controller
    {
        private CleventDB db = new CleventDB();

        // GET: Event
        public ActionResult Index()
        {
            var events = db.Events.Include(e => e.Organizer).Include(e => e.TypeOfEventID);
            return View(events.ToList());
        }

        // GET: Event/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Event @event = db.Events.Find(id);
            if (@event == null)
            {
                return HttpNotFound();
            }
            return View(@event);
        }

        // GET: Event/Create
        public ActionResult Create()
        {
            ViewBag.OrganizerID = new SelectList(db.Organizers, "OrganizerID", "FirstName");
            ViewBag.EventTypeID = new SelectList(db.EventTypes, "TypeOfEventID", "TypeOfEvent");
            return View();
        }

        // POST: Event/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EventID,TypeOfEventID,OrganizerID,Title,StartDate,EndDate,MaxTickets,AvailableTickets,ZipCode")] Event @event)
        {
            if (ModelState.IsValid)
            {
                db.Events.Add(@event);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.OrganizerID = new SelectList(db.Organizers, "OrganizerID", "FirstName", @event.OrganizerID);
            ViewBag.EventTypeID = new SelectList(db.EventTypes, "TypeOfEventID", "TypeOfEvent", @event.TypeOfEventID);
            return View(@event);
        }

        // GET: Event/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Event @event = db.Events.Find(id);
            if (@event == null)
            {
                return HttpNotFound();
            }
            ViewBag.OrganizerID = new SelectList(db.Organizers, "OrganizerID", "FirstName", @event.OrganizerID);
            ViewBag.EventTypeID = new SelectList(db.EventTypes, "TypeOfEventID", "TypeOfEvent", @event.TypeOfEventID);
            return View(@event);
        }

        // POST: Event/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EventID,TypeOfEventID,OrganizerID,Title,StartDate,EndDate,MaxTickets,AvailableTickets,ZipCode")] Event @event)
        {
            if (ModelState.IsValid)
            {
                db.Entry(@event).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.OrganizerID = new SelectList(db.Organizers, "OrganizerID", "FirstName", @event.OrganizerID);
            ViewBag.EventTypeID = new SelectList(db.EventTypes, "TypeOfEventID", "TypeOfEvent", @event.TypeOfEventID);
            return View(@event);
        }

        // GET: Event/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Event @event = db.Events.Find(id);
            if (@event == null)
            {
                return HttpNotFound();
            }
            return View(@event);
        }

        // POST: Event/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Event @event = db.Events.Find(id);
            db.Events.Remove(@event);
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
