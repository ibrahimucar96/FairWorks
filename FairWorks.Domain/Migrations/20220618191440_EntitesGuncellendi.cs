using Microsoft.EntityFrameworkCore.Migrations;

namespace FairWorks.Domain.Migrations
{
    public partial class EntitesGuncellendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DavetiyesizZiyaretciler_Firmalar_FirmaId",
                table: "DavetiyesizZiyaretciler");

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
                name: "FK_SozlesmeBilgileri_Firmalar_FirmaId",
                table: "SozlesmeBilgileri");

            migrationBuilder.DropForeignKey(
                name: "FK_Ziyaretciler_Firmalar_FirmaId",
                table: "Ziyaretciler");

            migrationBuilder.DropIndex(
                name: "IX_Ziyaretciler_FirmaId",
                table: "Ziyaretciler");

            migrationBuilder.DropIndex(
                name: "IX_SozlesmeBilgileri_FirmaId",
                table: "SozlesmeBilgileri");

            migrationBuilder.DropIndex(
                name: "IX_KatalogGirisFormlari_FirmaId",
                table: "KatalogGirisFormlari");

            migrationBuilder.DropIndex(
                name: "IX_KatalogGirisFormlari_FirmaTipId",
                table: "KatalogGirisFormlari");

            migrationBuilder.DropIndex(
                name: "IX_GorusulenFirmalar_FirmaId",
                table: "GorusulenFirmalar");

            migrationBuilder.DropIndex(
                name: "IX_DavetiyesizZiyaretciler_FirmaId",
                table: "DavetiyesizZiyaretciler");

            migrationBuilder.DropColumn(
                name: "FirmaId",
                table: "Ziyaretciler");

            migrationBuilder.DropColumn(
                name: "FirmaId",
                table: "SozlesmeBilgileri");

            migrationBuilder.DropColumn(
                name: "FirmaId",
                table: "GorusulenFirmalar");

            migrationBuilder.DropColumn(
                name: "FirmaId",
                table: "DavetiyesizZiyaretciler");

            migrationBuilder.RenameColumn(
                name: "FirmaId",
                table: "KatalogGirisFormlari",
                newName: "TemsilEttigiFirmaId");

            migrationBuilder.AddColumn<string>(
                name: "Adres",
                table: "Ziyaretciler",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Ziyaretciler",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Faks",
                table: "Ziyaretciler",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirmaAdi",
                table: "Ziyaretciler",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sehir",
                table: "Ziyaretciler",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telefon",
                table: "Ziyaretciler",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ulke",
                table: "Ziyaretciler",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Adres",
                table: "KatalogGirisFormlari",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Eposta",
                table: "KatalogGirisFormlari",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Faks",
                table: "KatalogGirisFormlari",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirmaAdi",
                table: "KatalogGirisFormlari",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FirmaTipveTemsilEdilenFirmalarFirmaTipId",
                table: "KatalogGirisFormlari",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FirmaTipveTemsilEdilenFirmalarTemsilEttigiFirmaId",
                table: "KatalogGirisFormlari",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telefon",
                table: "KatalogGirisFormlari",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UcretsizVerilenAlanId",
                table: "FirmaBilgileri",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "UcretsizVerilenAlanlar",
                columns: table => new
                {
                    UcretsizVerilenAlanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UcretsizVerilenm2 = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UcretsizVerilenAlanlar", x => x.UcretsizVerilenAlanId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KatalogGirisFormlari_FirmaTipveTemsilEdilenFirmalarTemsilEttigiFirmaId_FirmaTipveTemsilEdilenFirmalarFirmaTipId",
                table: "KatalogGirisFormlari",
                columns: new[] { "FirmaTipveTemsilEdilenFirmalarTemsilEttigiFirmaId", "FirmaTipveTemsilEdilenFirmalarFirmaTipId" });

            migrationBuilder.CreateIndex(
                name: "IX_FirmaBilgileri_UcretsizVerilenAlanId",
                table: "FirmaBilgileri",
                column: "UcretsizVerilenAlanId");

            migrationBuilder.AddForeignKey(
                name: "FK_FirmaBilgileri_UcretsizVerilenAlanlar_UcretsizVerilenAlanId",
                table: "FirmaBilgileri",
                column: "UcretsizVerilenAlanId",
                principalTable: "UcretsizVerilenAlanlar",
                principalColumn: "UcretsizVerilenAlanId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KatalogGirisFormlari_FirmaTipiveFirmalar_FirmaTipveTemsilEdilenFirmalarTemsilEttigiFirmaId_FirmaTipveTemsilEdilenFirmalarFir~",
                table: "KatalogGirisFormlari",
                columns: new[] { "FirmaTipveTemsilEdilenFirmalarTemsilEttigiFirmaId", "FirmaTipveTemsilEdilenFirmalarFirmaTipId" },
                principalTable: "FirmaTipiveFirmalar",
                principalColumns: new[] { "TemsilEttigiFirmaId", "FirmaTipId" },
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FirmaBilgileri_UcretsizVerilenAlanlar_UcretsizVerilenAlanId",
                table: "FirmaBilgileri");

            migrationBuilder.DropForeignKey(
                name: "FK_KatalogGirisFormlari_FirmaTipiveFirmalar_FirmaTipveTemsilEdilenFirmalarTemsilEttigiFirmaId_FirmaTipveTemsilEdilenFirmalarFir~",
                table: "KatalogGirisFormlari");

            migrationBuilder.DropTable(
                name: "UcretsizVerilenAlanlar");

            migrationBuilder.DropIndex(
                name: "IX_KatalogGirisFormlari_FirmaTipveTemsilEdilenFirmalarTemsilEttigiFirmaId_FirmaTipveTemsilEdilenFirmalarFirmaTipId",
                table: "KatalogGirisFormlari");

            migrationBuilder.DropIndex(
                name: "IX_FirmaBilgileri_UcretsizVerilenAlanId",
                table: "FirmaBilgileri");

            migrationBuilder.DropColumn(
                name: "Adres",
                table: "Ziyaretciler");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Ziyaretciler");

            migrationBuilder.DropColumn(
                name: "Faks",
                table: "Ziyaretciler");

            migrationBuilder.DropColumn(
                name: "FirmaAdi",
                table: "Ziyaretciler");

            migrationBuilder.DropColumn(
                name: "Sehir",
                table: "Ziyaretciler");

            migrationBuilder.DropColumn(
                name: "Telefon",
                table: "Ziyaretciler");

            migrationBuilder.DropColumn(
                name: "Ulke",
                table: "Ziyaretciler");

            migrationBuilder.DropColumn(
                name: "Adres",
                table: "KatalogGirisFormlari");

            migrationBuilder.DropColumn(
                name: "Eposta",
                table: "KatalogGirisFormlari");

            migrationBuilder.DropColumn(
                name: "Faks",
                table: "KatalogGirisFormlari");

            migrationBuilder.DropColumn(
                name: "FirmaAdi",
                table: "KatalogGirisFormlari");

            migrationBuilder.DropColumn(
                name: "FirmaTipveTemsilEdilenFirmalarFirmaTipId",
                table: "KatalogGirisFormlari");

            migrationBuilder.DropColumn(
                name: "FirmaTipveTemsilEdilenFirmalarTemsilEttigiFirmaId",
                table: "KatalogGirisFormlari");

            migrationBuilder.DropColumn(
                name: "Telefon",
                table: "KatalogGirisFormlari");

            migrationBuilder.DropColumn(
                name: "UcretsizVerilenAlanId",
                table: "FirmaBilgileri");

            migrationBuilder.RenameColumn(
                name: "TemsilEttigiFirmaId",
                table: "KatalogGirisFormlari",
                newName: "FirmaId");

            migrationBuilder.AddColumn<int>(
                name: "FirmaId",
                table: "Ziyaretciler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FirmaId",
                table: "SozlesmeBilgileri",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FirmaId",
                table: "GorusulenFirmalar",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FirmaId",
                table: "DavetiyesizZiyaretciler",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ziyaretciler_FirmaId",
                table: "Ziyaretciler",
                column: "FirmaId");

            migrationBuilder.CreateIndex(
                name: "IX_SozlesmeBilgileri_FirmaId",
                table: "SozlesmeBilgileri",
                column: "FirmaId");

            migrationBuilder.CreateIndex(
                name: "IX_KatalogGirisFormlari_FirmaId",
                table: "KatalogGirisFormlari",
                column: "FirmaId");

            migrationBuilder.CreateIndex(
                name: "IX_KatalogGirisFormlari_FirmaTipId",
                table: "KatalogGirisFormlari",
                column: "FirmaTipId");

            migrationBuilder.CreateIndex(
                name: "IX_GorusulenFirmalar_FirmaId",
                table: "GorusulenFirmalar",
                column: "FirmaId");

            migrationBuilder.CreateIndex(
                name: "IX_DavetiyesizZiyaretciler_FirmaId",
                table: "DavetiyesizZiyaretciler",
                column: "FirmaId");

            migrationBuilder.AddForeignKey(
                name: "FK_DavetiyesizZiyaretciler_Firmalar_FirmaId",
                table: "DavetiyesizZiyaretciler",
                column: "FirmaId",
                principalTable: "Firmalar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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
                principalColumn: "FirmaTipId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SozlesmeBilgileri_Firmalar_FirmaId",
                table: "SozlesmeBilgileri",
                column: "FirmaId",
                principalTable: "Firmalar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ziyaretciler_Firmalar_FirmaId",
                table: "Ziyaretciler",
                column: "FirmaId",
                principalTable: "Firmalar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
