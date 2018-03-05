using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ScaffoldSample
{
    public partial class OwnedEntitiesContext : DbContext
    {
        public virtual DbSet<Addr> Addr { get; set; }
        public virtual DbSet<People> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"server=(localdb)\mssqllocaldb;trusted_connection=true;database=OwnedEntities");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Addr>(entity =>
            {
                entity.HasKey(e => e.PersonId);

                entity.Property(e => e.PersonId).ValueGeneratedNever();

                entity.Property(e => e.LocationCity).HasColumnName("Location_City");

                entity.Property(e => e.LocationCountry).HasColumnName("Location_Country");

                entity.HasOne(d => d.Person)
                    .WithOne(p => p.Addr)
                    .HasForeignKey<Addr>(d => d.PersonId);
            });

            modelBuilder.Entity<People>(entity =>
            {
                entity.HasKey(e => e.PersonId);

                entity.Property(e => e.CompanyAddressLineOne).HasColumnName("CompanyAddress_LineOne");

                entity.Property(e => e.CompanyAddressLineTwo).HasColumnName("CompanyAddress_LineTwo");
            });
        }
    }
}
