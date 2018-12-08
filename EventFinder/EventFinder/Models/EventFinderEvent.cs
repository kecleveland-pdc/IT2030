using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;

namespace EventFinder.Models
{

    public class EventFinderEvent
    {
        [DisplayName("EventID")]
        public virtual int EventFinderEventID { get; set; }
        public virtual int EventFinderEventTypeID { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Event title must be 50 characters or less.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Start Date is required")]
        [DisplayName("Event Start Date")]
        public virtual EventFinderEventType EventType { get; set; }


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

        [Required]
        [DisplayName("Contact")]
        public string OrganizerEmail { get; set; }


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