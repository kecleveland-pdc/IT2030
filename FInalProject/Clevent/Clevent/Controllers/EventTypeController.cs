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
    public class EventTypeController : Controller
    {
        private CleventDB db = new CleventDB();

        // GET: EventType
        public ActionResult Index()
        {
            return View(db.EventTypes.ToList());
        }

        // GET: EventType/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EventType eventType = db.EventTypes.Find(id);
            if (eventType == null)
            {
                return HttpNotFound();
            }
            return View(eventType);
        }

        // GET: EventType/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EventType/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TypeOfEventID,EventName")] EventType eventType)
        {
            if (ModelState.IsValid)
            {
                db.EventTypes.Add(eventType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(eventType);
        }

        // GET: EventType/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EventType eventType = db.EventTypes.Find(id);
            if (eventType == null)
            {
                return HttpNotFound();
            }
            return View(eventType);
        }

        // POST: EventType/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EventTypeID,EventName")] EventType eventType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eventType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(eventType);
        }

        // GET: EventType/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EventType eventType = db.EventTypes.Find(id);
            if (eventType == null)
            {
                return HttpNotFound();
            }
            return View(eventType);
        }

        // POST: EventType/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EventType eventType = db.EventTypes.Find(id);
            db.EventTypes.Remove(eventType);
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
