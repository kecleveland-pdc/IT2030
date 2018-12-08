using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;

namespace EventFinder.Models
{
    public class MinTicketsAttribute : ValidationAttribute
    {
        private readonly int _minTickets;
        public MinTicketsAttribute(int minTickets) : base("Ticket count must be greater than 0.")
        {
            _minTickets = minTickets;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {

                if ((int)value <= _minTickets)
                {
                    var errorMessage = FormatErrorMessage(validationContext.DisplayName);
                    return new ValidationResult(errorMessage);
                }
            }
            return ValidationResult.Success;
        }
    }
}