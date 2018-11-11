using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace EnrollmentApplication.Models
{
    public class InvalidCharsAttribute : ValidationAttribute
    {
        private readonly string _invalidChars;
        public InvalidCharsAttribute(string invalidChars) : base("Notes contaains invalid characters!")
        {
            _invalidChars = invalidChars;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Regex regMatch = new Regex($"[{_invalidChars}]");
            if (value != null)
            {

                if (regMatch.IsMatch($"[{value}]"))
                {
                    var errorMessage = FormatErrorMessage(validationContext.DisplayName);
                    return new ValidationResult(errorMessage);
                }
            }
            return ValidationResult.Success;
        }

    }
}