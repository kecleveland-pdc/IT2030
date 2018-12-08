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
        [DisplayName("Event ID")]
        public virtual int EventID { get; set; }

        public virtual int OrganizerID { get; set; }

        public virtual int TypeOfEventID {get; set;}

        [Required]
        public virtual Organizer Organizer { get; set; }

        [Required]
        public virtual EventType TypeOfEvent { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Event title must be 50 characters or less.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Start Date is required")]
        [DisplayName("Event Start Date")]
        public DateTime StartDate { get; set; }


        [Required(ErrorMessage = "End Date is required")]
        [DisplayName("Event End Date")]
        public DateTime EndDate { get; set; }

        [Required]
        [MinTickets(0)]
        public int MaxTickets { get; set; }

        [Required]
        [MinTickets(0)]
        public int AvailableTickets { get; set; }

        [Required]
        [DisplayName("Zip-Code")]
        public int ZipCode { get; set; }


        //Self-validating object 
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            DateTime currentDate = DateTime.Today;
            DateTime startDate = StartDate.Date;
            DateTime endDate = EndDate.Date;

            if (StartDate < currentDate || EndDate < currentDate)
            {
                yield return (new ValidationResult("Date cannot be in the past ", new[] { "Start date" }));
            }

        }
    }
}