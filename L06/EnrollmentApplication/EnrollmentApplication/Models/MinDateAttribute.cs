using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentApplication.Models
{
    
    public class MinDateAttribute : ValidationAttribute
    {
        private readonly int _year;

        public MinDateAttribute(int year) : base("{0} must be at least 2018")
        {
            _year = year;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                var valueAsInt = Convert.ToInt32(value);
                if (valueAsInt < _year)
                {
                    var errorMessage = FormatErrorMessage(validationContext.DisplayName);
                    return new ValidationResult(errorMessage);
                }
            }
            return ValidationResult.Success;
        }



    }
}