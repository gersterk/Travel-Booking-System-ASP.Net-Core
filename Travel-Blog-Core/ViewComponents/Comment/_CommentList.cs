using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
namespace Travel_Blog_Core.ViewComponents.Comment
{
    public class _CommentList : ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal());
        public IViewComponentResult Invoke(int id )
        {
            var values = commentManager.TGetDestinationById(id);
            return View(values);

        }
    }
}
