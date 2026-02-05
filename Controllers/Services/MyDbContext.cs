using Microsoft.EntityFrameworkCore;

namespace FinanceWeb.Controllers.Services
{
    public class MyDbContext : DbContext
    {
        internal object Budgets;

        // Add constructors and/or DbSet<TEntity> properties as needed
        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        // Example DbSet property:
        // public DbSet<YourEntity> YourEntities { get; set; }
    }
}