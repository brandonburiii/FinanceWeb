using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FinanceWeb.Models;

namespace FinanceWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<FinanceWeb.Models.Budget> Budget { get; set; } = default!;
        public DbSet<FinanceWeb.Models.Category> Category { get; set; } = default!;
        public DbSet<FinanceWeb.Models.User> User { get; set; } = default!;
        public DbSet<FinanceWeb.Models.Transaction> Transaction { get; set; } = default!;
    }
}
