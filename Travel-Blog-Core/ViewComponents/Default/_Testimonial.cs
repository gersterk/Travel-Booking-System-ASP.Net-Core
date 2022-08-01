using Microsoft.AspNetCore.Mvc;

namespace Travel_Blog_Core.ViewComponents.Default
{
    public class _Testimonial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}
