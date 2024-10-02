using Microsoft.EntityFrameworkCore;

namespace LMS.api.Models
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Users> Users { get; set; }
    }
}
