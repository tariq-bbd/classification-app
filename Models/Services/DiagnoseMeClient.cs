using System.Threading.Tasks;
using ClassificationApp.Models.Diseases;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using System.Net;

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
            string content = JsonConvert.SerializeObject(model);
            var obj = new
            {
                Gender = "Male",
                Age = 62,
                HasHypertention = 0,
                HasHeartDisease = 1,
                EverMarried = "yes",
                WorkType = "Private",
                ResidenceType = "Urban",
                AverageGlucoseLevel = 228.69,
                BMI = 36.6,
                SmokingStatus = "formerly smoked"
            };
            content = JsonConvert.SerializeObject(obj);
            var httpContent = new StringContent(content, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("http://bbd-classification-app-backend.azurewebsites.net/api/diseases/stroke/predict", httpContent);
            if (response.IsSuccessStatusCode)
            {

            }

            return response.Content.ReadAsStringAsync().Result;
        }

        public async Task<float> GetHeartAttackPredictionResult(HeartAttackPredictionModel model)
        {
            var response = await _client.GetStringAsync("");

            return 1;
        }

    }

    public interface IDiagnoseMeClient
    {
        public Task<string> GetStrokePredictionResult(StrokePredictionModel model);
    }
}
