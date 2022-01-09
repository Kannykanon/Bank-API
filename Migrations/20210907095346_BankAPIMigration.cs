using Microsoft.EntityFrameworkCore.Migrations;

namespace BankAPI.Migrations
{
    public partial class BankAPIMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomerTab",
                columns: table => new
                {
                    BVN = table.Column<string>(nullable: false),
                    Surname = table.Column<string>(nullable: false),
                    Othername = table.Column<string>(nullable: false),
                    Firstname = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Status = table.Column<string>(nullable: false),
                    Gender = table.Column<string>(nullable: false),
                    PhoneNo = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Residence = table.Column<string>(nullable: false),
                    Product = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerTab", x => x.BVN);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerTab");
        }
    }
}
