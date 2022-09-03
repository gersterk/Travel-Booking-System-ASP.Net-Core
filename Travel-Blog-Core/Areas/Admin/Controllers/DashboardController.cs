using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Travel_Blog_Core.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
    }
}
