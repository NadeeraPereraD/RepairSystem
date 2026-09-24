using LaptopRepairSystem.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace LaptopRepairSystem.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Company> Companies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Company>(entity =>
            {
                entity.ToTable("Companies");

                entity.HasKey(x => x.CompanyId);

                entity.Property(x => x.CompanyName)
                    .HasMaxLength(200)
                    .IsRequired();

                entity.Property(x => x.AddressLine1)
                    .HasMaxLength(250)
                    .IsRequired();

                entity.Property(x => x.AddressLine2)
                    .HasMaxLength(250);

                entity.Property(x => x.City)
                    .HasMaxLength(100)
                    .IsRequired();

                entity.Property(x => x.PostalCode)
                    .HasMaxLength(20);

                entity.Property(x => x.Province)
                    .HasMaxLength(100)
                    .IsRequired();

                entity.Property(x => x.OwnerFirstName)
                    .HasMaxLength(100)
                    .IsRequired();

                entity.Property(x => x.OwnerLastName)
                    .HasMaxLength(100)
                    .IsRequired();

                entity.Property(x => x.Email)
                    .HasMaxLength(150)
                    .IsRequired();

                entity.Property(x => x.Telephone)
                    .HasMaxLength(20);

                entity.Property(x => x.Mobile)
                    .HasMaxLength(20)
                    .IsRequired();

                entity.Property(x => x.LogoPath)
                    .HasMaxLength(500);

                entity.Property(x => x.CreatedDate)
                    .HasDefaultValueSql("SYSDATETIME()");
            });
        }
    }
}