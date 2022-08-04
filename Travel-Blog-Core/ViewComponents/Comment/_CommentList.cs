using Microsoft.AspNetCore.Mvc;

namespace Travel_Blog_Core.ViewComponents.Comment
{
    public class _CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();

        }
    }
}
