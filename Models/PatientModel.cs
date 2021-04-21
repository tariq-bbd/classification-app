using System.ComponentModel.DataAnnotations;

namespace ClassificationApp.Models
{

    public enum Gender
    {
        Unknown,
        Male,
        Female,
        Other
    }

    public class PatientModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "First Name")]
        [MaxLength(250)]
        public string FirstName { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Middle Name")]
        [MaxLength(250)]
        public string MiddleName { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Last Name")]
        [MaxLength(250)]
        public string LastName { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int Age { get; set; }
        [Required]
        [EnumDataType(typeof(Gender))]
        public Gender Gender { get; set; }
    }
}
