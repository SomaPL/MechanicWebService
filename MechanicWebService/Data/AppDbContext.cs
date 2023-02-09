using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace MechanicWebService.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Models.Car> Cars { get; set; } = default!;
        public DbSet<Models.Customer> Customers { get; set; } = default!;
        public DbSet<Models.Mechanic> Mechanics { get; set; } = default!;
        public DbSet<Models.Order> Orders { get; set; } = default!;

    }
}
