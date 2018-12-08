using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clevent.Models
{
    public class Organizer
    {
        public int OrganizerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
    }
}