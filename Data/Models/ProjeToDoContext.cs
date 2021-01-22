using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Data.Models
{
    public partial class ProjeToDoContext : DbContext
    {
        public ProjeToDoContext()
        {
        }

        public ProjeToDoContext(DbContextOptions<ProjeToDoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Kategoriler> Kategorilers { get; set; }
        public virtual DbSet<Kullanici> Kullanicis { get; set; }
        public virtual DbSet<Musteriler> Musterilers { get; set; }
        public virtual DbSet<Urunler> Urunlers { get; set; }
        public List<Musteriler> Data { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=TK\\SQLEXPRESS;Database=ProjeToDo;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CI_AS");

            modelBuilder.Entity<Kategoriler>(entity =>
            {
                entity.HasKey(e => e.KategoriId);

                entity.ToTable("Kategoriler");

                entity.Property(e => e.KategoriAd).HasMaxLength(50);
            });

            modelBuilder.Entity<Kullanici>(entity =>
            {
                entity.ToTable("Kullanici");

                entity.Property(e => e.KullaniciAd).HasMaxLength(50);

                entity.Property(e => e.KullaniciSifre).HasMaxLength(50);

                entity.Property(e => e.KullaniciSoyad).HasMaxLength(50);
            });

            modelBuilder.Entity<Musteriler>(entity =>
            {
                entity.ToTable("Musteriler");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Soyad).HasMaxLength(50);
            });

            modelBuilder.Entity<Urunler>(entity =>
            {
                entity.HasKey(e => e.UrunId);

                entity.ToTable("Urunler");

                entity.Property(e => e.UrunMarka).HasMaxLength(50);

                entity.Property(e => e.Urunad).HasMaxLength(50);

                entity.HasOne(d => d.UrunKategoriNavigation)
                    .WithMany(p => p.Urunlers)
                    .HasForeignKey(d => d.UrunKategori)
                    .HasConstraintName("FK_Urunler_Kategoriler");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
