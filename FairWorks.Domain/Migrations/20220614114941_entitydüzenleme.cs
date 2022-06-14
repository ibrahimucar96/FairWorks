using Microsoft.EntityFrameworkCore.Migrations;

namespace FairWorks.Domain.Migrations
{
    public partial class entitydüzenleme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tedarikciler_İlaveStandMalzemeleri_İlaveStandMalzemeleriId",
                table: "Tedarikciler");

            migrationBuilder.DropIndex(
                name: "IX_Tedarikciler_İlaveStandMalzemeleriId",
                table: "Tedarikciler");

            migrationBuilder.DropColumn(
                name: "İlaveStandMalzemeleriId",
                table: "Tedarikciler");

            migrationBuilder.AddColumn<int>(
                name: "TedarikciId",
                table: "İlaveStandMalzemeleri",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_İlaveStandMalzemeleri_TedarikciId",
                table: "İlaveStandMalzemeleri",
                column: "TedarikciId");

            migrationBuilder.AddForeignKey(
                name: "FK_İlaveStandMalzemeleri_Tedarikciler_TedarikciId",
                table: "İlaveStandMalzemeleri",
                column: "TedarikciId",
                principalTable: "Tedarikciler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_İlaveStandMalzemeleri_Tedarikciler_TedarikciId",
                table: "İlaveStandMalzemeleri");

            migrationBuilder.DropIndex(
                name: "IX_İlaveStandMalzemeleri_TedarikciId",
                table: "İlaveStandMalzemeleri");

            migrationBuilder.DropColumn(
                name: "TedarikciId",
                table: "İlaveStandMalzemeleri");

            migrationBuilder.AddColumn<int>(
                name: "İlaveStandMalzemeleriId",
                table: "Tedarikciler",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tedarikciler_İlaveStandMalzemeleriId",
                table: "Tedarikciler",
                column: "İlaveStandMalzemeleriId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tedarikciler_İlaveStandMalzemeleri_İlaveStandMalzemeleriId",
                table: "Tedarikciler",
                column: "İlaveStandMalzemeleriId",
                principalTable: "İlaveStandMalzemeleri",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
