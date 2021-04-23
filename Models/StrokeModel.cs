using System.ComponentModel.DataAnnotations;

namespace ClassificationApp.Models
{

    //gender	age	hypertension	heart_disease	ever_married	work_type	Residence_type	avg_glucose_level	bmi	smoking_status	stroke

    public enum EverMarried
    {
        Yes,
        No,
       
    }
    public enum WorkType
    {
        Private,
        SelfEmployed,
        GovtJob

    }
    public enum Residence_Type
    {
        Urban,
        Rural,
        

    }
    public enum Smoking_Status
    {
        formerly_smoked,
        never_smoked,
        smokes,
        Unknown


    }
    public class StrokeModel
    {
        [Required]
        [EnumDataType(typeof(Gender))]
        public Gender Gender { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int Age { get; set; }

        [Required]
        [Range(0, 1)]
        public int Hypertension { get; set; }

        [Required]
        [Range(0, 1)]
        public int Heart_disease { get; set; }

        [Required]
        [EnumDataType(typeof(EverMarried))]
        public EverMarried EverMarried { get; set; }

        [Required]
        [EnumDataType(typeof(WorkType))]
        public WorkType WorkType { get; set; }

        [Required]
        [EnumDataType(typeof(Residence_Type))]
        public Residence_Type Residence_Type { get; set; }

        [Required]
        [Range(0, float.MaxValue)]
        public float AvgGlucoseLevel { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Bmi")]
        [MaxLength(250)]
        public float Bmi { get; set; }

        [Required]
        [EnumDataType(typeof(Smoking_Status))]
        public Smoking_Status Smoking_Status { get; set; }
        
    }
}
