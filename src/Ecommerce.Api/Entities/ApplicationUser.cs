using Microsoft.AspNetCore.Identity;

namespace Ecommerce.Api.Entities;

public class ApplicationUser : IdentityUser
{
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
}
