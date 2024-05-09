using Microsoft.EntityFrameworkCore;
using BackendWebsite.Models;

namespace WebsiteContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {
        }

        public DbSet<Comment> Comments
        {
            get; set;
        }
    }
}
