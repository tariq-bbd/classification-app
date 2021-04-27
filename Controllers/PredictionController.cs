using Microsoft.AspNetCore.Mvc;
using ClassificationApp.Models.Diseases;
using ClassificationApp.Models.Services;
using System.Threading.Tasks;
using System.Net;
using System;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft;
using Newtonsoft.Json;

namespace ClassificationApp.Controllers
{
    public class PredictionController : Controller
    {

        private IDiagnoseMeClient _diagnoseMeService;

        public PredictionController(IDiagnoseMeClient diagnoseMeService)
        {
            _diagnoseMeService = diagnoseMeService;
        }

        [Authorize]
        public IActionResult Stroke()
        {
            return View();
        }

        [Authorize]
        public IActionResult HeartAttack()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<JsonResult> Stroke(StrokePredictionModel model)
        {
            if (!ModelState.IsValid)
            {
                return Json(JsonConvert.SerializeObject(new { error = "Invalid form data" }));
            }
            return Json(await _diagnoseMeService.GetStrokePredictionResult(model));
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<JsonResult> HeartAttack(HeartAttackPredictionModel model)
        {
            if (!ModelState.IsValid)
            {
                return Json(JsonConvert.SerializeObject(new { error = "Invalid form data" }));

            }
            return Json(await _diagnoseMeService.GetHeartFailurePredictionResult(model));
        }
    }
}
