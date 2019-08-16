using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DojoSurvey.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DojoSurvey.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("result")]
        public IActionResult Result(Survey survey, string test)
        {
            ViewBag.Name = survey.Name;
            ViewBag.Location = survey.Location;
            ViewBag.FavLang = survey.FavLanguage;
            ViewBag.Comment = survey.Comment;
            return View();
        }
    }
}
