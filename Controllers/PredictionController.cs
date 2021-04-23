using Microsoft.AspNetCore.Mvc;
using ClassificationApp.Models.Diseases;

namespace ClassificationApp.Controllers
{
    public class PredictionController : Controller
    {
        public IActionResult Stroke()
        {
            return View();
        }
        public IActionResult HeartAttack()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Stroke(StrokePredictionModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            ViewBag.success = "success";
            return View();
        }
    }
}
