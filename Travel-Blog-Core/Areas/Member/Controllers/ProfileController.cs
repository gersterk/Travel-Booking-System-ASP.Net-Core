using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;
using Travel_Blog_Core.Areas.Member.Models;

namespace Travel_Blog_Core.Areas.Member.Controllers
{
    [AllowAnonymous]
    [Area("Member")]
    [Route("Member/[Controller]/[Action]")]
    
    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public object UserEditViewModel { get; private set; }

        [HttpGet]
        public async Task <IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditView userEditView = new UserEditView();
            userEditView.name= values.Name;
            userEditView.surname= values.Surname;
            userEditView.phonenumber= values.PhoneNumber;
            userEditView.mail= values.Email;


            return View(userEditView);
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserEditView p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if(p.Image != null)
            {
                var resourse = Directory.GetCurrentDirectory();
                var extensions = Path.GetExtension(p.Image.FileName);
                var imagename = Guid.NewGuid() + extensions;
                var savelocation= resourse +"/wwwroot/userimages/" + imagename;
                var stream = new FileStream(savelocation, FileMode.Create);
                await p.Image.CopyToAsync(stream);
                user.ImageUrl = imagename;

            }
            user.Name = p.name;
            user.Surname = p.surname;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.password);
            var result = await _userManager.UpdateAsync(user);

            if (result.Succeeded)
            {
                return RedirectToAction("SingIn", "Login");
            }
            return View();

        }
    }
}
