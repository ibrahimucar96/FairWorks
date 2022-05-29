using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FairWorks.Domain.Migrations
{
    public partial class entitesgüncellemesi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BiletliZiyaretciler_Firmalar_FirmaId",
                table: "BiletliZiyaretciler");

            migrationBuilder.DropForeignKey(
                name: "FK_GorusulenFirmalar_Firmalar_FirmaId",
                table: "GorusulenFirmalar");

            migrationBuilder.DropForeignKey(
                name: "FK_KatalogGirisFormlari_Firmalar_FirmaId",
                table: "KatalogGirisFormlari");

            migrationBuilder.DropForeignKey(
                name: "FK_KatalogGirisFormlari_FirmaTipleri_FirmaTipId",
                table: "KatalogGirisFormlari");

            migrationBuilder.DropForeignKey(
                name: "FK_KatalogGirisFormlari_Urunler_UrunGruplarıId",
                table: "KatalogGirisFormlari");

            migrationBuilder.DropForeignKey(
                name: "FK_PotansiyelFirmalar_Firmalar_FirmaId",
                table: "PotansiyelFirmalar");

            migrationBuilder.DropForeignKey(
                name: "FK_SozlesmeBilgileri_Dovizler_DovizId",
                table: "SozlesmeBilgileri");

            migrationBuilder.DropForeignKey(
                name: "FK_SozlesmeBilgileri_Firmalar_FirmaId",
                table: "SozlesmeBilgileri");

            migrationBuilder.DropIndex(
                name: "IX_SozlesmeBilgileri_DovizId",
                table: "SozlesmeBilgileri");

            migrationBuilder.DropIndex(
                name: "IX_PotansiyelFirmalar_FirmaId",
                table: "PotansiyelFirmalar");

            migrationBuilder.DropIndex(
                name: "IX_KatalogGirisFormlari_UrunGruplarıId",
                table: "KatalogGirisFormlari");

            migrationBuilder.DropIndex(
                name: "IX_BiletliZiyaretciler_FirmaId",
                table: "BiletliZiyaretciler");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Ziyaretciler");

            migrationBuilder.DropColumn(
                name: "ZiyaretciId",
                table: "Ziyaretciler");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Urunler");

            migrationBuilder.DropColumn(
                name: "UrunId",
                table: "Urunler");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "TemsilEttigiFirmalar");

            migrationBuilder.DropColumn(
                name: "TemsilEttigiFirmaId",
                table: "TemsilEttigiFirmalar");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "TeklifBilgileri");

            migrationBuilder.DropColumn(
                name: "TeklifBilgisiId",
                table: "TeklifBilgileri");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Tedarikciler");

            migrationBuilder.DropColumn(
                name: "TedarikciId",
                table: "Tedarikciler");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Standlar");

            migrationBuilder.DropColumn(
                name: "StandId",
                table: "Standlar");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "SozlesmeTipleri");

            migrationBuilder.DropColumn(
                name: "SozlesmeTipiId",
                table: "SozlesmeTipleri");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "SozlesmeBilgileri");

            migrationBuilder.DropColumn(
                name: "DovizId",
                table: "SozlesmeBilgileri");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Salonlar");

            migrationBuilder.DropColumn(
                name: "SalonId",
                table: "Salonlar");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "PotansiyelFirmalar");

            migrationBuilder.DropColumn(
                name: "FirmaId",
                table: "PotansiyelFirmalar");

            migrationBuilder.DropColumn(
                name: "PotansiyelFirmaId",
                table: "PotansiyelFirmalar");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Personeller");

            migrationBuilder.DropColumn(
                name: "PersonelId",
                table: "Personeller");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "OdemePlanlari");

            migrationBuilder.DropColumn(
                name: "OdemePlaniId",
                table: "OdemePlanlari");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Kullanicilar");

            migrationBuilder.DropColumn(
                name: "KullaniciId",
                table: "Kullanicilar");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "KatalogGirisFormlari");

            migrationBuilder.DropColumn(
                name: "UrunGruplarıId",
                table: "KatalogGirisFormlari");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "İlaveStandMalzemeleri");

            migrationBuilder.DropColumn(
                name: "IlaveStandMalzemeId",
                table: "İlaveStandMalzemeleri");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "GorusulenFirmalar");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "FirmaTipleri");

            migrationBuilder.DropColumn(
                name: "FirmaTipId",
                table: "FirmaTipleri");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "FirmaTipiveFirmalar");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "FirmaTipiveFirmalar");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Firmalar");

            migrationBuilder.DropColumn(
                name: "FirmaId",
                table: "Firmalar");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Dovizler");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "DavetiyesizZiyaretciler");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "BiletliZiyaretciler");

            migrationBuilder.DropColumn(
                name: "FirmaId",
                table: "BiletliZiyaretciler");

            migrationBuilder.RenameColumn(
                name: "SozlesmeBilgisiId",
                table: "SozlesmeBilgileri",
                newName: "FirmaBilgileriId");

            migrationBuilder.RenameColumn(
                name: "KatalogGirisFormId",
                table: "KatalogGirisFormlari",
                newName: "UrunId");

            migrationBuilder.RenameColumn(
                name: "FirmanınSektoru",
                table: "GorusulenFirmalar",
                newName: "Telefon");

            migrationBuilder.RenameColumn(
                name: "Distributor",
                table: "GorusulenFirmalar",
                newName: "FirmanınCalıstıgıSektoru");

            migrationBuilder.RenameColumn(
                name: "Diger",
                table: "GorusulenFirmalar",
                newName: "Eposta");

            migrationBuilder.AddColumn<decimal>(
                name: "TeklifVerilenm2",
                table: "TeklifBilgileri",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "m2birimFiyatı",
                table: "TeklifBilgileri",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<int>(
                name: "FirmaId",
                table: "SozlesmeBilgileri",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "DovizCinsi",
                table: "SozlesmeBilgileri",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "DovizKuru",
                table: "SozlesmeBilgileri",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Adres",
                table: "PotansiyelFirmalar",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "PotansiyelFirmalar",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Faks",
                table: "PotansiyelFirmalar",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirmaAdı",
                table: "PotansiyelFirmalar",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sehir",
                table: "PotansiyelFirmalar",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telefon",
                table: "PotansiyelFirmalar",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ulke",
                table: "PotansiyelFirmalar",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FirmaTipId",
                table: "KatalogGirisFormlari",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FirmaId",
                table: "KatalogGirisFormlari",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FirmaId",
                table: "GorusulenFirmalar",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Adres",
                table: "BiletliZiyaretciler",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Eposta",
                table: "BiletliZiyaretciler",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Faks",
                table: "BiletliZiyaretciler",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirmaAdı",
                table: "BiletliZiyaretciler",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telefon",
                table: "BiletliZiyaretciler",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "FirmaBilgileri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VergiDairesi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VergiNumarası = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FuarYetkilisi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FirmaBilgileri", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SozlesmeBilgileri_FirmaBilgileriId",
                table: "SozlesmeBilgileri",
                column: "FirmaBilgileriId");

            migrationBuilder.CreateIndex(
                name: "IX_KatalogGirisFormlari_UrunId",
                table: "KatalogGirisFormlari",
                column: "UrunId");

            migrationBuilder.AddForeignKey(
                name: "FK_GorusulenFirmalar_Firmalar_FirmaId",
                table: "GorusulenFirmalar",
                column: "FirmaId",
                principalTable: "Firmalar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_KatalogGirisFormlari_Firmalar_FirmaId",
                table: "KatalogGirisFormlari",
                column: "FirmaId",
                principalTable: "Firmalar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KatalogGirisFormlari_FirmaTipleri_FirmaTipId",
                table: "KatalogGirisFormlari",
                column: "FirmaTipId",
                principalTable: "FirmaTipleri",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KatalogGirisFormlari_Urunler_UrunId",
                table: "KatalogGirisFormlari",
                column: "UrunId",
                principalTable: "Urunler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SozlesmeBilgileri_FirmaBilgileri_FirmaBilgileriId",
                table: "SozlesmeBilgileri",
                column: "FirmaBilgileriId",
                principalTable: "FirmaBilgileri",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SozlesmeBilgileri_Firmalar_FirmaId",
                table: "SozlesmeBilgileri",
                column: "FirmaId",
                principalTable: "Firmalar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GorusulenFirmalar_Firmalar_FirmaId",
                table: "GorusulenFirmalar");

            migrationBuilder.DropForeignKey(
                name: "FK_KatalogGirisFormlari_Firmalar_FirmaId",
                table: "KatalogGirisFormlari");

            migrationBuilder.DropForeignKey(
                name: "FK_KatalogGirisFormlari_FirmaTipleri_FirmaTipId",
                table: "KatalogGirisFormlari");

            migrationBuilder.DropForeignKey(
                name: "FK_KatalogGirisFormlari_Urunler_UrunId",
                table: "KatalogGirisFormlari");

            migrationBuilder.DropForeignKey(
                name: "FK_SozlesmeBilgileri_FirmaBilgileri_FirmaBilgileriId",
                table: "SozlesmeBilgileri");

            migrationBuilder.DropForeignKey(
                name: "FK_SozlesmeBilgileri_Firmalar_FirmaId",
                table: "SozlesmeBilgileri");

            migrationBuilder.DropTable(
                name: "FirmaBilgileri");

            migrationBuilder.DropIndex(
                name: "IX_SozlesmeBilgileri_FirmaBilgileriId",
                table: "SozlesmeBilgileri");

            migrationBuilder.DropIndex(
                name: "IX_KatalogGirisFormlari_UrunId",
                table: "KatalogGirisFormlari");

            migrationBuilder.DropColumn(
                name: "TeklifVerilenm2",
                table: "TeklifBilgileri");

            migrationBuilder.DropColumn(
                name: "m2birimFiyatı",
                table: "TeklifBilgileri");

            migrationBuilder.DropColumn(
                name: "DovizCinsi",
                table: "SozlesmeBilgileri");

            migrationBuilder.DropColumn(
                name: "DovizKuru",
                table: "SozlesmeBilgileri");

            migrationBuilder.DropColumn(
                name: "Adres",
                table: "PotansiyelFirmalar");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "PotansiyelFirmalar");

            migrationBuilder.DropColumn(
                name: "Faks",
                table: "PotansiyelFirmalar");

            migrationBuilder.DropColumn(
                name: "FirmaAdı",
                table: "PotansiyelFirmalar");

            migrationBuilder.DropColumn(
                name: "Sehir",
                table: "PotansiyelFirmalar");

            migrationBuilder.DropColumn(
                name: "Telefon",
                table: "PotansiyelFirmalar");

            migrationBuilder.DropColumn(
                name: "Ulke",
                table: "PotansiyelFirmalar");

            migrationBuilder.DropColumn(
                name: "Adres",
                table: "BiletliZiyaretciler");

            migrationBuilder.DropColumn(
                name: "Eposta",
                table: "BiletliZiyaretciler");

            migrationBuilder.DropColumn(
                name: "Faks",
                table: "BiletliZiyaretciler");

            migrationBuilder.DropColumn(
                name: "FirmaAdı",
                table: "BiletliZiyaretciler");

            migrationBuilder.DropColumn(
                name: "Telefon",
                table: "BiletliZiyaretciler");

            migrationBuilder.RenameColumn(
                name: "FirmaBilgileriId",
                table: "SozlesmeBilgileri",
                newName: "SozlesmeBilgisiId");

            migrationBuilder.RenameColumn(
                name: "UrunId",
                table: "KatalogGirisFormlari",
                newName: "KatalogGirisFormId");

            migrationBuilder.RenameColumn(
                name: "Telefon",
                table: "GorusulenFirmalar",
                newName: "FirmanınSektoru");

            migrationBuilder.RenameColumn(
                name: "FirmanınCalıstıgıSektoru",
                table: "GorusulenFirmalar",
                newName: "Distributor");

            migrationBuilder.RenameColumn(
                name: "Eposta",
                table: "GorusulenFirmalar",
                newName: "Diger");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Ziyaretciler",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ZiyaretciId",
                table: "Ziyaretciler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Urunler",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "UrunId",
                table: "Urunler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "TemsilEttigiFirmalar",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "TemsilEttigiFirmaId",
                table: "TemsilEttigiFirmalar",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "TeklifBilgileri",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "TeklifBilgisiId",
                table: "TeklifBilgileri",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Tedarikciler",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "TedarikciId",
                table: "Tedarikciler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Standlar",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "StandId",
                table: "Standlar",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "SozlesmeTipleri",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "SozlesmeTipiId",
                table: "SozlesmeTipleri",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "FirmaId",
                table: "SozlesmeBilgileri",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "SozlesmeBilgileri",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DovizId",
                table: "SozlesmeBilgileri",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Salonlar",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "SalonId",
                table: "Salonlar",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "PotansiyelFirmalar",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "FirmaId",
                table: "PotansiyelFirmalar",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PotansiyelFirmaId",
                table: "PotansiyelFirmalar",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Personeller",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "PersonelId",
                table: "Personeller",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "OdemePlanlari",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "OdemePlaniId",
                table: "OdemePlanlari",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Kullanicilar",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "KullaniciId",
                table: "Kullanicilar",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "FirmaTipId",
                table: "KatalogGirisFormlari",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "FirmaId",
                table: "KatalogGirisFormlari",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "KatalogGirisFormlari",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "UrunGruplarıId",
                table: "KatalogGirisFormlari",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "İlaveStandMalzemeleri",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "IlaveStandMalzemeId",
                table: "İlaveStandMalzemeleri",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "FirmaId",
                table: "GorusulenFirmalar",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "GorusulenFirmalar",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "FirmaTipleri",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "FirmaTipId",
                table: "FirmaTipleri",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "FirmaTipiveFirmalar",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "FirmaTipiveFirmalar",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Firmalar",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "FirmaId",
                table: "Firmalar",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Dovizler",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "DavetiyesizZiyaretciler",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "BiletliZiyaretciler",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "FirmaId",
                table: "BiletliZiyaretciler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SozlesmeBilgileri_DovizId",
                table: "SozlesmeBilgileri",
                column: "DovizId");

            migrationBuilder.CreateIndex(
                name: "IX_PotansiyelFirmalar_FirmaId",
                table: "PotansiyelFirmalar",
                column: "FirmaId");

            migrationBuilder.CreateIndex(
                name: "IX_KatalogGirisFormlari_UrunGruplarıId",
                table: "KatalogGirisFormlari",
                column: "UrunGruplarıId");

            migrationBuilder.CreateIndex(
                name: "IX_BiletliZiyaretciler_FirmaId",
                table: "BiletliZiyaretciler",
                column: "FirmaId");

            migrationBuilder.AddForeignKey(
                name: "FK_BiletliZiyaretciler_Firmalar_FirmaId",
                table: "BiletliZiyaretciler",
                column: "FirmaId",
                principalTable: "Firmalar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GorusulenFirmalar_Firmalar_FirmaId",
                table: "GorusulenFirmalar",
                column: "FirmaId",
                principalTable: "Firmalar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KatalogGirisFormlari_Firmalar_FirmaId",
                table: "KatalogGirisFormlari",
                column: "FirmaId",
                principalTable: "Firmalar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_KatalogGirisFormlari_FirmaTipleri_FirmaTipId",
                table: "KatalogGirisFormlari",
                column: "FirmaTipId",
                principalTable: "FirmaTipleri",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_KatalogGirisFormlari_Urunler_UrunGruplarıId",
                table: "KatalogGirisFormlari",
                column: "UrunGruplarıId",
                principalTable: "Urunler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PotansiyelFirmalar_Firmalar_FirmaId",
                table: "PotansiyelFirmalar",
                column: "FirmaId",
                principalTable: "Firmalar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SozlesmeBilgileri_Dovizler_DovizId",
                table: "SozlesmeBilgileri",
                column: "DovizId",
                principalTable: "Dovizler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SozlesmeBilgileri_Firmalar_FirmaId",
                table: "SozlesmeBilgileri",
                column: "FirmaId",
                principalTable: "Firmalar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
