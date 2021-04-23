using System.ComponentModel.DataAnnotations;

namespace ClassificationApp.Constants
{
    public enum WorkType
    {
        [Display(Name = "Private")]
        PRIVATE,
        [Display(Name = "Self Employed")]
        SELF_EMPLOYED,
        [Display(Name = "Goverment Job")]
        GOVT_JOB
    }
}
