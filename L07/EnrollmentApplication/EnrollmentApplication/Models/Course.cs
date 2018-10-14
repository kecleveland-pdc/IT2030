using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace EnrollmentApplication.Models
{
    public class Course : IValidatableObject
    {
        [DisplayName("Course ID")]
        public virtual int CourseID { get; set; }

        [Required]
        [DisplayName("Course Title")]
        [StringLength(150, ErrorMessage="Course Title must be 150 characters or less")]
        public virtual string Title{ get; set; }

        [DisplayName("Description")]
        public virtual string Description { get; set; }

        [Required]
        [DisplayName("Number of Credits")]
        [Range(1, 4)]
        public virtual string Credits { get; set; }

        public virtual string InstructorName { get; set; }

        //Self-validating object 
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            int maxCredits = 4;
            int maxWords = 5;

            if(int.Parse(Credits) > maxCredits)
            {
                //returning a collection of elements
                yield return (new ValidationResult("Credits must be between 1 and 4", new[] { "Credits" }));
            }

            if(Description.Split(' ').Length > maxWords)
            {
                yield return (new ValidationResult("Description must be 5 words or less", new[] { "Description" }));

            }

        }
    }
}