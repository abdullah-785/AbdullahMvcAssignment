using AbdullahMvcAssignment.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AbdullahMvcAssignment.Controllers
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
            //ViewBag.Message = "Login";
            return View();
        }

        //, string email, string phone
        //&& email == "abc@gmail.com" && phone == "03317688086"


        public IActionResult form(string uname, string lname, string email, string phone)
        {
            if (uname == "Abdullah" && lname == "abc" && email == "abc@gmail.com" && phone == "0331")
            {
                ViewBag.Message = "Login Successfull";
            }
            else
            {
                ViewBag.Message = "Login failed";
            }
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