using Microsoft.AspNetCore.Identity;

namespace API.Entities;

public class AppUserRole : IdentityUserRole<int>
{
    // navigation properties in EF need to be initialised to null so
    // use the null forgiving operator for these
    public AppUser User { get; set; } = null!;
    public AppRole Role { get; set; } = null!;
}
