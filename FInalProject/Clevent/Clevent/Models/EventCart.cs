using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clevent.Models
{
    public class EventCart
    {
        public int EventCartID { get; set; }
        public int Count { get; set; }
        public int DateCreated { get; set; }
        public Event EventItem { get; set; }
        public Guid OrderNumber { get; set; }
        public Event EventID { get; set; }
    }
}