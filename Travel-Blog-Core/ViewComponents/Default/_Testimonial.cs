using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Travel_Blog_Core.ViewComponents.Default
{
    public class _Testimonial : ViewComponent
    {
        TestimonialManager testimonialManager = new TestimonialManager( new EfTestimonialDal());

        public IViewComponentResult Invoke()
        {
            var values = testimonialManager.TGetList();

            return View(values);  
        }
    }
}
