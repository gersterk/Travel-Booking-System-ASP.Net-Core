using Microsoft.AspNetCore.Mvc;

namespace Travel_Blog_Core.Areas.Member.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
