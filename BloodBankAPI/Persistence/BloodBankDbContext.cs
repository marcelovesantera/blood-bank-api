using BloodBank.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BloodBankAPI.Persistence
{
    public class BloodBankDbContext : DbContext
    {
        public BloodBankDbContext(DbContextOptions<BloodBankDbContext> options) : base(options)
        {
            
        }

        public DbSet<Donor> Donors { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Donation> Donations { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Donor>(e =>
            {
                e.HasKey(d => d.Id);
                e.Property(d => d.Id)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("NEWSEQUENTIALID()");
                
                e.HasOne(d => d.Address)
                    .WithOne(a => a.Donor)
                    .HasForeignKey<Address>(a => a.DonorId)
                    .OnDelete(DeleteBehavior.Restrict); 

                e.HasMany(d => d.Donations)
                    .WithOne(d => d.Donor)
                    .HasForeignKey(d => d.DonorId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            mb.Entity<Address>(e =>
            {
                e.HasKey(a => a.Id);
                e.Property(a => a.Id)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("NEWSEQUENTIALID()");
            });

            mb.Entity<Donation>(e =>
            {
                e.HasKey(d => d.Id);
                e.Property(d => d.Id)
                    .ValueGeneratedOnAdd()
                    .HasDefaultValueSql("NEWSEQUENTIALID()");
            });

            base.OnModelCreating(mb);
        }
    }
}
