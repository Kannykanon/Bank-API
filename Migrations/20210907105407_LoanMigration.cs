using Microsoft.EntityFrameworkCore.Migrations;

namespace BankAPI.Migrations
{
    public partial class LoanMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoanTab",
                columns: table => new
                {
                    AccountNumber = table.Column<string>(nullable: false),
                    CustomerName = table.Column<string>(nullable: false),
                    Tenor = table.Column<string>(nullable: false),
                    InterestRate = table.Column<string>(nullable: false),
                    EffectiveDate = table.Column<string>(nullable: false),
                    FirstPayDate = table.Column<string>(nullable: false),
                    PrincipalFreq = table.Column<string>(nullable: false),
                    InterestFreq = table.Column<string>(nullable: false),
                    ProductCode = table.Column<string>(nullable: false),
                    PrincipalAmount = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoanTab", x => x.AccountNumber);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LoanTab");
        }
    }
}
