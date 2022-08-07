using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Travel_Blog_Core.Areas.Member
{
    [AllowAnonymous]
    public class DestinationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());

        
        [Area("Member")]
        public IActionResult Index()
        {
            var values = destinationManager.TGetList();

            return View(values);
            
        }
    }
}
