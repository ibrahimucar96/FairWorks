using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FairWorks.Domain.Migrations
{
    public partial class FairWorkDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dovizler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DovizCinsi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DovizKuru = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dovizler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Firmalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirmaId = table.Column<int>(type: "int", nullable: false),
                    FirmaAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Eposta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Faks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sehir = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ulke = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Firmalar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FirmaTipleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirmaTipId = table.Column<int>(type: "int", nullable: false),
                    FirmaTip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FirmaTipleri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "İlaveStandMalzemeleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IlaveStandMalzemeId = table.Column<int>(type: "int", nullable: false),
                    IlaveStandMalzemesi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MalzemeKodu = table.Column<int>(type: "int", nullable: false),
                    MalzemeleAdı = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ElektrikKw = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Ozellik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_İlaveStandMalzemeleri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kullanicilar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciId = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Role = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValue: "user"),
                    LoginDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicilar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OdemePlanlari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OdemePlaniId = table.Column<int>(type: "int", nullable: false),
                    VadeSayisi = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Taksit = table.Column<int>(type: "int", nullable: false),
                    Faiz = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Ay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Yıl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    m2BirimFiyati = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    m2 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    indirimOrani = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OdemePlanlari", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personeller",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonelId = table.Column<int>(type: "int", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoyAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Unvan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sehir = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bolge = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ulke = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fotograf = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Notlar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RaporVerdigiKisi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Maas = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personeller", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Salonlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SalonId = table.Column<int>(type: "int", nullable: false),
                    Ulke = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sehir = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalonNo = table.Column<int>(type: "int", nullable: false),
                    m2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    en = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    boy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SektorAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salonlar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SozlesmeTipleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SozlesmeTipiId = table.Column<int>(type: "int", nullable: false),
                    SozlesmeTipleri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SozlesmeTipleri", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TemsilEttigiFirmalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TemsilEttigiFirmaId = table.Column<int>(type: "int", nullable: false),
                    TemsilEdilenFirma = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ulke = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TemsilEdilenFirmaUrunleri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IletisimBilgileri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemsilEttigiFirmalar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Urunler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrunId = table.Column<int>(type: "int", nullable: false),
                    UrunAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adet = table.Column<int>(type: "int", nullable: false),
                    Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UrunKodu = table.Column<int>(type: "int", nullable: false),
                    UrunBilgileri = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urunler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BiletliZiyaretciler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoyAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirmaId = table.Column<int>(type: "int", nullable: false),
                    Meslek = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BiletliZiyaretciler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BiletliZiyaretciler_Firmalar_FirmaId",
                        column: x => x.FirmaId,
                        principalTable: "Firmalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DavetiyesizZiyaretciler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoyAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirmaId = table.Column<int>(type: "int", nullable: false),
                    Meslek = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DavetiyesizZiyaretciler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DavetiyesizZiyaretciler_Firmalar_FirmaId",
                        column: x => x.FirmaId,
                        principalTable: "Firmalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PotansiyelFirmalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PotansiyelFirmaId = table.Column<int>(type: "int", nullable: false),
                    FirmaId = table.Column<int>(type: "int", nullable: false),
                    Yetkili = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Unvani = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DahiliTelefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DirektTelefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sektor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PotansiyelFirmalar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PotansiyelFirmalar_Firmalar_FirmaId",
                        column: x => x.FirmaId,
                        principalTable: "Firmalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ziyaretciler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ZiyaretciId = table.Column<int>(type: "int", nullable: false),
                    FirmaId = table.Column<int>(type: "int", nullable: false),
                    Yetkili = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Unvani = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DahiliTelefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DirektTelefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sektor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ziyaretciler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ziyaretciler_Firmalar_FirmaId",
                        column: x => x.FirmaId,
                        principalTable: "Firmalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tedarikciler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TedarikciId = table.Column<int>(type: "int", nullable: false),
                    Tedarikciler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    İlaveStandMalzemeleriId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tedarikciler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tedarikciler_İlaveStandMalzemeleri_İlaveStandMalzemeleriId",
                        column: x => x.İlaveStandMalzemeleriId,
                        principalTable: "İlaveStandMalzemeleri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GorusulenFirmalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonelId = table.Column<int>(type: "int", nullable: false),
                    GorusmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GorusulenKisi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Unvanı = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirmaId = table.Column<int>(type: "int", nullable: false),
                    FirmanınSektoru = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirmaninProfili = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Distributor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diger = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirmaninIlgilendigiFuar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirmaninIlgilendigiSalon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GorusmeNotlari = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GorusulenFirmalar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GorusulenFirmalar_Firmalar_FirmaId",
                        column: x => x.FirmaId,
                        principalTable: "Firmalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GorusulenFirmalar_Personeller_PersonelId",
                        column: x => x.PersonelId,
                        principalTable: "Personeller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Standlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StandId = table.Column<int>(type: "int", nullable: false),
                    StandTipi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StandKodu = table.Column<int>(type: "int", nullable: false),
                    SalonId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Standlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Standlar_Salonlar_SalonId",
                        column: x => x.SalonId,
                        principalTable: "Salonlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FirmaTipiveFirmalar",
                columns: table => new
                {
                    TemsilEttigiFirmaId = table.Column<int>(type: "int", nullable: false),
                    FirmaTipId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FirmaTipiveFirmalar", x => new { x.TemsilEttigiFirmaId, x.FirmaTipId });
                    table.ForeignKey(
                        name: "FK_FirmaTipiveFirmalar_FirmaTipleri_FirmaTipId",
                        column: x => x.FirmaTipId,
                        principalTable: "FirmaTipleri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FirmaTipiveFirmalar_TemsilEttigiFirmalar_TemsilEttigiFirmaId",
                        column: x => x.TemsilEttigiFirmaId,
                        principalTable: "TemsilEttigiFirmalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KatalogGirisFormlari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KatalogGirisFormId = table.Column<int>(type: "int", nullable: false),
                    FirmaId = table.Column<int>(type: "int", nullable: true),
                    UrunGruplarıId = table.Column<int>(type: "int", nullable: true),
                    FirmaTipId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KatalogGirisFormlari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KatalogGirisFormlari_Firmalar_FirmaId",
                        column: x => x.FirmaId,
                        principalTable: "Firmalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_KatalogGirisFormlari_FirmaTipleri_FirmaTipId",
                        column: x => x.FirmaTipId,
                        principalTable: "FirmaTipleri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_KatalogGirisFormlari_Urunler_UrunGruplarıId",
                        column: x => x.UrunGruplarıId,
                        principalTable: "Urunler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SozlesmeBilgileri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SozlesmeBilgisiId = table.Column<int>(type: "int", nullable: false),
                    SozlesmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PersonelId = table.Column<int>(type: "int", nullable: false),
                    FirmaId = table.Column<int>(type: "int", nullable: false),
                    SozlesmeTipiId = table.Column<int>(type: "int", nullable: false),
                    StandId = table.Column<int>(type: "int", nullable: false),
                    OdemePlaniId = table.Column<int>(type: "int", nullable: false),
                    DovizId = table.Column<int>(type: "int", nullable: false),
                    SozlesmeSonGecerlilikTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImzaliSozlesmeDurumu = table.Column<bool>(type: "bit", nullable: false),
                    salonId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SozlesmeBilgileri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SozlesmeBilgileri_Dovizler_DovizId",
                        column: x => x.DovizId,
                        principalTable: "Dovizler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SozlesmeBilgileri_Firmalar_FirmaId",
                        column: x => x.FirmaId,
                        principalTable: "Firmalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SozlesmeBilgileri_OdemePlanlari_OdemePlaniId",
                        column: x => x.OdemePlaniId,
                        principalTable: "OdemePlanlari",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SozlesmeBilgileri_Personeller_PersonelId",
                        column: x => x.PersonelId,
                        principalTable: "Personeller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SozlesmeBilgileri_Salonlar_salonId",
                        column: x => x.salonId,
                        principalTable: "Salonlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SozlesmeBilgileri_SozlesmeTipleri_SozlesmeTipiId",
                        column: x => x.SozlesmeTipiId,
                        principalTable: "SozlesmeTipleri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SozlesmeBilgileri_Standlar_StandId",
                        column: x => x.StandId,
                        principalTable: "Standlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "TeklifBilgileri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeklifBilgisiId = table.Column<int>(type: "int", nullable: false),
                    TeklifTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StandId = table.Column<int>(type: "int", nullable: false),
                    DovizId = table.Column<int>(type: "int", nullable: false),
                    OdemePlaniId = table.Column<int>(type: "int", nullable: false),
                    TeklifinSonGecerlilikTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    salonId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeklifBilgileri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeklifBilgileri_Dovizler_DovizId",
                        column: x => x.DovizId,
                        principalTable: "Dovizler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeklifBilgileri_OdemePlanlari_OdemePlaniId",
                        column: x => x.OdemePlaniId,
                        principalTable: "OdemePlanlari",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeklifBilgileri_Salonlar_salonId",
                        column: x => x.salonId,
                        principalTable: "Salonlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeklifBilgileri_Standlar_StandId",
                        column: x => x.StandId,
                        principalTable: "Standlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BiletliZiyaretciler_FirmaId",
                table: "BiletliZiyaretciler",
                column: "FirmaId");

            migrationBuilder.CreateIndex(
                name: "IX_DavetiyesizZiyaretciler_FirmaId",
                table: "DavetiyesizZiyaretciler",
                column: "FirmaId");

            migrationBuilder.CreateIndex(
                name: "IX_FirmaTipiveFirmalar_FirmaTipId",
                table: "FirmaTipiveFirmalar",
                column: "FirmaTipId");

            migrationBuilder.CreateIndex(
                name: "IX_GorusulenFirmalar_FirmaId",
                table: "GorusulenFirmalar",
                column: "FirmaId");

            migrationBuilder.CreateIndex(
                name: "IX_GorusulenFirmalar_PersonelId",
                table: "GorusulenFirmalar",
                column: "PersonelId");

            migrationBuilder.CreateIndex(
                name: "IX_KatalogGirisFormlari_FirmaId",
                table: "KatalogGirisFormlari",
                column: "FirmaId");

            migrationBuilder.CreateIndex(
                name: "IX_KatalogGirisFormlari_FirmaTipId",
                table: "KatalogGirisFormlari",
                column: "FirmaTipId");

            migrationBuilder.CreateIndex(
                name: "IX_KatalogGirisFormlari_UrunGruplarıId",
                table: "KatalogGirisFormlari",
                column: "UrunGruplarıId");

            migrationBuilder.CreateIndex(
                name: "IX_PotansiyelFirmalar_FirmaId",
                table: "PotansiyelFirmalar",
                column: "FirmaId");

            migrationBuilder.CreateIndex(
                name: "IX_SozlesmeBilgileri_DovizId",
                table: "SozlesmeBilgileri",
                column: "DovizId");

            migrationBuilder.CreateIndex(
                name: "IX_SozlesmeBilgileri_FirmaId",
                table: "SozlesmeBilgileri",
                column: "FirmaId");

            migrationBuilder.CreateIndex(
                name: "IX_SozlesmeBilgileri_OdemePlaniId",
                table: "SozlesmeBilgileri",
                column: "OdemePlaniId");

            migrationBuilder.CreateIndex(
                name: "IX_SozlesmeBilgileri_PersonelId",
                table: "SozlesmeBilgileri",
                column: "PersonelId");

            migrationBuilder.CreateIndex(
                name: "IX_SozlesmeBilgileri_salonId",
                table: "SozlesmeBilgileri",
                column: "salonId");

            migrationBuilder.CreateIndex(
                name: "IX_SozlesmeBilgileri_SozlesmeTipiId",
                table: "SozlesmeBilgileri",
                column: "SozlesmeTipiId");

            migrationBuilder.CreateIndex(
                name: "IX_SozlesmeBilgileri_StandId",
                table: "SozlesmeBilgileri",
                column: "StandId");

            migrationBuilder.CreateIndex(
                name: "IX_Standlar_SalonId",
                table: "Standlar",
                column: "SalonId");

            migrationBuilder.CreateIndex(
                name: "IX_Tedarikciler_İlaveStandMalzemeleriId",
                table: "Tedarikciler",
                column: "İlaveStandMalzemeleriId");

            migrationBuilder.CreateIndex(
                name: "IX_TeklifBilgileri_DovizId",
                table: "TeklifBilgileri",
                column: "DovizId");

            migrationBuilder.CreateIndex(
                name: "IX_TeklifBilgileri_OdemePlaniId",
                table: "TeklifBilgileri",
                column: "OdemePlaniId");

            migrationBuilder.CreateIndex(
                name: "IX_TeklifBilgileri_salonId",
                table: "TeklifBilgileri",
                column: "salonId");

            migrationBuilder.CreateIndex(
                name: "IX_TeklifBilgileri_StandId",
                table: "TeklifBilgileri",
                column: "StandId");

            migrationBuilder.CreateIndex(
                name: "IX_Ziyaretciler_FirmaId",
                table: "Ziyaretciler",
                column: "FirmaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BiletliZiyaretciler");

            migrationBuilder.DropTable(
                name: "DavetiyesizZiyaretciler");

            migrationBuilder.DropTable(
                name: "FirmaTipiveFirmalar");

            migrationBuilder.DropTable(
                name: "GorusulenFirmalar");

            migrationBuilder.DropTable(
                name: "KatalogGirisFormlari");

            migrationBuilder.DropTable(
                name: "Kullanicilar");

            migrationBuilder.DropTable(
                name: "PotansiyelFirmalar");

            migrationBuilder.DropTable(
                name: "SozlesmeBilgileri");

            migrationBuilder.DropTable(
                name: "Tedarikciler");

            migrationBuilder.DropTable(
                name: "TeklifBilgileri");

            migrationBuilder.DropTable(
                name: "Ziyaretciler");

            migrationBuilder.DropTable(
                name: "TemsilEttigiFirmalar");

            migrationBuilder.DropTable(
                name: "FirmaTipleri");

            migrationBuilder.DropTable(
                name: "Urunler");

            migrationBuilder.DropTable(
                name: "Personeller");

            migrationBuilder.DropTable(
                name: "SozlesmeTipleri");

            migrationBuilder.DropTable(
                name: "İlaveStandMalzemeleri");

            migrationBuilder.DropTable(
                name: "Dovizler");

            migrationBuilder.DropTable(
                name: "OdemePlanlari");

            migrationBuilder.DropTable(
                name: "Standlar");

            migrationBuilder.DropTable(
                name: "Firmalar");

            migrationBuilder.DropTable(
                name: "Salonlar");
        }
    }
}
