using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using nbaMVC.Models;

namespace nbaMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, nbaDB DB)
        {
            _logger = logger;
            db = DB;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        // [HttpGet]
        // public async Task<IActionResult> NbaStats()
        // {

        //     await db.Connection.OpenAsync();
        //     var query = new testQuery(db);
        //     var result = await query.runQuery();
        //     if (result is null)
        //         return new NotFoundResult();
        //     return new OkObjectResult(result);

        // }
        [HttpPost]
        public ActionResult createQuery (){
            string name = Request.Form["first"] + " " + Request.Form["last"];
            string season = Request.Form["season"];
            //string cats = Request.Form["catValues"];
            List<string> catValues = new List<string>();
            foreach(var entry in Request.Form){
                if(entry.Value == "true"){
                    catValues.Add(entry.Key);
                }
            }
            Console.WriteLine(catValues.GetType());
            Console.WriteLine(catValues[1]);
            queryDetails resultQueryObject = new queryDetails(name, season, catValues, db);
            resultQueryObject.runQuery();
            return Content(string.Join(",", catValues));
        }
        [HttpGet]
        public ActionResult NbaStats()
        {
            // put in our controller logic for the sql query here:
            return View();
        }
        public async Task<IActionResult>queryResults(string first, string last, List<bool> qparams, string season)
        {
            // pull data from view
            await db.Connection.OpenAsync();
            var query = new testQuery(db);
            var result = await query.createQuery(first + " " + last, qparams, season);
            if (result is null)
                return new NotFoundResult();
            return new OkObjectResult(result);

        }
        public IActionResult dbUpload()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public nbaDB db {get; }
    }
}
