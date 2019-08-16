using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DojoSurvey.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DojoSurvey.Controllers {
    public class HelloController: Controller {
        // GET: /<controller>/
        [HttpGet("")]
        public IActionResult Index() {
            return View();
        }

        [HttpPost("result")]
        public IActionResult Result(Survey survey) {
            if (ModelState.IsValid) {
                ViewBag.Name = survey.Name;
                ViewBag.Location = survey.Location;
                ViewBag.FavLang = survey.FavLanguage;
                ViewBag.Comment = survey.Comment;
                return View("result");
            } else {
                // Oh no!  We need to return a ViewResponse to preserve the ModelState, and the errors it now contains!
                return View("Index");
            }
        }
    }
}

// 