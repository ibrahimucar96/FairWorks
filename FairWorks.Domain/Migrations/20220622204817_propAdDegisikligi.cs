using Microsoft.EntityFrameworkCore.Migrations;

namespace FairWorks.Domain.Migrations
{
    public partial class propAdDegisikligi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MalzemeleAdı",
                table: "İlaveStandMalzemeleri",
                newName: "MalzemeAdı");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MalzemeAdı",
                table: "İlaveStandMalzemeleri",
                newName: "MalzemeleAdı");
        }
    }
}
