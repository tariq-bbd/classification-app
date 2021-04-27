using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassificationApp.Models.Responses
{
    public class HeartFailureStats
    {
       

        public int totalCases { get; set; }
        public int chestPain { get; set; }
        public int cholestrol { get; set; }
        public int excerciseEngina { get; set; }
        public int heartFailure { get; set; }

       

    }

    public class StrokeStats
    {
     

        public int totalCases { get; set; }
        public int hypertension { get; set; }
        public int heartDisease { get; set; }
        public int highBMI { get; set; }
        public int smokes { get; set; }
        public int stroke { get; set; }
    }

    public class NumberofHeartFailurePatients
    {
     
        public int id { get; set; }
        public int age { get; set; }
        public int sex { get; set; }
        public int chestPainType { get; set; }
        public int restingBpS { get; set; }
        public int cholesterol { get; set; }

        public int fastingBloodSugar { get; set; }
        public int restingEcg { get; set; }
        public int maxHeartRate { get; set; }
        public int exerciseAngina { get; set; }
        public int oldPeak { get; set; }
        public int stSlope { get; set; }

        public int target { get; set; }
    }

    public class NumberOfStrokePatients
    { 
    }
    public class AllPatients
    { 
    
    }
}
