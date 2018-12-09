using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;

namespace EventFinder.Models
{
    [Bind(Exclude="EventFinderEventID")]
    public class EventFinderEvent : IValidatableObject
    {
        [DisplayName("EventID")]
        public virtual int EventFinderEventID { get; set; }
        public virtual int EventFinderEventTypeID { get; set; }

        [Required(ErrorMessage="Title of event is required")]
        [StringLength(50, ErrorMessage = "Event title must be 50 characters or less.")]
        public string Title { get; set; }

        [StringLength(150, ErrorMessage = "Event description must be 50 characters or less.")]
        public string Description { get; set; }

        [DisplayName("Event Type")]
        public virtual EventFinderEventType EventType { get; set; }

        [Required(ErrorMessage = "Start Date is required")]
        [DisplayName("Event Start Date")]
        public DateTime StartDate { get; set; }


        [Required(ErrorMessage = "End Date is required")]
        [DisplayName("Event End Date")]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "Start time required")]
        public DateTime StartTime { get; set; }

        [Required(ErrorMessage ="End time required")]
        public DateTime EndTime { get; set; }

        [Required(ErrorMessage="Maximum amount of tickets for event is required")]
        [MinTickets(0)]
        public int MaxTickets { get; set; }

        [Required(ErrorMessage ="Available tickets is required.")]
        [MinTickets(0)]
        public int AvailableTickets { get; set; }

        [Required(ErrorMessage="State is required")]
        [MaxLength(2, ErrorMessage ="Enter 2-character state abbreviation (eg. Ohio = OH")]
        public string State { get; set; }

        [Required(ErrorMessage = "City is required")]
        [MaxLength(35, ErrorMessage ="City name must be shorter than 36 characters")]
        public string City { get; set; }

        public int ZipCode { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [StringLength(50, ErrorMessage ="First Name must be 50 characters or less.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(50, ErrorMessage = "Last Name must be 50 characters or less.")]
        public string LastName { get; set; }

        [Required]
        [DisplayName("Contact")]
        public string OrganizerEmail { get; set; }


        public String ConvertToStringDate(DateTime startDate)
        {
            return "";
        }

        //Self-validating object 
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            DateTime currentDate = DateTime.Today;
            DateTime startDate = StartDate.Date;
            DateTime endDate = EndDate.Date;

            if (StartDate < currentDate || EndDate < currentDate)
            {
                yield return (new ValidationResult("Date cannot be in the past ", new[] { "StartDate", "EndDate" }));
            }

            if(EndDate < StartDate)
            {
                yield return (new ValidationResult("Start date cannot begin after end date", new[] { "StartDate", "EndDate"}));
            }

            if(StartDate == EndDate)
            {
                yield return (new ValidationResult("Start date and End date cannot be the same", new[] { "StartDate", "EndDate" }));
            }
        }
    }
}