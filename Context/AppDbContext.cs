using Microsoft.EntityFrameworkCore;

namespace Pet_project.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
