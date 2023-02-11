using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MechanicWebService.Data
{
    public class AppDbContext:IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Models.Car> Cars { get; set; } = default!;
        public DbSet<Models.Customer> Customers { get; set; } = default!;
        public DbSet<Models.Mechanic> Mechanics { get; set; } = default!;
        public DbSet<Models.Payment> Payments { get; set; } = default!;
        public DbSet<Models.Reservation> Reservations { get; set; } = default!;
        public DbSet<Models.Service> Services { get; set; } = default!;

    }
}
