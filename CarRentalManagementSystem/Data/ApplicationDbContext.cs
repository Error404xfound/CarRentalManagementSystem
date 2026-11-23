using CarRentalManagementSystem.Configurations.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarRentalManagementSystem.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<CarRentalManagementSystem.Domain.Booking> Booking { get; set; } = default!;
        public DbSet<CarRentalManagementSystem.Domain.Customer> Customer { get; set; } = default!;
        public DbSet<CarRentalManagementSystem.Domain.Colour> Colour { get; set; } = default!;
        public DbSet<CarRentalManagementSystem.Domain.Model> Model { get; set; } = default!;
        public DbSet<CarRentalManagementSystem.Domain.Vehicle> Vehicle { get; set; } = default!;
        public DbSet<CarRentalManagementSystem.Domain.Make> Make { get; set; } = default!;
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new MakeSeed());
            builder.ApplyConfiguration(new ModelSeed());
            builder.ApplyConfiguration(new ColourSeed());
        }
    }
}
