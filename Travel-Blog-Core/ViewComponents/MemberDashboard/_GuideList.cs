using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Travel_Blog_Core.ViewComponents.MemberDashboard
{
    public class _GuideList : ViewComponent
    {
        GuideManager guideManager = new GuideManager(new EfGuideDal());

        public IViewComponentResult Invoke()
        {
            var values = guideManager.TGetList();
            return View(values);
        }
    }
}
