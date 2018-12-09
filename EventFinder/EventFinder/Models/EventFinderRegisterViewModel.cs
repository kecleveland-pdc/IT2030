using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventFinder.Models.ViewModels
{
    public class EventFinderRegisterViewModel
    {
        public virtual EventFinderEvent eventFinderEvent {get; set;}
        public virtual EventFinderCart eventFinderCart { get; set; }
        public int NumberOfTickets { get; set; }
    }
}