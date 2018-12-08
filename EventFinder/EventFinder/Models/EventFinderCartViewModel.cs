using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventFinder.Models
{
    public class EventFinderCartViewModel
    {
        public List<Order> CartItems;
        public decimal CartTotal;
    }
}