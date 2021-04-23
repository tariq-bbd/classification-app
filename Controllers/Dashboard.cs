using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;
using Newtonsoft.Json;

namespace ClassificationApp.Controllers
{
    
    public class Dashboard : Controller
    {
        private readonly IHttpClientFactory _clientFactory;
        
        // GET: Dashboard

        public Dashboard(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }
        public  ActionResult Index()
        {
            var request = new HttpRequestMessage(HttpMethod.Get,
            "https://v2.jokeapi.dev/joke/Any");
            var client = _clientFactory.CreateClient();

            var response =  client.Send(request);
            if (response.IsSuccessStatusCode)
            {
                 var responseStream =  response.Content.ReadAsStringAsync().Result;
                
                ViewBag.response = JsonConvert.DeserializeObject( responseStream);
                
            }
            return View();
        }

        // GET: Dashboard/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Dashboard/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Dashboard/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Dashboard/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Dashboard/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Dashboard/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Dashboard/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
