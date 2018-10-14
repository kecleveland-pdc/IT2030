using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace EnrollmentApplication.Models
{
    public class Course
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
        [Range(1, 4, ErrorMessage="Number of credits must be 1-4")]
        public virtual decimal Credits { get; set; }

        public virtual string InstructorName { get; set; }

    }
}