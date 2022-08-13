using Microsoft.EntityFrameworkCore;

namespace Hotel.API.Entities
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> opt) : base(opt)
        {

        }

        public DbSet<Hotel> Hotels { get; set; }
    }
}
