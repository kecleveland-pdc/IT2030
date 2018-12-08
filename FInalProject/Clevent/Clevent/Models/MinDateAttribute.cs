using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Clevent.Models
{

    public class MinDateAttribute : ValidationAttribute
    {
        //private readonly DateTime _date;

        //public MinDateAttribute(DateTime date) : base("{0} cannot be in the past.")
        //{
        //    _date = date;
        //}

        //protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        //{
        //    if (value != null)
        //    {
        //        if ((DateTime)value < _date)
        //        {
        //            var errorMessage = FormatErrorMessage(validationContext.DisplayName);
        //            return new ValidationResult(errorMessage);
        //        }
        //    }
        //    return ValidationResult.Success;
        //}
    }
}