using ClassificationApp.Constants;
using System;
using System.ComponentModel.DataAnnotations;

namespace ClassificationApp.Models.Diseases
{
    public class StrokePredictionModel
    {
        [Required]
        [Display(Name = "Gender")]
        [EnumDataType(typeof(Sex))]
        public Sex Gender { get; set; }

        [Required]
        [Display(Name = "Age")]
        [Range(0, 150)]
        public int Age { get; set; }

        [Required]
        [Display(Name = "Hypertention")]
        public bool HasHypertension { get; set; }

        [Required]
        [Display(Name = "Heart Disease")]
        public bool HasHeartDisease { get; set; }

        [Required]
        [Display(Name = "Ever Married")]
        public bool EverMarried { get; set; }

        [Required]
        [Display(Name = "Work Type")]
        [EnumDataType(typeof(WorkType))]
        public WorkType WorkType { get; set; }

        [Required]
        [Display(Name = "Residence Type")]
        [EnumDataType(typeof(ResidenceType))]
        public ResidenceType ResidenceType { get; set; }

        [Required]
        [Display(Name = "Average Glucose Level")]
        [Range(0, 250)]
        public double AverageGlucoseLevel { get; set; }

        [Required]
        [Range(0,45.0)]
        [Display(Name = "BMI")]
        public double BMI { get; set; }

        [Required]
        [Display(Name = "Smoke Status")]
        [EnumDataType(typeof(SmokeStatus))]
        public SmokeStatus SmokingStatus { get; set; }

    }
}
