using System.ComponentModel.DataAnnotations;

namespace ClassificationApp.Models
{
    public class HeartDiseaseModel
    {
        

        [Required]
        [Range(0, int.MaxValue)]
        public int Age { get; set; }

        [Required]
        [Range(0, 1)]
        public int Sex { get; set; }

        [Required]
        [Range(0, 4)]
        public int Chest_Pain_Type { get; set; }

       
        [Required]
        [Range(0, int.MaxValue)]
        public int Resting_bps { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int Cholesterol { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int Fasting_blood_sugar { get; set; }

        [Required]
        [Range(0, 1)]
        public int Resting_ecg { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int Max_heart_rate { get; set; }

        [Required]
        [Range(0, 1)]
        public int Excercise_angina { get; set; }

        [Required]
        [Range(0, 5)]
        public int Old_peak { get; set; }

        [Required]
        [Range(0, 5)]
        public int St_slope { get; set; }

    }
}
/*
 * 
 * [ColumnName("age"), LoadColumn(0)]
        public float Age { get; set; }


        [ColumnName("sex"), LoadColumn(1)]
        public string Sex { get; set; }


        [ColumnName("chest pain type"), LoadColumn(2)]
        public float Chest_pain_type { get; set; }


        [ColumnName("resting bp s"), LoadColumn(3)]
        public float Resting_bp_s { get; set; }


        [ColumnName("cholesterol"), LoadColumn(4)]
        public float Cholesterol { get; set; }


        [ColumnName("fasting blood sugar"), LoadColumn(5)]
        public string Fasting_blood_sugar { get; set; }


        [ColumnName("resting ecg"), LoadColumn(6)]
        public string Resting_ecg { get; set; }


        [ColumnName("max heart rate"), LoadColumn(7)]
        public float Max_heart_rate { get; set; }


        [ColumnName("exercise angina"), LoadColumn(8)]
        public string Exercise_angina { get; set; }


        [ColumnName("oldpeak"), LoadColumn(9)]
        public float Oldpeak { get; set; }


        [ColumnName("ST slope"), LoadColumn(10)]
        public float ST_slope { get; set; }


        [ColumnName("target"), LoadColumn(11)]
        public string Target { get; set; }
 * 
 * 
 * */