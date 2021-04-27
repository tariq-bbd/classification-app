using ClassificationApp.Constants;
using System;
using System.ComponentModel.DataAnnotations;

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
        public int ChestPainType { get; set; }


        [Required]
        [Display(Name = "Resting BPS")]
        [Range(0, int.MaxValue)]
        public int RestingBPS { get; set; }

        [Required]
        [Display(Name = "Cholesterol Level")]
        [Range(0, int.MaxValue)]
        public int Cholesterol { get; set; }

        [Required]
        [Display(Name = "Fasting Blood Sugar Level")]
        public bool FastingBloodSugar { get; set; }

        [Required]
        [Display(Name = "Spiked Resting ECG")]
        public bool RestingECG { get; set; }

        [Required]
        [Display(Name = "Max Heart Rate")]
        [Range(0, int.MaxValue)]
        public int MaxHeartRate { get; set; }

        [Required]
        [Display(Name = "Excercise angina")]
        public bool ExerciseAngia { get; set; }

        [Required]
        [Display(Name = "Old Peak")]
        [Range(0, 5)]
        public int OldPeakLevel { get; set; }

        [Required]
        [Display(Name = "Severity Slope")]
        [Range(0, 3)]
        public int SeveritySlope { get; set; }
    }
}
