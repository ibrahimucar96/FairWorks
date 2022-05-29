using Microsoft.EntityFrameworkCore.Migrations;

namespace FairWorks.Domain.Migrations
{
    public partial class Duzeltme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FirmaTipiveFirmalar_FirmaTipleri_FirmaTipId",
                table: "FirmaTipiveFirmalar");

            migrationBuilder.DropForeignKey(
                name: "FK_FirmaTipiveFirmalar_TemsilEttigiFirmalar_TemsilEttigiFirmaId",
                table: "FirmaTipiveFirmalar");

            migrationBuilder.AddForeignKey(
                name: "FK_FirmaTipiveFirmalar_FirmaTipleri_TemsilEttigiFirmaId",
                table: "FirmaTipiveFirmalar",
                column: "TemsilEttigiFirmaId",
                principalTable: "FirmaTipleri",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FirmaTipiveFirmalar_TemsilEttigiFirmalar_FirmaTipId",
                table: "FirmaTipiveFirmalar",
                column: "FirmaTipId",
                principalTable: "TemsilEttigiFirmalar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FirmaTipiveFirmalar_FirmaTipleri_TemsilEttigiFirmaId",
                table: "FirmaTipiveFirmalar");

            migrationBuilder.DropForeignKey(
                name: "FK_FirmaTipiveFirmalar_TemsilEttigiFirmalar_FirmaTipId",
                table: "FirmaTipiveFirmalar");

            migrationBuilder.AddForeignKey(
                name: "FK_FirmaTipiveFirmalar_FirmaTipleri_FirmaTipId",
                table: "FirmaTipiveFirmalar",
                column: "FirmaTipId",
                principalTable: "FirmaTipleri",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FirmaTipiveFirmalar_TemsilEttigiFirmalar_TemsilEttigiFirmaId",
                table: "FirmaTipiveFirmalar",
                column: "TemsilEttigiFirmaId",
                principalTable: "TemsilEttigiFirmalar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
