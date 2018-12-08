using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace EventFinder.Models
{
    public class EventFinderEventType
    {
        [DisplayName("EventTypeID")]
        public int EventFinderEventTypeID { get; set; }
        public string EventType { get; set; }       
    }
}