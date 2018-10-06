using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace EnrollmentApplication.Models
{
    public class Student
    {
        [DisplayName("Student ID")]
        public virtual int StudentID { get; set; }

        [Required]
        [DisplayName("First Name")]
        [StringLength(50, ErrorMessage = "First Name must be 50 characters or less")]
        public virtual string FirstName { get; set; }

        [Required]
        [DisplayName("Last Name")]
        [StringLength(50, ErrorMessage = "Last Name must be 50 characters or less")]
        public virtual string LastName { get; set; }
    }
}