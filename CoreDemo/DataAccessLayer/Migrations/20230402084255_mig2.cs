using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Bolgs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Bolgs_CategoryID",
                table: "Bolgs",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Bolgs_Categories_CategoryID",
                table: "Bolgs",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bolgs_Categories_CategoryID",
                table: "Bolgs");

            migrationBuilder.DropIndex(
                name: "IX_Bolgs_CategoryID",
                table: "Bolgs");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Bolgs");
        }
    }
}
