using System.ComponentModel.DataAnnotations;

namespace Travel_Blog_Core.Models
{
    public class UserSignInModel
    {
        [Required(ErrorMessage = "Please input your username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please input your password")]
        public string Password { get; set; }

     
    }
}
