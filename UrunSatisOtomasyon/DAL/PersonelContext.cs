using UrunSatisOtomasyon.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UrunSatisOtomasyon.DAL
{
    public class PersonelContext : DbContext
    {
        public PersonelContext() : base("cstr")
        {

        }

        public DbSet<Personel> Personeler { get; set; }
        public DbSet<Urun> Urunler { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Personel>().ToTable("tblPersonel");
            modelBuilder.Entity<Personel>().Property(p => p.Ad).HasColumnType("varchar").HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Personel>().Property(p => p.Soyad).HasColumnType("varchar").HasMaxLength(75).IsRequired();
            modelBuilder.Entity<Personel>().Property(p => p.Tc).HasColumnType("varchar").HasMaxLength(75).IsRequired();
            modelBuilder.Entity<Personel>().Property(p => p.Numara).HasColumnType("varchar").HasMaxLength(75).IsRequired();
            modelBuilder.Entity<Urun>().ToTable("tblUrun");
            modelBuilder.Entity<Urun>().Property(p => p.UrunMarka).HasColumnType("varchar").HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Urun>().Property(p => p.UrunModel).HasColumnType("varchar").HasMaxLength(75).IsRequired();
            modelBuilder.Entity<Urun>().Property(p => p.UrunKategori).HasColumnType("varchar").HasMaxLength(75).IsRequired();
            modelBuilder.Entity<Urun>().Property(p => p.UrunFiyat).HasColumnType("int").IsRequired();
            modelBuilder.Entity<Urun>().Property(p => p.UrunKod).HasColumnType("varchar").HasMaxLength(75).IsRequired();
        }
    }
}