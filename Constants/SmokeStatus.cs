using System.ComponentModel.DataAnnotations;

namespace ClassificationApp.Constants
{
    public enum SmokeStatus
    {
        [Display(Name = "Formerly Smoked")]
        FORMERLY_SMOKED,
        [Display(Name = "Never Smoked")]
        NEVER_SMOKED,
        [Display(Name = "Smokes")]
        SMOKES,
        [Display(Name = "Unknown")]
        UNKNOWN
    }
}
