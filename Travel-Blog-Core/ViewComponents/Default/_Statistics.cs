using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Travel_Blog_Core.ViewComponents.Default
{
    //popular destinations statistics Component
    public class _Statistics  :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            //routes count
            using var c = new Context();
            ViewBag.v1 = c.Destinations.Count();

            
            ViewBag.v2 = c.Guides.Count();

            ViewBag.v3 = "285";


            return View();

        }
    }
}
