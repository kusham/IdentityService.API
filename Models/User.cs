using Microsoft.AspNetCore.Identity;

namespace IdentityService.Models
{
    public class User : IdentityUser
    {
        public string? Initials { get; set; }
    }
}
