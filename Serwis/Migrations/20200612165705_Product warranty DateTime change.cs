using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Serwis.Migrations
{
    public partial class ProductwarrantyDateTimechange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ProductWarranty",
                table: "Products",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ProductWarranty",
                table: "Products",
                nullable: true,
                oldClrType: typeof(DateTime));
        }
    }
}
