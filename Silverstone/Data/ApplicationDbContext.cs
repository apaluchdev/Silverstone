using Microsoft.EntityFrameworkCore;
using Silverstone.Models;

namespace Silverstone.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Category { get; set; }

        public DbSet<ApplicationType> ApplicationType { get; set; }
    }
}
