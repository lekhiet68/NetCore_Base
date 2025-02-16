using Microsoft.EntityFrameworkCore;

namespace Web_MVC_EFB4.Domain
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options): base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
