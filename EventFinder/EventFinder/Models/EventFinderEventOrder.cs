using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;

namespace EventFinder.Models
{
    public class EventFinderEventOrder
    {
        public int EventFinderOrderID { get; set; }
        public virtual EventFinderEvent EventSelected { get; set; }
        public int Count { get; set; }
        public DateTime DateCreated { get; set; }
        public EventFinderEvent EventItem { get; set; }
        public Guid OrderNumber { get; set; }
    }
}