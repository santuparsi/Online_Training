using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace HandsOnHelpers.CustomValidations
{
    public class DOBAttribute:ValidationAttribute
    {
        //public string ErrorMsg;
        //public DOBAttribute(string err)
        //{
        //    ErrorMessage = err;
        //}
       
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime inputDate =Convert.ToDateTime(value);
            if (inputDate > System.DateTime.Now)
            {
                
                return new ValidationResult(this.ErrorMessage);
            }
            else
                return ValidationResult.Success;
        }
    }
}
