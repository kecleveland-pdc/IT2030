﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnrollmentApplication.Models
{
    public class Course
    {
        public virtual int CourseID { get; set; }
        public virtual string Title{ get; set; }
        public virtual string Description { get; set; }
        public virtual decimal Credits { get; set; }

    }
}