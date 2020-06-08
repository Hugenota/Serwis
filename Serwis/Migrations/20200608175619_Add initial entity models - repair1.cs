using Microsoft.EntityFrameworkCore.Migrations;

namespace Serwis.Migrations
{
    public partial class Addinitialentitymodelsrepair1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Companys_CompanyID1",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Customers_CustomerID1",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerID1",
                table: "Products",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CompanyID1",
                table: "Products",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Companys_CompanyID1",
                table: "Products",
                column: "CompanyID1",
                principalTable: "Companys",
                principalColumn: "CompanyID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Customers_CustomerID1",
                table: "Products",
                column: "CustomerID1",
                principalTable: "Customers",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Companys_CompanyID1",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Customers_CustomerID1",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerID1",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CompanyID1",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Companys_CompanyID1",
                table: "Products",
                column: "CompanyID1",
                principalTable: "Companys",
                principalColumn: "CompanyID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Customers_CustomerID1",
                table: "Products",
                column: "CustomerID1",
                principalTable: "Customers",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
