using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Surveyor.UI.Data.Surveyor;

public class UIContext : IdentityDbContext<IdentityUser>
{
    public UIContext(DbContextOptions<UIContext> options)
        : base(options)
    {
    }
}
