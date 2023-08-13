using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class isilaniIsverenAdi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsVerenId",
                table: "IsIlanlari");

            migrationBuilder.AddColumn<string>(
                name: "IsVerenAdi",
                table: "IsIlanlari",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsVerenAdi",
                table: "IsIlanlari");

            migrationBuilder.AddColumn<int>(
                name: "IsVerenId",
                table: "IsIlanlari",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
