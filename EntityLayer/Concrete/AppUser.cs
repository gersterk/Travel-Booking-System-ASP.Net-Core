using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    
    public class AppUser :IdentityUser<int> //AppUser with AppRole, Claims, Tokens eg comes as a fruit of Identity library
    {
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        //public string Password { get; set; } //forgotten and then added...
        public List<Reservation> Reservations { get; set; }
        //relates with Reservation class's entities
    }
}
