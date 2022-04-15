using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using vidly.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace vidly.Controllers
{
    public class UsersController : Controller
    {


        [Route("users/{int userId}")]
        public IActionResult Index(int userId)
        {
            return View();
        }

        public IActionResult Login()
        {
             return RedirectToAction("Index", "Users", new {UserId = "1"}); 
        }

        public IActionResult Logout()
        {
            return RedirectToAction("Index", "Home");
        }

        [Route("answers")]
        public IActionResult Answers(int? QuestionId, int? userId)
        {
            return View();
        }


       
        




    }
}
