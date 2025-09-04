using Microsoft.EntityFrameworkCore;

namespace EFCoreConfig
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }
        public DbSet<User> User { get; set; }
    }
}
