using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BlogBologID",
                table: "Comments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BologID",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_BlogBologID",
                table: "Comments",
                column: "BlogBologID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Bolgs_BlogBologID",
                table: "Comments",
                column: "BlogBologID",
                principalTable: "Bolgs",
                principalColumn: "BologID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Bolgs_BlogBologID",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_BlogBologID",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "BlogBologID",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "BologID",
                table: "Comments");
        }
    }
}
