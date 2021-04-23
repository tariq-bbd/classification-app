using Microsoft.AspNetCore.Mvc;
using ClassificationApp.Models.Diseases;
using ClassificationApp.Models.Services;
using System.Threading.Tasks;
using System.Net;

namespace ClassificationApp.Controllers
{
    public class PredictionController : Controller
    {

        private IDiagnoseMeClient _diagnoseMeService;

        public PredictionController(IDiagnoseMeClient diagnoseMeService)
        {
            _diagnoseMeService = diagnoseMeService;
        }

        public IActionResult Stroke()
        {
            return View();
        }
        public IActionResult HeartAttack()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Stroke(StrokePredictionModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            string predictionResult = _diagnoseMeService.GetStrokePredictionResult(model).Result;
            return Content(predictionResult);
        }
    }
}
