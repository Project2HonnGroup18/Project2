using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AcademicReferenceManager.Models.Attributes
{
    public class TypeAttribute : ValidationAttribute
    {
        private readonly List<string> validationTokens = new List<string>{"electronic", "printed"};

        protected override ValidationResult IsValid(object val, ValidationContext context)
        {
            if(validationTokens.Contains(val.ToString()))
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("Invalid Type Should be one of electronic or printed");
        }
    }
}