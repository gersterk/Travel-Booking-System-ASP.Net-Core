﻿using Microsoft.AspNetCore.Mvc;

namespace Travel_Blog_Core.Areas.Member
{
    public class CommentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
