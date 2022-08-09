using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Travel_Blog_Core.ViewComponents.MemberDashboard
{
    public class _ProfileInformation : ViewComponent
    {
        private readonly UserManager<AppUser>_userManager;

        public _ProfileInformation(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task <IViewComponentResult> InvokeAsync() //That didnt work with Invoke IDK why... Should check on it...
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.memberName = values.UserName + " " + values.Surname;
            ViewBag.memberPhone = values.PhoneNumber;
            ViewBag.memberEmail = values.Email;

            return View();

        }
        

    }
   



}
