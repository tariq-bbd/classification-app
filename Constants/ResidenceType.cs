using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClassificationApp.Constants
{
    public enum ResidenceType
    {
        [Display(Name = "Urban")]
        URBAN,
        [Display(Name = "Rural")]
        RURAL
    }
}
