using Microsoft.EntityFrameworkCore;
using Website.Models;

namespace WebsiteContext
{
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Comment> Comments { get; set; }
}
}
