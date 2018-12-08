using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clevent.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public Guid OrderNumber { get; set; }
    }
}