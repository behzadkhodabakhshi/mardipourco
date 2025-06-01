
using Maripour.EndPoint.Entities.Product;
using Microsoft.EntityFrameworkCore;

namespace EndPoint.Context
{
    public class MardipourDbContext:DbContext
    {
        public MardipourDbContext(DbContextOptions<MardipourDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

    }
}
