using Ecommerce.Api.Entities;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Ecommerce.Api;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
}
