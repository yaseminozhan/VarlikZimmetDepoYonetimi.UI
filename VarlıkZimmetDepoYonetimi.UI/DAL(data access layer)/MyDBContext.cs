using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VarlıkZimmetDepoYonetimi.UI.Entities
{
    public class MyDBContext :DbContext
    {
        public DbSet<BarkodsuzUrun> BarkodsuzUrunler { get; set; }
        public DbSet<BarkodluUrun> BarkodluUrunler { get; set; }

        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Depo> Depolar { get; set; }
        public DbSet<Zimmet> Zimmetler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=JASMINE\\SQLEXPRESS;Database=VarlikZimmetDepo;Trusted_Connection=True;TrustServerCertificate=True;");
        }

    }
}
