using Microsoft.AspNetCore.Mvc;

namespace Travel_Blog_Core.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
