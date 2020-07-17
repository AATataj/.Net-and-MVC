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
        [HttpGet]
        public async Task<IActionResult> NbaStats()
        {

            await db.Connection.OpenAsync();
            var query = new testQuery(db);
            var result = await query.runQuery();
            if (result is null)
                return new NotFoundResult();
            return new OkObjectResult(result);

        }
        /*public IActionResult NbaStats()
        {
            // put in our controller logic for the sql query here:
            return View();
        }*/
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
