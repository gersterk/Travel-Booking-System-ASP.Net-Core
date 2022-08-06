using System.ComponentModel.DataAnnotations;

namespace Travel_Blog_Core.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Please Insert Your Name")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Please Insert Your Surname")]
        public string Surname { get; set; }


        [Required(ErrorMessage = "Please Insert Your Email Address")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Please Insert a Username")]
        public string Username { get; set; }


        [Required(ErrorMessage = "Please Insert a Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please Confirm Your Password")]
        [Compare("Password", ErrorMessage = "Passwords are not same")]
        public string ConfirmPassword { get; set; }
    }
        
}
