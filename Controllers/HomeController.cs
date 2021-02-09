using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProvoFood.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProvoFood.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // Creates a list from the array in the model
            List<TopRestaurant> restList = new List<TopRestaurant>();
            foreach(TopRestaurant tr in TopRestaurant.GetRest())
            {
                restList.Add(tr);
            }
            return View(restList);
        }
        [HttpGet]
        public IActionResult Suggestion()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Suggestion(SuggestionStorage newSuggestion)
        {
            // Checks for null in the optional FavDish Field on the incoming object
            if (newSuggestion.FavDish == null)
            {
                newSuggestion.FavDish = "It's all tasty!";
            }
            SuggestionStorage.AddSuggestion(newSuggestion);
            return RedirectToAction("UserSuggestions");
        }
        public IActionResult UserSuggestions()
        {
            // Displays the suggestions using a list object
            List<SuggestionStorage> suggestionList = new List<SuggestionStorage>();
            foreach (SuggestionStorage suggestion in SuggestionStorage.Suggestions)
            {
                suggestionList.Add(suggestion);
            }
            return View(suggestionList);
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
