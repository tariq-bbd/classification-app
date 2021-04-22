using System.ComponentModel.DataAnnotations;

namespace ClassificationApp.Constants
{
    public enum Sex
    {
        [Display(Name = "Prefer not to say")]
        UNKNOWN,
        [Display(Name = "Male")]
        MALE,
        [Display(Name = "Female")]
        FEMALE,
        [Display(Name = "Other")]
        OTHER
    }
}
