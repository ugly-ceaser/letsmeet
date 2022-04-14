using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using vidly.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random/
        public IActionResult Random()

        {
            var movies = new Movies() { Name = "Iron Man 2" };
            return View(movies);
        }

        public IActionResult Edit (int movieid) {

            return Content("id = "+ movieid);


        }
    }
}
