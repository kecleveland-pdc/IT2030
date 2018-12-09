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

        [DisplayName("Event Type")]
        [Required]
        [StringLength(50, ErrorMessage = "Event type must be 50 characters or less.")]
        public string EventType { get; set; }       
    }
}