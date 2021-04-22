using ClassificationApp.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClassificationApp.Models.Diseases
{
    public class HeartFailurePredictionModel
    {
        [Required]
        [Range(0, int.MaxValue)]
        public int Age { get; set; }

        [Required]
        public bool Anaemia { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int CreatininePhosphokinase { get; set; }

        [Required]
        public bool Diabetes { get; set; }

        [Required]
        [Range(0,100)]
        public int EjectionFraction { get; set; }

        [Required]
        public bool HighBloodPressure { get; set; }

        [Required]
        public int Platelets { get; set; }

        [Required]
        public float SerumCreatinine { get; set; }

        [Required]
        public int SerumSodium { get; set; }

        [Required]
        [EnumDataType(typeof(Sex))]
        public Sex Sex { get; set; }

        [Required]
        public bool Smoking { get; set; }

        [Required]
        public int Time { get; set; }
    }
}
