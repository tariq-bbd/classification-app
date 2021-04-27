using System.Threading.Tasks;
using ClassificationApp.Models.Diseases;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using ClassificationApp.Constants;

namespace ClassificationApp.Models.Services
{
    public class DiagnoseMeClient : IDiagnoseMeClient
    {

        private readonly HttpClient _client;


        public DiagnoseMeClient(HttpClient httpClient)
        {
            _client = httpClient;
        }

        public async Task<string> GetStrokePredictionResult(StrokePredictionModel model)
        {
            string ModelWorkType, ModelResidenceType, ModelSmokingStatus;
            switch (model.WorkType)
            {
                case WorkType.PRIVATE:
                    {
                        ModelWorkType = "Private"; 
                        break;
                    }
                case Constants.WorkType.GOVT_JOB:
                    {
                        ModelWorkType = "Govt_job";
                        break;
                    }
                default:
                    {
                        ModelWorkType = "Self-employed";
                        break;
                    }
            }
            switch (model.ResidenceType)
            {
                case ResidenceType.RURAL:
                    {
                        ModelResidenceType = "Rural";
                        break;
                    }
                default:
                    {
                        ModelResidenceType = "Urban";
                        break;
                    }
            }
            switch(model.SmokingStatus)
            {
                case SmokeStatus.FORMERLY_SMOKED:
                    {
                        ModelSmokingStatus = "formerly smoked";
                        break;
                    }
                case SmokeStatus.SMOKES:
                    {
                        ModelSmokingStatus = "smokes";
                        break;
                    }
                case SmokeStatus.NEVER_SMOKED:
                    {
                        ModelSmokingStatus = "never smoked";
                        break;
                    }
                default:
                    {
                        ModelSmokingStatus = "Unknown";
                        break;
                    }

            }
            var obj = new
            {
                Gender = model.Gender == 0 ? "Male": "Female",
                Age = model.Age,
                HasHypertention = model.HasHypertension ? 1 : 0,
                HasHeartDisease = model.HasHeartDisease ? 1 : 0,
                EverMarried = model.EverMarried ? 1 : 0,
                WorkType = ModelWorkType,
                ResidenceType = ModelResidenceType,
                AverageGlucoseLevel = model.AverageGlucoseLevel,
                BMI = model.BMI,
                SmokingStatus = ModelSmokingStatus
            };
            string content = JsonConvert.SerializeObject(obj);
            var httpContent = new StringContent(content, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("http://bbd-classification-app-backend.azurewebsites.net/api/diseases/stroke/predict", httpContent);
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetHeartFailurePredictionResult(HeartAttackPredictionModel model)
        {
            var obj = new {
                age = model.Age,
                sex = model.Sex == 0 ? "Male" : "Female",
                chest_pain_type = model.ChestPainType,
                resting_bp_s = model.RestingBPS,
                cholesterol = model.Cholesterol,
                fasting_blood_sugar = model.FastingBloodSugar ? "1" : "0",
                resting_ecg = model.RestingECG ? "1" : "0",
                max_heart_rate = model.MaxHeartRate,
                exercise_angina = model.ExerciseAngia ? "1" : "0",
                oldpeak = model.OldPeakLevel,
                sT_slope = model.SeveritySlope
            };
            string content = JsonConvert.SerializeObject(obj);
            var httpContent = new StringContent(content, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("http://bbd-classification-app-backend.azurewebsites.net/api/diseases/heart_failure/predict", httpContent);
            return await response.Content.ReadAsStringAsync();
        }

    }

    public interface IDiagnoseMeClient
    {
        public Task<string> GetStrokePredictionResult(StrokePredictionModel model);

        public Task<string> GetHeartFailurePredictionResult(HeartAttackPredictionModel model);

    }
}
