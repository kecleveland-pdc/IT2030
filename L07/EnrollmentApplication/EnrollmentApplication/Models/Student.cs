using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace EnrollmentApplication.Models
{
    public class Student : IValidatableObject
    {
        [DisplayName("Student ID")]
        public virtual int StudentID { get; set; }

        [Required(ErrorMessage = "First Name field cannot be empty")]
        [DisplayName("First Name")]
        [StringLength(50, ErrorMessage = "First Name must be 50 characters or less")]
        public virtual string FirstName { get; set; }

        [Required(ErrorMessage ="Last Name field cannot be empty")]
        [DisplayName("Last Name")]
        [StringLength(50, ErrorMessage = "Last Name must be 50 characters or less")]
        public virtual string LastName { get; set; }

        [Required(ErrorMessage = "Age cannot be empty")]
        [MinAge(18)]
        public int Age { get; set; }

        [DisplayName("Address 1")]
        public string Address1 { get; set; }

        [DisplayName("Address 2")]
        public string Address2 { get; set; }

        public string City { get; set; }

        [DisplayName("ZipCode")]
        public string Zipcode { get; set; }

        public string State { get; set; }

        //Self-validating object 
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            int zipLength = 5;
            int stateLength = 2;
         
            if (Address1 == Address2)
            {
                yield return (new ValidationResult("Address 1 and Address 2 cannot be the same ", new[] { "Address1", "Address2" }));
            }

            if(State.Length != stateLength)
            {
                yield return (new ValidationResult("State must be 2 characters", new[] { "State" }));
            }

            if (Zipcode.Length != zipLength)
            {
                yield return (new ValidationResult("Zipcode must be 5 digits", new[] { "Zipcode"}));
            }

        }
    }
}