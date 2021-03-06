// <auto-generated />
using System;
using FairWorks.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FairWorks.Domain.Migrations
{
    [DbContext(typeof(FairWorksDbContext))]
    [Migration("20220529154419_entitesgüncellemesi")]
    partial class entitesgüncellemesi
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FairWorks.Domain.Entities.BiletliZiyaretci", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Eposta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Faks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirmaAdı")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Meslek")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoyAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BiletliZiyaretciler");
                });

            modelBuilder.Entity("FairWorks.Domain.Entities.DavetiyesizZiyaretci", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FirmaId")
                        .HasColumnType("int");

                    b.Property<string>("Meslek")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoyAd")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FirmaId");

                    b.ToTable("DavetiyesizZiyaretciler");
                });

            modelBuilder.Entity("FairWorks.Domain.Entities.Doviz", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DovizCinsi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("DovizKuru")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Dovizler");
                });

            modelBuilder.Entity("FairWorks.Domain.Entities.Firma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Eposta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Faks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirmaAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sehir")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ulke")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Firmalar");
                });

            modelBuilder.Entity("FairWorks.Domain.Entities.FirmaBilgi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FuarYetkilisi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VergiDairesi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VergiNumarası")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FirmaBilgileri");
                });

            modelBuilder.Entity("FairWorks.Domain.Entities.FirmaTipi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirmaTip")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FirmaTipleri");
                });

            modelBuilder.Entity("FairWorks.Domain.Entities.FirmaTipveTemsilEdilenFirma", b =>
                {
                    b.Property<int>("TemsilEttigiFirmaId")
                        .HasColumnType("int");

                    b.Property<int>("FirmaTipId")
                        .HasColumnType("int");

                    b.HasKey("TemsilEttigiFirmaId", "FirmaTipId");

                    b.HasIndex("FirmaTipId");

                    b.ToTable("FirmaTipiveFirmalar");
                });

            modelBuilder.Entity("FairWorks.Domain.Entities.GorusulenFirma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Eposta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FirmaId")
                        .HasColumnType("int");

                    b.Property<string>("FirmaninIlgilendigiFuar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirmaninIlgilendigiSalon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirmaninProfili")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirmanınCalıstıgıSektoru")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GorusmeNotlari")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("GorusmeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("GorusulenKisi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonelId")
                        .HasColumnType("int");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Unvanı")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FirmaId");

                    b.HasIndex("PersonelId");

                    b.ToTable("GorusulenFirmalar");
                });

            modelBuilder.Entity("FairWorks.Domain.Entities.IlaveStandMalzemeler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ElektrikKw")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Fiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("IlaveStandMalzemesi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MalzemeKodu")
                        .HasColumnType("int");

                    b.Property<string>("MalzemeleAdı")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ozellik")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("İlaveStandMalzemeleri");
                });

            modelBuilder.Entity("FairWorks.Domain.Entities.KatalogGirisForm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FirmaId")
                        .HasColumnType("int");

                    b.Property<int>("FirmaTipId")
                        .HasColumnType("int");

                    b.Property<int>("UrunId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FirmaId");

                    b.HasIndex("FirmaTipId");

                    b.HasIndex("UrunId");

                    b.ToTable("KatalogGirisFormlari");
                });

            modelBuilder.Entity("FairWorks.Domain.Entities.Kullanici", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("LoginDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Role")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasDefaultValue("user");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Kullanicilar");
                });

            modelBuilder.Entity("FairWorks.Domain.Entities.OdemePlani", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ay")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Faiz")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Taksit")
                        .HasColumnType("int");

                    b.Property<decimal>("VadeSayisi")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Yıl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("indirimOrani")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("m2")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("m2BirimFiyati")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("OdemePlanlari");
                });

            modelBuilder.Entity("FairWorks.Domain.Entities.Personel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Bolge")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Fotograf")
                        .HasColumnType("varbinary(max)");

                    b.Property<decimal>("Maas")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Notlar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RaporVerdigiKisi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sehir")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoyAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TcNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ulke")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Unvan")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personeller");
                });

            modelBuilder.Entity("FairWorks.Domain.Entities.PotansiyelFirma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DahiliTelefon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DirektTelefon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Faks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirmaAdı")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sehir")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sektor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ulke")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Unvani")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Yetkili")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PotansiyelFirmalar");
                });

            modelBuilder.Entity("FairWorks.Domain.Entities.Salon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SalonNo")
                        .HasColumnType("int");

                    b.Property<string>("Sehir")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SektorAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ulke")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("boy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("en")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("m2")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Salonlar");
                });

            modelBuilder.Entity("FairWorks.Domain.Entities.SozlesmeBilgisi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DovizCinsi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("DovizKuru")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("FirmaBilgileriId")
                        .HasColumnType("int");

                    b.Property<int?>("FirmaId")
                        .HasColumnType("int");

                    b.Property<bool>("ImzaliSozlesmeDurumu")
                        .HasColumnType("bit");

                    b.Property<int>("OdemePlaniId")
                        .HasColumnType("int");

                    b.Property<int>("PersonelId")
                        .HasColumnType("int");

                    b.Property<DateTime>("SozlesmeSonGecerlilikTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("SozlesmeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("SozlesmeTipiId")
                        .HasColumnType("int");

                    b.Property<int>("StandId")
                        .HasColumnType("int");

                    b.Property<int>("salonId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FirmaBilgileriId");

                    b.HasIndex("FirmaId");

                    b.HasIndex("OdemePlaniId");

                    b.HasIndex("PersonelId");

                    b.HasIndex("SozlesmeTipiId");

                    b.HasIndex("StandId");

                    b.HasIndex("salonId");

                    b.ToTable("SozlesmeBilgileri");
                });

            modelBuilder.Entity("FairWorks.Domain.Entities.SozlesmeTipi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SozlesmeTipleri")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SozlesmeTipleri");
                });

            modelBuilder.Entity("FairWorks.Domain.Entities.Stand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SalonId")
                        .HasColumnType("int");

                    b.Property<int>("StandKodu")
                        .HasColumnType("int");

                    b.Property<string>("StandTipi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SalonId");

                    b.ToTable("Standlar");
                });

            modelBuilder.Entity("FairWorks.Domain.Entities.Tedarikci", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Tedarikciler")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("İlaveStandMalzemeleriId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("İlaveStandMalzemeleriId");

                    b.ToTable("Tedarikciler");
                });

            modelBuilder.Entity("FairWorks.Domain.Entities.TeklifBilgisi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DovizId")
                        .HasColumnType("int");

                    b.Property<int>("OdemePlaniId")
                        .HasColumnType("int");

                    b.Property<int>("StandId")
                        .HasColumnType("int");

                    b.Property<DateTime>("TeklifTarihi")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TeklifVerilenm2")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("TeklifinSonGecerlilikTarihi")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("m2birimFiyatı")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("salonId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DovizId");

                    b.HasIndex("OdemePlaniId");

                    b.HasIndex("StandId");

                    b.HasIndex("salonId");

                    b.ToTable("TeklifBilgileri");
                });

            modelBuilder.Entity("FairWorks.Domain.Entities.TemsilEttigiFirma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IletisimBilgileri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TemsilEdilenFirma")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TemsilEdilenFirmaUrunleri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ulke")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TemsilEttigiFirmalar");
                });

            modelBuilder.Entity("FairWorks.Domain.Entities.Urun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Adet")
                        .HasColumnType("int");

                    b.Property<decimal>("Fiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UrunAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrunBilgileri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UrunKodu")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Urunler");
                });

            modelBuilder.Entity("FairWorks.Domain.Entities.Ziyaretci", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DahiliTelefon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DirektTelefon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FirmaId")
                        .HasColumnType("int");

                    b.Property<string>("Sektor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Unvani")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Yetkili")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FirmaId");

                    b.ToTable("Ziyaretciler");
                });

            modelBuilder.Entity("FairWorks.Domain.Entities.DavetiyesizZiyaretci", b =>
                {
                    b.HasOne("FairWorks.Domain.Entities.Firma", "Firma")
                        .WithMany("DavetiyesizZiyaretciler")
                        .HasForeignKey("FirmaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Firma");
                });

            modelBuilder.Entity("FairWorks.Domain.Entities.FirmaTipveTemsilEdilenFirma", b =>
                {
                    b.HasOne("FairWorks.Domain.Entities.TemsilEttigiFirma", "TemsilEttigiFirma")
                        .WithMany("FirmaTipi")
                        .HasForeignKey("FirmaTipId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FairWorks.Domain.Entities.FirmaTipi", "FirmaTipi")
                        .WithMany("TemsilEttigiFirmalar")
                        .HasForeignKey("TemsilEttigiFirmaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FirmaTipi");

                    b.Navigation("TemsilEttigiFirma");
                });

            modelBuilder.Entity("FairWorks.Domain.Entities.GorusulenFirma", b =>
                {
                    b.HasOne("FairWorks.Domain.Entities.Firma", null)
                        .WithMany("GorusulenFirmalar")
                        .HasForeignKey("FirmaId");

                    b.HasOne("FairWorks.Domain.Entities.Personel", "PersonelAdı")
                        .WithMany("GorusulenFirmalar")
                        .HasForeignKey("PersonelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PersonelAdı");
                });

            modelBuilder.Entity("FairWorks.Domain.Entities.KatalogGirisForm", b =>
                {
                    b.HasOne("FairWorks.Domain.Entities.Firma", "Firma")
                        .WithMany()
                        .HasForeignKey("FirmaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FairWorks.Domain.Entities.FirmaTipi", "FirmaTip")
                        .WithMany()
                        .HasForeignKey("FirmaTipId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FairWorks.Domain.Entities.Urun", "UrunGrupları")
                        .WithMany("KatalogGirisForm")
                        .HasForeignKey("UrunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Firma");

                    b.Navigation("FirmaTip");

                    b.Navigation("UrunGrupları");
                });

            modelBuilder.Entity("FairWorks.Domain.Entities.SozlesmeBilgisi", b =>
                {
                    b.HasOne("FairWorks.Domain.Entities.FirmaBilgi", "FirmaBilgileri")
                        .WithMany("SozlesmeBilgisi")
                        .HasForeignKey("FirmaBilgileriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FairWorks.Domain.Entities.Firma", null)
                        .WithMany("SozlesmeBilgileri")
                        .HasForeignKey("FirmaId");

                    b.HasOne("FairWorks.Domain.Entities.OdemePlani", "OdemePlani")
                        .WithMany("SozlesmeBilgileri")
                        .HasForeignKey("OdemePlaniId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FairWorks.Domain.Entities.Personel", "PersonelAdi")
                        .WithMany("SozlesmeBilgileri")
                        .HasForeignKey("PersonelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FairWorks.Domain.Entities.SozlesmeTipi", "SozlesmeTipleri")
                        .WithMany("SozlesmeBilgileri")
                        .HasForeignKey("SozlesmeTipiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FairWorks.Domain.Entities.Stand", "Stand")
                        .WithMany("SozlesmeBilgileri")
                        .HasForeignKey("StandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FairWorks.Domain.Entities.Salon", "Salon")
                        .WithMany("SozlesmeliMusteriler")
                        .HasForeignKey("salonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FirmaBilgileri");

                    b.Navigation("OdemePlani");

                    b.Navigation("PersonelAdi");

                    b.Navigation("Salon");

                    b.Navigation("SozlesmeTipleri");

                    b.Navigation("Stand");
                });

            modelBuilder.Entity("FairWorks.Domain.Entities.Stand", b =>
                {
                    b.HasOne("FairWorks.Domain.Entities.Salon", "Salonlar")
                        .WithMany("Standlar")
                        .HasForeignKey("SalonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Salonlar");
                });

            modelBuilder.Entity("FairWorks.Domain.Entities.Tedarikci", b =>
                {
                    b.HasOne("FairWorks.Domain.Entities.IlaveStandMalzemeler", "İlaveStandMalzemeleri")
                        .WithMany("Tedarikciler")
                        .HasForeignKey("İlaveStandMalzemeleriId");

                    b.Navigation("İlaveStandMalzemeleri");
                });

            modelBuilder.Entity("FairWorks.Domain.Entities.TeklifBilgisi", b =>
                {
                    b.HasOne("FairWorks.Domain.Entities.Doviz", "Doviz")
                        .WithMany("TeklifBilgileri")
                        .HasForeignKey("DovizId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FairWorks.Domain.Entities.OdemePlani", "OdemePlani")
                        .WithMany("TeklifBilgileri")
                        .HasForeignKey("OdemePlaniId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FairWorks.Domain.Entities.Stand", "Stand")
                        .WithMany("TeklifBilgileri")
                        .HasForeignKey("StandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FairWorks.Domain.Entities.Salon", "Salon")
                        .WithMany("TeklifBilgileri")
                        .HasForeignKey("salonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doviz");

                    b.Navigation("OdemePlani");

                    b.Navigation("Salon");

                    b.Navigation("Stand");
                });

            modelBuilder.Entity("FairWorks.Domain.Entities.Ziyaretci", b =>
                {
                    b.HasOne("FairWorks.Domain.Entities.Firma", "Firma")
                        .WithMany("Ziyaretciler")
                        .HasForeignKey("FirmaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Firma");
                });

            modelBuilder.Entity("FairWorks.Domain.Entities.Doviz", b =>
                {
                    b.Navigation("TeklifBilgileri");
                });

            modelBuilder.Entity("FairWorks.Domain.Entities.Firma", b =>
                {
                    b.Navigation("DavetiyesizZiyaretciler");

                    b.Navigation("GorusulenFirmalar");

                    b.Navigation("SozlesmeBilgileri");

                    b.Navigation("Ziyaretciler");
                });

            modelBuilder.Entity("FairWorks.Domain.Entities.FirmaBilgi", b =>
                {
                    b.Navigation("SozlesmeBilgisi");
                });

            modelBuilder.Entity("FairWorks.Domain.Entities.FirmaTipi", b =>
                {
                    b.Navigation("TemsilEttigiFirmalar");
                });

            modelBuilder.Entity("FairWorks.Domain.Entities.IlaveStandMalzemeler", b =>
                {
                    b.Navigation("Tedarikciler");
                });

            modelBuilder.Entity("FairWorks.Domain.Entities.OdemePlani", b =>
                {
                    b.Navigation("SozlesmeBilgileri");

                    b.Navigation("TeklifBilgileri");
                });

            modelBuilder.Entity("FairWorks.Domain.Entities.Personel", b =>
                {
                    b.Navigation("GorusulenFirmalar");

                    b.Navigation("SozlesmeBilgileri");
                });

            modelBuilder.Entity("FairWorks.Domain.Entities.Salon", b =>
                {
                    b.Navigation("SozlesmeliMusteriler");

                    b.Navigation("Standlar");

                    b.Navigation("TeklifBilgileri");
                });

            modelBuilder.Entity("FairWorks.Domain.Entities.SozlesmeTipi", b =>
                {
                    b.Navigation("SozlesmeBilgileri");
                });

            modelBuilder.Entity("FairWorks.Domain.Entities.Stand", b =>
                {
                    b.Navigation("SozlesmeBilgileri");

                    b.Navigation("TeklifBilgileri");
                });

            modelBuilder.Entity("FairWorks.Domain.Entities.TemsilEttigiFirma", b =>
                {
                    b.Navigation("FirmaTipi");
                });

            modelBuilder.Entity("FairWorks.Domain.Entities.Urun", b =>
                {
                    b.Navigation("KatalogGirisForm");
                });
#pragma warning restore 612, 618
        }
    }
}
