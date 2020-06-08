using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Serwis.Migrations
{
    public partial class Addinitialentitymodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CompanyPhone",
                table: "Companys",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CompanyPassword",
                table: "Companys",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CompanyName",
                table: "Companys",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CompanyLogin",
                table: "Companys",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CompanyEmail",
                table: "Companys",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CompanyAddress",
                table: "Companys",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustomerLogin = table.Column<string>(nullable: false),
                    CustomerPassword = table.Column<string>(nullable: false),
                    CustomerName = table.Column<string>(nullable: false),
                    CustomerVorname = table.Column<string>(nullable: false),
                    CustomerAddress = table.Column<string>(nullable: true),
                    CustomerPhone = table.Column<string>(nullable: true),
                    CustomerEmail = table.Column<string>(nullable: true),
                    CompanyID1 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                    table.ForeignKey(
                        name: "FK_Customers_Companys_CompanyID1",
                        column: x => x.CompanyID1,
                        principalTable: "Companys",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employers",
                columns: table => new
                {
                    EmployerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmployerLogin = table.Column<string>(nullable: false),
                    EmployerPassword = table.Column<string>(nullable: false),
                    EmployerName = table.Column<string>(nullable: false),
                    EmployerVorname = table.Column<string>(nullable: false),
                    EmployerPhone = table.Column<string>(nullable: true),
                    EmployerEmail = table.Column<string>(nullable: true),
                    Specialist = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employers", x => x.EmployerID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProductCategory = table.Column<string>(nullable: true),
                    ProductName = table.Column<string>(nullable: false),
                    ProductDescription = table.Column<string>(nullable: true),
                    ProductState = table.Column<string>(nullable: false),
                    ProductWarranty = table.Column<string>(nullable: true),
                    CompanyID1 = table.Column<int>(nullable: false),
                    CustomerID1 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Products_Companys_CompanyID1",
                        column: x => x.CompanyID1,
                        principalTable: "Companys",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Customers_CustomerID1",
                        column: x => x.CustomerID1,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Complaints",
                columns: table => new
                {
                    ComplaintID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ComplainDescription = table.Column<string>(nullable: false),
                    FixDescription = table.Column<string>(nullable: true),
                    ProductID1 = table.Column<int>(nullable: false),
                    EmployerID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Complaints", x => x.ComplaintID);
                    table.ForeignKey(
                        name: "FK_Complaints_Employers_EmployerID1",
                        column: x => x.EmployerID1,
                        principalTable: "Employers",
                        principalColumn: "EmployerID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Complaints_Products_ProductID1",
                        column: x => x.ProductID1,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Complaints_EmployerID1",
                table: "Complaints",
                column: "EmployerID1");

            migrationBuilder.CreateIndex(
                name: "IX_Complaints_ProductID1",
                table: "Complaints",
                column: "ProductID1");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CompanyID1",
                table: "Customers",
                column: "CompanyID1");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CompanyID1",
                table: "Products",
                column: "CompanyID1");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CustomerID1",
                table: "Products",
                column: "CustomerID1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Complaints");

            migrationBuilder.DropTable(
                name: "Employers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.AlterColumn<string>(
                name: "CompanyPhone",
                table: "Companys",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "CompanyPassword",
                table: "Companys",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "CompanyName",
                table: "Companys",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "CompanyLogin",
                table: "Companys",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "CompanyEmail",
                table: "Companys",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "CompanyAddress",
                table: "Companys",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
