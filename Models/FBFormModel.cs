using System;
using System.ComponentModel.DataAnnotations;

namespace MiniBlog.Models
{
    public class FBFormModel
    {
        [Required(ErrorMessage = "Please select policy")]
        public string Policy { get; set; }

        [Required(ErrorMessage = "Please select category")]
        public string Categories { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter phone")]
        public string Phone{ get; set; }

        [Required(ErrorMessage = "Please enter last name")]
        public string LastName{ get; set; }

        [Required(ErrorMessage = "Please enter first name")]
        public string FirstName{ get; set; }

        public string Message { get; set; }
        public int Id { get; set; }
   
    }
}
