using Microsoft.AspNetCore.Http;

namespace Travel_Blog_Core.Areas.Member.Models
{
    public class UserEditView
    {
        public string name { get; set; }
        public string surname { get; set; }   
        public string password { get; set; }   
        public string confirmpassword { get; set; }   
        public string imageurl { get; set; }   
        public string phonenumber { get; set; }   
        public string mail { get; set; }
        public IFormFile Image { get; set; }
    }
}
