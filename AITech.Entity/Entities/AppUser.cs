using Microsoft.AspNetCore.Identity;

namespace AITech.Entity.Entities
{
    public class AppUser : IdentityUser<int>
    {
        public string NameSurname { get; set; }
    }
}
