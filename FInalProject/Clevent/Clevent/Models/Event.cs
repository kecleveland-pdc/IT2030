using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Clevent.Models
{
    public class Event
    {
        public int EventID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int MaxTickets { get; set; }
        public int AvailableTickets { get; set; }

        [Required]
        public int ZipCode { get; set; }
    }
}