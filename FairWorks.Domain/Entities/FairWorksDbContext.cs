using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairWorks.Domain.Entities
{
    public class FairWorksDbContext:DbContext
    {
        public DbSet<BiletliZiyaretci> BiletliZiyaretciler { get; set; }
        public DbSet<DavetiyesizZiyaretci> DavetiyesizZiyaretciler { get; set; }
        public DbSet<Doviz> Dovizler { get; set; }
        public DbSet<Firma> Firmalar { get; set; }
        public DbSet<FirmaTipi> FirmaTipleri { get; set; }
        public DbSet<FirmaTipveTemsilEdilenFirma> FirmaTipiveFirmalar { get; set; }
        public DbSet<GorusulenFirma> GorusulenFirmalar { get; set; }
        public DbSet<IlaveStandMalzemeler> İlaveStandMalzemeleri { get; set; }
        public DbSet<KatalogGirisForm> KatalogGirisFormlari { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<OdemePlani> OdemePlanlari { get; set; }
        public DbSet<Personel> Personeller { get; set; }
        public DbSet<PotansiyelFirma> PotansiyelFirmalar { get; set; }
        public DbSet<Salon> Salonlar { get; set; }
        public DbSet<SozlesmeBilgisi> SozlesmeBilgileri { get; set; }
        public DbSet<SozlesmeTipi> SozlesmeTipleri { get; set; }
        public DbSet<Stand> Standlar { get; set; }
        public DbSet<Tedarikci> Tedarikciler { get; set; }
        public DbSet<TeklifBilgisi> TeklifBilgileri { get; set; }
        public DbSet<TemsilEttigiFirma> TemsilEttigiFirmalar { get; set; }
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Ziyaretci> Ziyaretciler { get; set; }
        public DbSet<FirmaBilgi> FirmaBilgileri { get; set; }


        public FairWorksDbContext()
        {

        }

        public FairWorksDbContext(DbContextOptions<FairWorksDbContext> options):base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-Q51EAVI\SQLEXPRESS;Database=FairWorksDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region FirmaTipveFirma
            //TemsilEttigiFirma ve FirmaTipi arasında çoka çok ilişki yapıldı
            modelBuilder.Entity<FirmaTipveTemsilEdilenFirma>().HasKey(x => new { x.TemsilEttigiFirmaId, x.FirmaTipId });
            modelBuilder.Entity<FirmaTipveTemsilEdilenFirma>().HasOne(x => x.FirmaTipi).WithMany(x => x.TemsilEttigiFirmalar).HasForeignKey(x => x.TemsilEttigiFirmaId);
            modelBuilder.Entity<FirmaTipveTemsilEdilenFirma>().HasOne(x => x.TemsilEttigiFirma).WithMany(x => x.FirmaTipi).HasForeignKey(x => x.FirmaTipId);
            #endregion
            #region Kullanici
            modelBuilder.Entity<Kullanici>()
                .Property(x => x.UserName)
                .HasMaxLength(20)
                .IsRequired();


            modelBuilder.Entity<Kullanici>()
                .Property(x => x.Password)
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder.Entity<Kullanici>()
                .Property(x => x.Role)
                .HasMaxLength(20)
                .HasDefaultValue<string>("user");
            #endregion

        }
    }
}
