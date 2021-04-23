using System;
using System.ComponentModel.DataAnnotations;
using ClassificationApp.Constants;
using Microsoft.AspNetCore.Identity;

namespace ClassificationApp.Areas.Identity.Data
{

    // Add profile data for application users by adding properties to the DiagnoseMeUser class
    public class DiagnoseMeUser : IdentityUser
    {
        [PersonalData]
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "First Name")]
        [MaxLength(250)]
        public string FirstName { get; set; }

        [PersonalData]
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Middle Name")]
        [MaxLength(250)]
        public string MiddleName { get; set; }

        [PersonalData]
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Last Name")]
        [MaxLength(250)]
        public string LastName { get; set; }

        [PersonalData]
        [Required]
        [Range(0, int.MaxValue)]
        public int Age { get; set; }

        [PersonalData]
        [Required]
        [EnumDataType(typeof(Sex))]
        public Sex Gender { get; set; }

    }
}
