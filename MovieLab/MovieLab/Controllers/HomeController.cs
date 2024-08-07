using Microsoft.AspNetCore.Mvc;
using MovieLab.Models;
using MovieLab.Services;
using System.Diagnostics;

namespace MovieLab.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        // **Last Part of Dependancy Injection
        private readonly IOMDBService _omdbService;

        public HomeController(ILogger<HomeController> logger, IOMDBService omdbService /*Dependacy Injection*/)
        {
            _logger = logger;
            _omdbService = omdbService; //Dependancy Injeciton
        }


        //Lets use our service
        [HttpPost]
        public async Task<IActionResult> Search(string movieName) //we picked search because it alligns with the API Json
        {
            var result = await _omdbService.SearchMovies(movieName);

            return View(result.Search);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
