using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vrudi_MVP_BE.Migrations
{
    public partial class Migration14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "leaveTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeductionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeductionValue = table.Column<int>(type: "int", nullable: false),
                    CapYearly = table.Column<int>(type: "int", nullable: false),
                    CapMonthly = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_leaveTypes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "leaveTypes");
        }
    }
}
