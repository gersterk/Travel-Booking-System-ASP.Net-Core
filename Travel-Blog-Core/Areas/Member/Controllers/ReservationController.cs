using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Travel_Blog_Core.Areas.Member.Controllers
{
    [Area("Member")]
    public class ReservationController : Controller
    {
        public IActionResult MyCurrentReservation()
        {
            return View();

        }

        public IActionResult MyPreviousResevertaion()
        {
            return View();

        }

        [HttpGet]
        public IActionResult NewReservation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewReservation(Reservation p)
        {
            return View();
        }
    }
}
