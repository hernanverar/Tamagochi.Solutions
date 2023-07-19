using Microsoft.AspNetCore.Mvc;
using Tamagochi.Models;
using System.Collections.Generic;


namespace Tamagochi.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}