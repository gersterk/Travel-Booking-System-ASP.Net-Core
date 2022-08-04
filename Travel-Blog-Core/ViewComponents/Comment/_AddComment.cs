using Microsoft.AspNetCore.Mvc;

namespace Travel_Blog_Core.ViewComponents.Comment
{
    public class _AddComment : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();

        }
    }
}
