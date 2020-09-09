using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EntityFrameworkDBFirst_Demo1.Entities
{
    public partial class DiscountPricingContext : DbContext
    {
        public DiscountPricingContext()
        {
        }

        public DiscountPricingContext(DbContextOptions<DiscountPricingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblExclusions> TblExclusions { get; set; }
       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=SANTU\\MSSQLSERVER2019;Initial Catalog=DiscountPricing;User ID=sa;Password=pass@word1");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblExclusions>(entity =>
            {
                entity.HasKey(e => e.IntExclusionsId);

                entity.ToTable("tblExclusions");

                entity.Property(e => e.IntExclusionsId)
                    .HasColumnName("intExclusionsID")
                    .HasComment("Exclusion Key");

                entity.Property(e => e.DtmCreated)
                    .HasColumnName("dtmCreated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Created Date");

                entity.Property(e => e.DtmUpdated)
                    .HasColumnName("dtmUpdated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Updated Date");

                entity.Property(e => e.StrContractCode)
                    .IsRequired()
                    .HasColumnName("strContractCode")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("Contract Code");

                entity.Property(e => e.StrDrugNdc)
                    .IsRequired()
                    .HasColumnName("strDrugNDC")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasComment("NDC");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())")
                    .HasComment("Author");
            });

          

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
