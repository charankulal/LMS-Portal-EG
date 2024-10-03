using Microsoft.EntityFrameworkCore;

namespace LMS.api.Models
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {

        }
        
        // Following code first approach

        public DbSet<Users> Users { get; set; }

        public DbSet<Batches> Batches { get; set; }

        public DbSet<Certificates> Certificates { get; set; }

        public DbSet<Sprints> Sprints { get; set; }

        public DbSet<Contents> Contents { get; set; }   
    }
}
