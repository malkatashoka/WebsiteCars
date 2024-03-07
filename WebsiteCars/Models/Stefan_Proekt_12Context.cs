using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebsiteCars.Models
{
    public partial class Stefan_Proekt_12Context : DbContext
    {
        public Stefan_Proekt_12Context()
        {
        }

        public Stefan_Proekt_12Context(DbContextOptions<Stefan_Proekt_12Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Cars> Cars { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<Engines> Engines { get; set; }
        public virtual DbSet<Purchases> Purchases { get; set; }
        public virtual DbSet<Sales> Sales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=MINIPC-8250-20H\\SQLEXPRESS01;Database=Stefan_Proekt_№12;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cars>(entity =>
            {
                entity.ToTable("CARS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Brand)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Color)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EngineId).HasColumnName("EngineID");

                entity.Property(e => e.Model)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Category_Cars");

                entity.HasOne(d => d.Engine)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.EngineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Engine_Cars");
            });

            modelBuilder.Entity<Categories>(entity =>
            {
                entity.ToTable("CATEGORIES");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Category)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Clients>(entity =>
            {
                entity.ToTable("CLIENTS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Gsm)
                    .HasColumnName("GSM")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Engines>(entity =>
            {
                entity.ToTable("ENGINES");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Engine)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Purchases>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PURCHASES");

                entity.Property(e => e.Brand)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(61)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("money");
            });

            modelBuilder.Entity<Sales>(entity =>
            {
                entity.ToTable("SALES");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CarsId).HasColumnName("CarsID");

                entity.Property(e => e.ClientsId).HasColumnName("ClientsID");

                entity.Property(e => e.SaleDate).HasColumnType("date");

                entity.HasOne(d => d.Cars)
                    .WithMany(p => p.Sales)
                    .HasForeignKey(d => d.CarsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sales_Cars1");

                entity.HasOne(d => d.Clients)
                    .WithMany(p => p.Sales)
                    .HasForeignKey(d => d.ClientsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sales_Cars2");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
