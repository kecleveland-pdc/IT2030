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
    }
}