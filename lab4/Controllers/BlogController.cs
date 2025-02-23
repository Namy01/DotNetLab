using Microsoft.AspNetCore.Mvc;

namespace lab4.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
    }
}
