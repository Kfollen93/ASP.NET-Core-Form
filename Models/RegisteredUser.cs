using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FormTemplateProject.Models
{
    public class RegisteredUser
    {
        public int Id { get; set; }

        [Display(Name = "NAME *")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "Your name must be between 4-50 characters in length.")]
        [Required(ErrorMessage = "You must enter your full name.")]
        public string Name { get; set; }

        [Display(Name = "EMAIL *")]
        [DataType(DataType.EmailAddress)]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Your email must be between 5-50 characters in length.")]
        [Required(ErrorMessage = "You must enter your email address.")]
        public string EmailAddress { get; set; }

        [Display(Name = "PHONE NUMBER *")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(22, MinimumLength = 10, ErrorMessage = "Your phone number must be between 10-22 characters in length.")]
        [Required(ErrorMessage = "You must enter your phone number.")]
        public string PhoneNumber { get; set; }

        [Display(Name = "INDUSTRY *")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Your industry must be between 3-50 characters in length.")]
        [Required(ErrorMessage = "You must enter your industry.")]
        public string Industry { get; set; }
    }
}
