using Microsoft.EntityFrameworkCore.Migrations;

namespace Comestic.Data.Migrations
{
    public partial class addmore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "city",
                table: "OrderHeader",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "district",
                table: "OrderHeader",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "street",
                table: "OrderHeader",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "city",
                table: "OrderHeader");

            migrationBuilder.DropColumn(
                name: "district",
                table: "OrderHeader");

            migrationBuilder.DropColumn(
                name: "street",
                table: "OrderHeader");
        }
    }
}
