using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using HandsOnHelpers.CustomValidations;
namespace HandsOnHelpers.Models
{
    public class User
    {
        public string UserId { get; set; }
        [Required(ErrorMessage ="Pls Enter Name")]
        public string Name { get; set; }
        public string Gender { get; set; }
        [Required(ErrorMessage ="Pls Enter DOB")]
        [DOB(ErrorMessage ="Enter Correct DOB")]
        public DateTime DOB { get; set; }
        [Required(ErrorMessage ="Pls Enter EmailId")]
        [EmailAddress(ErrorMessage ="Pls Enter Valid EmailId")]
        public string Email { get; set; }
        [RegularExpression(@"[6789]\d{9}",ErrorMessage ="Invalid Mobile no")]
        public string Mobile { get; set; }
        [Required(ErrorMessage ="Pls Select Country")]
        public string Country { get; set; }
        [Required(ErrorMessage ="Pls Enter Username")]
        public string Username { get; set; }
        [Required(ErrorMessage ="Pls Enter Password")]
        [RegularExpression("[a-zA-Z0-9]{8}",ErrorMessage ="Password should be 8 chars long")]
        public string Password { get; set; }
        [Required(ErrorMessage ="Pls Enter Confirm Password")]
        [Compare("Password",ErrorMessage ="Password Mismatch")]
        public string ConfirmPassword { get; set; }

    }
}
