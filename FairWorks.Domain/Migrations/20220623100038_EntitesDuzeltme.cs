using Microsoft.EntityFrameworkCore.Migrations;

namespace FairWorks.Domain.Migrations
{
    public partial class EntitesDuzeltme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KatalogGirisFormlari_FirmaTipiveFirmalar_FirmaTipveTemsilEdilenFirmalarTemsilEttigiFirmaId_FirmaTipveTemsilEdilenFirmalarFir~",
                table: "KatalogGirisFormlari");

            migrationBuilder.DropIndex(
                name: "IX_KatalogGirisFormlari_FirmaTipveTemsilEdilenFirmalarTemsilEttigiFirmaId_FirmaTipveTemsilEdilenFirmalarFirmaTipId",
                table: "KatalogGirisFormlari");

            migrationBuilder.DropColumn(
                name: "FirmaTipveTemsilEdilenFirmalarFirmaTipId",
                table: "KatalogGirisFormlari");

            migrationBuilder.DropColumn(
                name: "FirmaTipveTemsilEdilenFirmalarTemsilEttigiFirmaId",
                table: "KatalogGirisFormlari");

            migrationBuilder.CreateIndex(
                name: "IX_KatalogGirisFormlari_FirmaTipId",
                table: "KatalogGirisFormlari",
                column: "FirmaTipId");

            migrationBuilder.CreateIndex(
                name: "IX_KatalogGirisFormlari_TemsilEttigiFirmaId",
                table: "KatalogGirisFormlari",
                column: "TemsilEttigiFirmaId");

            migrationBuilder.AddForeignKey(
                name: "FK_KatalogGirisFormlari_FirmaTipleri_FirmaTipId",
                table: "KatalogGirisFormlari",
                column: "FirmaTipId",
                principalTable: "FirmaTipleri",
                principalColumn: "FirmaTipId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KatalogGirisFormlari_TemsilEttigiFirmalar_TemsilEttigiFirmaId",
                table: "KatalogGirisFormlari",
                column: "TemsilEttigiFirmaId",
                principalTable: "TemsilEttigiFirmalar",
                principalColumn: "TemsilEttigiFirmaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KatalogGirisFormlari_FirmaTipleri_FirmaTipId",
                table: "KatalogGirisFormlari");

            migrationBuilder.DropForeignKey(
                name: "FK_KatalogGirisFormlari_TemsilEttigiFirmalar_TemsilEttigiFirmaId",
                table: "KatalogGirisFormlari");

            migrationBuilder.DropIndex(
                name: "IX_KatalogGirisFormlari_FirmaTipId",
                table: "KatalogGirisFormlari");

            migrationBuilder.DropIndex(
                name: "IX_KatalogGirisFormlari_TemsilEttigiFirmaId",
                table: "KatalogGirisFormlari");

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

            migrationBuilder.CreateIndex(
                name: "IX_KatalogGirisFormlari_FirmaTipveTemsilEdilenFirmalarTemsilEttigiFirmaId_FirmaTipveTemsilEdilenFirmalarFirmaTipId",
                table: "KatalogGirisFormlari",
                columns: new[] { "FirmaTipveTemsilEdilenFirmalarTemsilEttigiFirmaId", "FirmaTipveTemsilEdilenFirmalarFirmaTipId" });

            migrationBuilder.AddForeignKey(
                name: "FK_KatalogGirisFormlari_FirmaTipiveFirmalar_FirmaTipveTemsilEdilenFirmalarTemsilEttigiFirmaId_FirmaTipveTemsilEdilenFirmalarFir~",
                table: "KatalogGirisFormlari",
                columns: new[] { "FirmaTipveTemsilEdilenFirmalarTemsilEttigiFirmaId", "FirmaTipveTemsilEdilenFirmalarFirmaTipId" },
                principalTable: "FirmaTipiveFirmalar",
                principalColumns: new[] { "TemsilEttigiFirmaId", "FirmaTipId" },
                onDelete: ReferentialAction.Restrict);
        }
    }
}
