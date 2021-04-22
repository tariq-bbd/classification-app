using System.ComponentModel.DataAnnotations;

namespace ClassificationApp.Constants
{
    public enum SmokeStatus
    {
        [Display(Name = "Don't Smoke")]
        NON_SMOKER,
        [Display(Name = "Occasionally Smoke")]
        OCCASIONAL,
        [Display(Name = "Smoke Regularly")]
        SMOKER
    }
}
