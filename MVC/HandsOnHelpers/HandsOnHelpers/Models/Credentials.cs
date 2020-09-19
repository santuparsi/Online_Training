using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace HandsOnHelpers.Models
{
    public class Credentials
    {
        public string UserId { get; set; }
        [Required(ErrorMessage ="Enter Username")]
        public string Uname { get; set; }
        [Required(ErrorMessage ="Enter Password")]
        public string Password { get; set; }
    }
}
