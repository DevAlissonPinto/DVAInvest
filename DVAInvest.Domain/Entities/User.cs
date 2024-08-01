using Microsoft.AspNetCore.Identity;

namespace DVAInvest.Domain.Entities;

public class User : IdentityUser<long>
{
    public List<IdentityRole<long>>? Roles { get; set; }
}
