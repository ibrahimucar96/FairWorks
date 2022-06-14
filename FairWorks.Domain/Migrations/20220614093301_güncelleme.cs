using Microsoft.EntityFrameworkCore.Migrations;

namespace FairWorks.Domain.Migrations
{
    public partial class güncelleme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TemsilEttigiFirmalar",
                newName: "TemsilEttigiFirmaId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "FirmaTipleri",
                newName: "FirmaTipId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TemsilEttigiFirmaId",
                table: "TemsilEttigiFirmalar",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "FirmaTipId",
                table: "FirmaTipleri",
                newName: "Id");
        }
    }
}
