using Microsoft.EntityFrameworkCore.Migrations;

namespace FairWorks.Domain.Migrations
{
    public partial class düzeltmeDavetiyesizZiyaretci : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DavetiyesizZiyaretciler_Firmalar_FirmaId",
                table: "DavetiyesizZiyaretciler");

            migrationBuilder.AlterColumn<int>(
                name: "FirmaId",
                table: "DavetiyesizZiyaretciler",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Eposta",
                table: "DavetiyesizZiyaretciler",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Faks",
                table: "DavetiyesizZiyaretciler",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirmaAdı",
                table: "DavetiyesizZiyaretciler",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telefon",
                table: "DavetiyesizZiyaretciler",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DavetiyesizZiyaretciler_Firmalar_FirmaId",
                table: "DavetiyesizZiyaretciler",
                column: "FirmaId",
                principalTable: "Firmalar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DavetiyesizZiyaretciler_Firmalar_FirmaId",
                table: "DavetiyesizZiyaretciler");

            migrationBuilder.DropColumn(
                name: "Eposta",
                table: "DavetiyesizZiyaretciler");

            migrationBuilder.DropColumn(
                name: "Faks",
                table: "DavetiyesizZiyaretciler");

            migrationBuilder.DropColumn(
                name: "FirmaAdı",
                table: "DavetiyesizZiyaretciler");

            migrationBuilder.DropColumn(
                name: "Telefon",
                table: "DavetiyesizZiyaretciler");

            migrationBuilder.AlterColumn<int>(
                name: "FirmaId",
                table: "DavetiyesizZiyaretciler",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DavetiyesizZiyaretciler_Firmalar_FirmaId",
                table: "DavetiyesizZiyaretciler",
                column: "FirmaId",
                principalTable: "Firmalar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
