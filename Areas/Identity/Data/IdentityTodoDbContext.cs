using Microsoft.EntityFrameworkCore;

namespace Microsoft.AspNetCore.Identity.EntityFrameworkCore;

public class IdentityTodoDbContext : IdentityDbContext<IdentityUser>
{
    public IdentityTodoDbContext(DbContextOptions<IdentityTodoDbContext> options)
        : base(options)
    {
    }

    public IdentityTodoDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
