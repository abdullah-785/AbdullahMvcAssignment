using AbdullahMvcAssignment.Data;
using AbdullahMvcAssignment.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AbdullahMvcAssignment.Controllers
{
    public class HomeController : Controller
    {

        DataDbContext _dataDbContext;

        public HomeController(DataDbContext dataDbContext)
        {
            _dataDbContext = dataDbContext;
        }


        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()

        {
            //ViewBag.Message = "Login";
            return View();
        }
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
        public IActionResult store()
        {
            return View();
        }
        public IActionResult login()
        {
            return View();
        }

        public IActionResult register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> register(Login login)
        {
            //if(username == "Abc" && password == "123")
            //{
              //  ViewBag.message = "Done";
            //}
            //else
            //{
              //  ViewBag.message = "Failed";
            //}
            await _dataDbContext.AddAsync(login);
            await _dataDbContext.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}