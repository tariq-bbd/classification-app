using ClassificationApp.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClassificationApp.Models.Diseases
{
    public class HeartAttackPredictionModel
    {
        [Required]
        [Display(Name = "Age")]
        [Range(0, 150)]
        public int Age { get; set; }

        [Required]
        [Display(Name = "Sex")]
        [EnumDataType(typeof(Sex))]
        public Sex Sex { get; set; }

        [Required]
        [Display(Name = "Cheast Pain Severity Level")]
        [Range(0, 4)]
        public int Chest_Pain_Type { get; set; }


        [Required]
        [Display(Name = "Resting BPS")]
        [Range(0, int.MaxValue)]
        public int Resting_bps { get; set; }

        [Required]
        [Display(Name = "Cholesterol Level")]
        [Range(0, int.MaxValue)]
        public int Cholesterol { get; set; }

        [Required]
        [Display(Name = "Fasting Blood Sugar Level")]
        [Range(0, int.MaxValue)]
        public int Fasting_blood_sugar { get; set; }

        [Required]
        [Display(Name = "Resting ECG")]
        [Range(0, 1)]
        public int Resting_ecg { get; set; }

        [Required]
        [Display(Name = "Max Heart Rate")]
        [Range(0, int.MaxValue)]
        public int Max_heart_rate { get; set; }

        [Required]
        [Display(Name = "Excercise_angina")]
        [Range(0, 1)]
        public int Excercise_angina { get; set; }

        [Required]
        [Display(Name = "Old Peak")]
        [Range(0, 5)]
        public int Old_peak { get; set; }

        [Required]
        [Display(Name = "St_slope")]
        [Range(0, 5)]
        public int St_slope { get; set; }
    }
}
