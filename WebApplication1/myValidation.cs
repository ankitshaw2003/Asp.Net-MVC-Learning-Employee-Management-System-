using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace WebApplication1
{
    public class myValidation:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null) { 
                string message = value.ToString();
                if(message.Contains(' '))
                {
                    return ValidationResult.Success;
                }
            }
            return new ValidationResult("Full Name must contain a space");
        }
    }
}