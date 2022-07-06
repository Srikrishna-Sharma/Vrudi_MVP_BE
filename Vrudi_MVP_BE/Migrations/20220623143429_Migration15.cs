using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vrudi_MVP_BE.Migrations
{
    public partial class Migration15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrganisationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrganisationType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PermanentAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrganisationMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonalEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactMobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GstNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PanNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BankAccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IfscCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BankName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OpeningBal = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "professionals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisteredEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisteredMobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrganisationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrganisationType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Industry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PermanentAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrganisationMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GstType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GstNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PanNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TanNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BankAccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IfscCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BankName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_professionals", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "clients");

            migrationBuilder.DropTable(
                name: "professionals");
        }
    }
}
