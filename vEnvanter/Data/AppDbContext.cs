using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vEnvanter.Modeller;

namespace vEnvanter.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Ürünler> Ürünler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Properties.Resources.ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kategori>()
                .HasData(
                new Kategori { KategoriID = 1, KategoriAdi = "Elektronik" },
                new Kategori { KategoriID = 2, KategoriAdi = "Giyim" },
                new Kategori { KategoriID = 3, KategoriAdi = "Ev Eşyaları" }
            );
        }
    }
}
