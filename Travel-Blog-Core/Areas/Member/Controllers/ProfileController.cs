using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
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
    }
}
