using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Travel_Blog_Core.ViewComponents.Comment
{
    public class _AddComment : ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal());

        [HttpGet]
        public IViewComponentResult Invoke()
        {
            
            return View();

        }

        [HttpPost]
        public IViewComponentResult Invoke(EntityLayer.Concrete.Comment p)
        {
            p.CommentDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.CommentState = true;

            commentManager.TAdd(p);

            return View();        
        }


        //InvalidOperationException must have exactly one public method named 'InvokeAsync' or 'Invoke'.
        //I will Solve here with using <AJAX>... Dont ask me how, IDK yet LMAO
    }

}
