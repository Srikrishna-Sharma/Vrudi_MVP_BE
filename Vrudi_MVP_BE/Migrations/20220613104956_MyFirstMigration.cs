using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vrudi_MVP_BE.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "userLogins",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Professional",
                table: "userLogins",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "userLogins",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Usertype",
                table: "userLogins",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "userLogins");

            migrationBuilder.DropColumn(
                name: "Professional",
                table: "userLogins");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "userLogins");

            migrationBuilder.DropColumn(
                name: "Usertype",
                table: "userLogins");
        }
    }
}
