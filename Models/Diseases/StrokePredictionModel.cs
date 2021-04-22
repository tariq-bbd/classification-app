using ClassificationApp.Constants;
using System;
using System.ComponentModel.DataAnnotations;

namespace ClassificationApp.Models.Diseases
{
    public class StrokePredictionModel
    {
        [Required]
        [EnumDataType(typeof(Sex))]
        public Sex Gender { get; set; }

        [Required]
        [Range(0, 150)]
        public int Age { get; set; }

        [Required]
        public int HasHypertension { get; set; }

        [Required]
        public int HasHeartDisease { get; set; }

        [Required]
        [MaxLength(250)]
        public string EverMarried { get; set; }

        [Required]
        [MaxLength(250)]
        public string WorkType { get; set; }

        [Required]
        [EnumDataType(typeof(ResidenceType))]
        public ResidenceType ResidenceType { get; set; }

        [Required]
        [Range(0, 250)]
        public double AverageGlucoseLevel { get; set; }

        [Required]
        public double BMI { get; set; }

        [Required]
        [EnumDataType(typeof(SmokeStatus))]
        public SmokeStatus SmokingStatus { get; set; }

        [Required]
        public bool HadStroke { get; set; }
    }
}
