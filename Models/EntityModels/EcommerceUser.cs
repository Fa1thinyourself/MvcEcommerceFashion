using Microsoft.AspNetCore.Identity;

namespace MvcEcommerceFashion.Models.EntityModels;

public class EcommerceUser : IdentityUser
{
  [PersonalData]
  public string? Name { get; set; }
  [PersonalData]
  public string? Address { get; set; }
  [PersonalData]
  public string? AvatarUrl { get; set; }
}
