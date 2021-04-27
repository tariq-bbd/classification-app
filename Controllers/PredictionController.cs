using Microsoft.AspNetCore.Mvc;
using ClassificationApp.Models.Diseases;
using ClassificationApp.Models.Services;
using System.Threading.Tasks;
using System.Net;
using System;

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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<JsonResult> Stroke(StrokePredictionModel model)
        {
            if (!ModelState.IsValid)
            {
                return Json(new { error = "Invalid form data" });
            }
            return Json(await _diagnoseMeService.GetStrokePredictionResult(model));
        }
    }
}
