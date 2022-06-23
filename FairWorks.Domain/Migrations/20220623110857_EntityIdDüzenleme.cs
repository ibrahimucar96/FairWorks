using Microsoft.EntityFrameworkCore.Migrations;

namespace FairWorks.Domain.Migrations
{
    public partial class EntityIdDüzenleme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "FirmaTipiveFirmalar",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "FirmaTipiveFirmalar");
        }
    }
}
