using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using vidly.Models;

namespace vidly.Controllers
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
            return View();
        }

        [Route("Register")]
        public IActionResult Register()
        {
            return View();
        }

        [Route("SignIn")]
        public IActionResult SignInPage()
        {
            return View();
        }

        [Route("Team")]
        public IActionResult Team()
        {
            return View();
        }

        public IActionResult AskQuestion(int? userId, int? QuestionId)
        {
            if (!userId.HasValue)
                userId = null;

            if (!QuestionId.HasValue)

                QuestionId = null;
                    return RedirectToAction("Index", "Users",new { userId, QuestionId });
             
                
           
            

        }


        [Route("About-us")]
        public IActionResult About()
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
