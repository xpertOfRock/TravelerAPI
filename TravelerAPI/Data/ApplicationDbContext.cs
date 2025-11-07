using Microsoft.EntityFrameworkCore;
using System;
using TravelerAPI.Data.EntityConfigurations;

namespace TravelerAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<TravelPlan> TravelPlans => Set<TravelPlan>();
        public DbSet<Location> Locations => Set<Location>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new LocationConfiguration());
            modelBuilder.ApplyConfiguration(new TravelPlanConfiguration());
        }
    }
}
