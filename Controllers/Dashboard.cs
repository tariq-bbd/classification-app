﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Authorization;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;


namespace ClassificationApp.Controllers
{
    // [Authorize]
    public class Dashboard : Controller
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly DataApi dataCall;
        private readonly ApiClient apiClient;


        // GET: Dashboard

        public Dashboard(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
            // apiClient = new ApiClient();
            dataCall = new DataApi("http://bbd-classification-app-backend.azurewebsites.net/");

        }

        [Authorize]
        public ActionResult Index()
        {

            // getHeartData();// all heart stats
            getStrokeData(1, 225); // heart stats for a given two points
            getStrokeDataforBmi(28);
            getNumberofRecordsStroke(15);
            getNumberofRecordsheartFailure(15);
            getMaleFemaleData();


            return View();
        }
        public void getHeartData()
        {
            var requestHeartFailure = new HttpRequestMessage(HttpMethod.Get,
           "http://bbd-classification-app-backend.azurewebsites.net/api/data/heart_failure/all");

            var client = _clientFactory.CreateClient();

            var heartFailureResponse = client.Send(requestHeartFailure);
            ViewBag.testgetHeartData = 1;
            if (heartFailureResponse.IsSuccessStatusCode)
            {
                var responseStream = heartFailureResponse.Content.ReadAsStringAsync().Result;

                JObject rss = JObject.Parse(responseStream);
                Console.WriteLine(rss.ToString());
                Console.WriteLine("deserialised data");
                Console.WriteLine(JsonConvert.DeserializeObject(responseStream));



                ViewBag.getHeartData = JsonConvert.DeserializeObject(responseStream);

            }
            else
            {
                Console.WriteLine(heartFailureResponse.ToString());
            }

        }
        public void getStrokeData(int chest_Pain, int cholesterol)

        {/*
            if (chest_Pain > 4 || chest_Pain < 0 || cholesterol < 100 || cholesterol > 310)
            {
                //set values to proper values within scope
                chest_Pain = 1;
                cholesterol = 225;

            }
            ViewBag.testgetStrokeData = 2;
            var requestStrokeData = new HttpRequestMessage(HttpMethod.Get,
           "http://bbd-classification-app-backend.azurewebsites.net/api/data/heart_failure/1/225");

            var client = _clientFactory.CreateClient();

            var StrokeResponse = client.Send(requestStrokeData);
            if (StrokeResponse.IsSuccessStatusCode)
            {
                var responseStream = StrokeResponse.Content.ReadAsStringAsync().Result;
                dynamic product = new JObject();

               
                Console.WriteLine("getStrokeData");
      
                Console.WriteLine("deserialised data");
                Console.WriteLine(JsonConvert.DeserializeObject(responseStream));



                ViewBag.getStrokeData = JsonConvert.DeserializeObject(responseStream);

            }
            else
            {
                Console.WriteLine("getStrokeData");
                Console.WriteLine(StrokeResponse.ToString());
            }*/
            HeartFailureReturnModel myobj = dataCall.ApiDataHeartFailureChestPainLCholestrolLGet(1, 250);
            Console.WriteLine(myobj.ToString());

            string[] labels = { nameof(myobj.TotalCases), nameof(myobj.HeartFailure), nameof(myobj.Cholestrol), nameof(myobj.ChestPain), nameof(myobj.ExcerciseEngina) };
            int?[] data = { myobj.TotalCases, myobj.HeartFailure, myobj.Cholestrol, myobj.ChestPain, myobj.ExcerciseEngina };
            ViewBag.heartLabels = labels;
            ViewBag.heartStats = data;



        }
        public void getStrokeDataforBmi(int bmi)
        {
            /*  var requestStrokeDataforBmi = new HttpRequestMessage(HttpMethod.Get,
             "http://bbd-classification-app-backend.azurewebsites.net/api/data/stroke/25");

              var client = _clientFactory.CreateClient();
              ViewBag.testgetStrokeDataforBmi = 3;

              var StrokeResponseforBmi = client.Send(requestStrokeDataforBmi);
              if (StrokeResponseforBmi.IsSuccessStatusCode)
              {
                  var responseStream = StrokeResponseforBmi.Content.ReadAsStringAsync().Result;


                  Console.WriteLine("getStrokeDataforBmi");

                  Console.WriteLine("deserialised data");
                  Console.WriteLine(JsonConvert.DeserializeObject(responseStream));



                  ViewBag.getStrokeDataforBmi = JsonConvert.DeserializeObject(responseStream);


              }
              else
              {
                  Console.WriteLine("getStrokeDataforBmi");
                  Console.WriteLine(StrokeResponseforBmi.ToString());
              }*/

            StrokeReturnModel myobj = dataCall.ApiDataStrokeBmiGet(28);



            string[] labels = { nameof(myobj.HeartDisease), nameof(myobj.HighBMI), nameof(myobj.Hypertension), nameof(myobj.Smokes), nameof(myobj.TotalCases), nameof(myobj.Stroke) };
            int?[] data = { myobj.HeartDisease, myobj.HighBMI, myobj.Hypertension, myobj.Smokes, myobj.TotalCases, myobj.Stroke };
            ViewBag.strokeLabels = labels;
            ViewBag.strokeData = data;



        }
        public void getNumberofRecordsStroke(int numberOfRecords)
        {
            /* ViewBag.testgetNumberofRecordsStroke = 4;
             var requestStrokeDataAmount = new HttpRequestMessage(HttpMethod.Get,
            "http://bbd-classification-app-backend.azurewebsites.net/api/data/records/stroke/15");

             var client = _clientFactory.CreateClient();

             var StrokeResponseforAmount = client.Send(requestStrokeDataAmount);
             if (StrokeResponseforAmount.IsSuccessStatusCode)
             {
                 var responseStream = StrokeResponseforAmount.Content.ReadAsStringAsync().Result;


                 Console.WriteLine("getNumberofRecordsStroke");

                 Console.WriteLine("deserialised data");
                 Console.WriteLine(JsonConvert.DeserializeObject(responseStream));



                 ViewBag.getNumberofRecordsStroke = JsonConvert.DeserializeObject(responseStream);

             }
             else
             {
                 Console.WriteLine("getNumberofRecordsStroke");
                 Console.WriteLine(StrokeResponseforAmount.ToString()) ;
             }*/
            //List<HeartFailureDataModel>
            List<StrokeDataModel> myobjs = dataCall.ApiDataRecordsStrokeNumOfRecordsGet(10);

            ViewBag.strokeQty = myobjs.ToArray();

        }
        public void getNumberofRecordsheartFailure(int numberOfRecords)
        {
            /*
            ViewBag.testgetNumberofRecordsheartFailure = 5;
            var requestHeartFailDataAmount = new HttpRequestMessage(HttpMethod.Get,
           "http://bbd-classification-app-backend.azurewebsites.net/api/data/records/heartFailure/15");

            var client = _clientFactory.CreateClient();

            var HeartFailResponseforAmount = client.Send(requestHeartFailDataAmount);
            if (HeartFailResponseforAmount.IsSuccessStatusCode)
            {
                var responseStream = HeartFailResponseforAmount.Content.ReadAsStringAsync().Result;
              

                Console.WriteLine("getNumberofRecordsheartFailure");
                
                JObject myobj = JsonConvert.DeserializeObject<>
                Console.WriteLine(JsonConvert.DeserializeObject(responseStream));
                Console.WriteLine("Serialised data");
                Console.WriteLine(JsonConvert.SerializeObject(responseStream));

                //string = JsonConvert.SerializeObject();
                // JObject myobj = JsonConvert.DeserializeObject<JObject>(responseStream);

                // ViewBag.getNumberofRecordsheartFailure = ;

            }
            else
            {
                Console.WriteLine("getNumberofRecordsheartFailure");
                Console.WriteLine(HeartFailResponseforAmount.ToString());
            }*/



            List<HeartFailureDataModel> myobjs = dataCall.ApiDataRecordsHeartFailureNumOfRecordsGet(numberOfRecords);

            ViewBag.heartFailQty = myobjs.ToArray();

            /* foreach (HeartFailureDataModel x in myobjs)
             {

                 Console.WriteLine(nameof(x.Age));


             }*/






        }
        public void getMaleFemaleData()
        {

            StrokeReturnModel strokeMale = dataCall.ApiDataStrokeMaleBmiGet(28);


            string[] labels = { nameof(strokeMale.HeartDisease), nameof(strokeMale.HighBMI), nameof(strokeMale.Hypertension), nameof(strokeMale.Smokes), nameof(strokeMale.Stroke) };
            int?[] data = { strokeMale.HeartDisease, strokeMale.HighBMI, strokeMale.Hypertension, strokeMale.Smokes, strokeMale.Stroke };
            ViewBag.strokeMaleLabels = labels;
            ViewBag.strokeMaleData = data;

            HeartFailureReturnModel heartFailure = dataCall.ApiDataHeartFailureMaleChestPainLCholestrolLGet(1, 250);


            string[] labelsheartFailure = { nameof(heartFailure.HeartFailure), nameof(heartFailure.Cholestrol), nameof(heartFailure.ChestPain), nameof(heartFailure.ExcerciseEngina) };
            int?[] dataheartFailure = { heartFailure.HeartFailure, heartFailure.Cholestrol, heartFailure.ChestPain, heartFailure.ExcerciseEngina };
            ViewBag.heartMaleLabels = labelsheartFailure;
            ViewBag.heartMaleStats = dataheartFailure;
            //********************************************female
            StrokeReturnModel strokemFemale = dataCall.ApiDataStrokeFemaleBmiGet(28);


            string[] labelsFemaleheart = { nameof(strokemFemale.HeartDisease), nameof(strokemFemale.HighBMI), nameof(strokemFemale.Hypertension), nameof(strokemFemale.Smokes), nameof(strokemFemale.Stroke) };
            int?[] dataFemaleheart = { strokemFemale.HeartDisease, strokemFemale.HighBMI, strokemFemale.Hypertension, strokemFemale.Smokes, strokemFemale.Stroke };
            ViewBag.strokeFemaleLabels = labelsFemaleheart;
            ViewBag.strokemFemaleData = dataFemaleheart;

            HeartFailureReturnModel heartFailurefemale = dataCall.ApiDataHeartFailureFemaleChestPainLCholestrolLGet(1, 250);


            string[] labelsfemaleheartFailure = { nameof(heartFailurefemale.HeartFailure), nameof(heartFailurefemale.Cholestrol), nameof(heartFailurefemale.ChestPain), nameof(heartFailurefemale.ExcerciseEngina) };
            int?[] dataheartfemaleFailure = { heartFailurefemale.HeartFailure, heartFailurefemale.Cholestrol, heartFailurefemale.ChestPain, heartFailurefemale.ExcerciseEngina };
            ViewBag.heartFemaleLabels = labelsfemaleheartFailure;
            ViewBag.heartFemaleStats = dataheartfemaleFailure;


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
