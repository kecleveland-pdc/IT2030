using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EventFinder.Models;
using System.Data.Entity;
using System.Web.Mvc;
using System.Net;
using System.Data;

namespace EventFinder.Models.ViewModels
{
    public class SelectedEventViewModel
    {
        private EventFinderDB db = new EventFinderDB();
        public string SelectedEventID { get; set; }
        public string SelectedEvent
        {
            get
            {
                return "Something";
            }
        }
        public IEnumerable<SelectListItem> AllEvents { get ; set; }

        private IEnumerable<SelectListItem> EventsList()
        {
            var AllEvents = new SelectList( db.EventFinderEvents.Include(e => e.EventType));
            return AllEvents;
        }
    }
}