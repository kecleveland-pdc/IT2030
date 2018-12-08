using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Clevent.Models
{
    public class Organizer
    {
        public int OrganizerID { get; set; }

        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Last Name must be 50 characters or less.")]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Required]
        [InvalidChars(" ", ErrorMessage = "Email cannot contain spaces")]
        [DisplayName("Email")]
        public string EmailAddress { get; set; }
    }
}