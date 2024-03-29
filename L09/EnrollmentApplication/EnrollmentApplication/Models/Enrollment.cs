﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace EnrollmentApplication.Models
{
    public class Enrollment
    {
        [DisplayName("Enrollment ID")]
        public virtual int EnrollmentID { get; set; }

        public virtual int StudentID { get; set; }

        public virtual int  CourseID { get; set; }

        [Required]
        [RegularExpression(@"\b[A-F]\b", ErrorMessage = "Grade must be A, B, C, D, E, F")]
        public virtual string Grade { get; set; }

        public virtual Student Student { get; set; }

        public virtual Course Course { get; set; }

        [DisplayName("Active")]
        public virtual bool IsActive { get; set; }

        [Required(ErrorMessage = "Assigned Campus is required")]
        [DisplayName("Assigned Campus")]
        public virtual string AssignedCampus { get; set; }
     
        [Required(ErrorMessage = "Semester is required")]
        [DisplayName("Enrolled in Semester")]
        public virtual string EnrollmentSemester { get; set; }

        [Required(ErrorMessage = "Enrollment year is required")]
        [DisplayName("Enrollment Year")]
        [MinDate(2018)]
        public virtual int EnrollmentYear { get; set; }

        [InvalidChars("@#$", ErrorMessage="Notes cannot contain @, #, or $")]
        public virtual string Notes { get; set; }
    }

    
}