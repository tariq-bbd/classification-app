using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassificationApp.Controllers
{
    public class PredictionController : Controller
    {
        public IActionResult Stroke()
        {
            return View();
        }
    }
}
