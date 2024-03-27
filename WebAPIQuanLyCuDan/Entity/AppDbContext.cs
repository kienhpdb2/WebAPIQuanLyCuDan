using Microsoft.EntityFrameworkCore;
using WebAPIQuanLyCuDan.Models;

namespace WebAPIQuanLyCuDan.Entity
{
    public class AppDbContext : DbContext
    {
        /*    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=EFCore-SchoolDB;Trusted_Connection=True");
            }
    */
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TenantApartment>().HasKey(ta => new { ta.tenant_id, ta.apartment_id });

            modelBuilder.Entity<TenantApartment>()
                .HasOne(ta => ta.tenant)
                .WithMany(t => t.tenant_apartments)
                .HasForeignKey(ta => ta.tenant_id);


            modelBuilder.Entity<TenantApartment>()
                .HasOne(ta => ta.apartment)
                .WithMany(t => t.tenant_apartments)
                .HasForeignKey(ta => ta.apartment_id);
        }

        public DbSet<Tenant> tenants { get; set; }
        public DbSet<Apartment> apartments { get; set; }
        public DbSet<TenantApartment> tenant_apartments { get; set; }
    }
}
