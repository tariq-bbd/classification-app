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
            var httpContent = new StringContent(content, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _client.PostAsync("http://localhost:44369/api/diseases/stroke/predict", httpContent);

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
