using Microsoft.EntityFrameworkCore.Migrations;

namespace Serwis.Migrations
{
    public partial class Addinitialentitymodelsrepair4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Companys_CompanyID1",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Customers_CustomerID",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "CustomerID",
                table: "Products",
                newName: "CustomerID1");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CustomerID",
                table: "Products",
                newName: "IX_Products_CustomerID1");

            migrationBuilder.AlterColumn<int>(
                name: "CompanyID1",
                table: "Customers",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Companys_CompanyID1",
                table: "Customers",
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
                name: "FK_Customers_Companys_CompanyID1",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Customers_CustomerID1",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "CustomerID1",
                table: "Products",
                newName: "CustomerID");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CustomerID1",
                table: "Products",
                newName: "IX_Products_CustomerID");

            migrationBuilder.AlterColumn<int>(
                name: "CompanyID1",
                table: "Customers",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Companys_CompanyID1",
                table: "Customers",
                column: "CompanyID1",
                principalTable: "Companys",
                principalColumn: "CompanyID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Customers_CustomerID",
                table: "Products",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
