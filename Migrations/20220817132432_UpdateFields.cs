using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace e_commerce.Migrations
{
    public partial class UpdateFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ArtDir",
                table: "Games",
                newName: "Description");

            migrationBuilder.AddColumn<string>(
                name: "ArtUrl",
                table: "Games",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArtUrl",
                table: "Games");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Games",
                newName: "ArtDir");
        }
    }
}
