namespace TuckerAPIProject.Data
{
    using TuckerAPIProject.Dto;

    using Microsoft.EntityFrameworkCore;
    using TuckerAPIProject.Models;

    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbContext(DbContextOptions<DbContext> options) : base(options)
        {
        }

        public DbSet<AccountModel> Account { get; set; } = null!;

        public DbSet<DeliveryModel> Delivery { get; set; } = null!;

        public DbSet<PackageModel> Package { get; set; } = null!;

        public DbSet<TruckerInfoModel> TruckerInfo { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountModel>().ToTable("Account");
            modelBuilder.Entity<DeliveryModel>().ToTable("Delivery");
            modelBuilder.Entity<PackageModel>().ToTable("Package");
            modelBuilder.Entity<TruckerInfoModel>().ToTable("TuckerInfo");
        }
    }
}
