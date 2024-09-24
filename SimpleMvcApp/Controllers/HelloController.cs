using Microsoft.AspNetCore.Mvc;

namespace SimpleMvcApp.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return Content("Hello, World!");
        }
    }
}
