using J.Calculator.Models;
using Microsoft.EntityFrameworkCore;

namespace J.Calculator.Data
{
    public class CalculatorDbContext : DbContext
    {
        public CalculatorDbContext(DbContextOptions<CalculatorDbContext> options) : base(options)
        {
        }
        
        public DbSet<Container> Containers { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Charge> Charges { get; set; }

    }
}