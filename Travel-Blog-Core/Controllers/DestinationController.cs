using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Travel_Blog_Core.Controllers
{
    public class DestinationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());

        public IActionResult Index()
        {
            var values = destinationManager.TGetList();

            return View(values);
        }

        public IActionResult DestinationDetails(int id)
        {
            return View();

        }
        [HttpPost]
        public IActionResult DestinationDetails(Destination p)
        {
            return View();

        }
    }
}
