using Microsoft.EntityFrameworkCore.Migrations;

namespace FairWorks.Domain.Migrations
{
    public partial class dznleme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "FirmaTipiveFirmalar");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "FirmaTipiveFirmalar",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
