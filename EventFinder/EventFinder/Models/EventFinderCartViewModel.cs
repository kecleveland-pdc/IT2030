using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventFinder.Models
{
    public class EventFinderCartViewModel
    {
        public List<EventFinderEventOrder> CartItems;
        public decimal CartTotal;
    }
}