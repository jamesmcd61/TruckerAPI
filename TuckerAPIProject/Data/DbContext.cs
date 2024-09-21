namespace TuckerAPIProject.Data
{
    using TuckerAPIProject.Dto;

    using Microsoft.EntityFrameworkCore;

    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbContext() { }

        public DbSet<AccountDto> Account { get; set; } = null!;

        public DbSet<DeliveryDto> Delivery { get; set; } = null!;

        public DbSet<PackageDto> Package { get; set; } = null!;

        public DbSet<TruckerInfoDto> TruckerInfo { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountDto>().ToTable("Account");
            modelBuilder.Entity<DeliveryDto>().ToTable("Delivery");
            modelBuilder.Entity<PackageDto>().ToTable("Package");
            modelBuilder.Entity<TruckerInfoDto>().ToTable("TuckerInfo");
        }
    }
}
