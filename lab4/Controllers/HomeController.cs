using System.Diagnostics;
using lab4.Models;
using Microsoft.AspNetCore.Mvc;

namespace lab4.Controllers
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
        public IActionResult form()
        {
            ViewData["title"] = "Customer Form";
            ViewData["message"] = "Please Fill Up The Form.";
            ViewData["times"] = "10";
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Display(string Name, string Contact, int Age, string Email)
        {
            ViewData["Name"] = Name;
            ViewData["Contact"] = Contact;
            ViewData["Age"] = Age;
            ViewData["Email"] = Email;

            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
