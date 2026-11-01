namespace Ecommerce.Api.Entities;

public class ApplicationUser
{
    public int Id { get; set; }
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
}
