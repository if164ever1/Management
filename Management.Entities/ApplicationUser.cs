using Microsoft.AspNetCore.Identity;


namespace Management.Entities
{
    public class ApplicationUser:IdentityUser
    {
        public required string Name { get; set; }
        public required string Avatar { get; set; }
    }
}
