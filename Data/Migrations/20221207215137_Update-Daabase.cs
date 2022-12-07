using Microsoft.EntityFrameworkCore.Migrations;

namespace Proj.Data.Migrations
{
    public partial class UpdateDaabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImgPath",
                table: "Item",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgPath",
                table: "Item");
        }
    }
}
