using Microsoft.AspNetCore.Identity;

namespace citizensof.se.Models
{
    public class User : IdentityUser
    {
        public string StreetNumber { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
    }
}
