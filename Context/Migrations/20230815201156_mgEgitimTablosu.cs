using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class mgEgitimTablosu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EgitimTablosu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Lise = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Universite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bolum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CvTablosuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EgitimTablosu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EgitimTablosu_CvTablosu_CvTablosuId",
                        column: x => x.CvTablosuId,
                        principalTable: "CvTablosu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EgitimTablosu_CvTablosuId",
                table: "EgitimTablosu",
                column: "CvTablosuId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EgitimTablosu");
        }
    }
}
