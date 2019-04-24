using Microsoft.EntityFrameworkCore.Migrations;

namespace TreeLoversWatching.Data.Migrations
{
    public partial class Category : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Trees",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Latin",
                table: "Trees",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Trees");

            migrationBuilder.DropColumn(
                name: "Latin",
                table: "Trees");
        }
    }
}
