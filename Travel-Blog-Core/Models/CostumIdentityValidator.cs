using Microsoft.AspNetCore.Identity;

namespace Travel_Blog_Core.Models
{
    public class CostumIdentityValidator : Microsoft.AspNetCore.Identity.IdentityErrorDescriber

    {
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError()
            {
                Code = "PasswordTooShort",
                Description = $"Password must be minimum {length}"
            };
        }

        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresUpper",
                Description = $"Password must include at least one capital letter."
            };
        }


    }

}
