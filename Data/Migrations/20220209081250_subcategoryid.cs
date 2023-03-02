using Microsoft.EntityFrameworkCore.Migrations;

namespace EShop.Data.Migrations
{
    public partial class subcategoryid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductSubCategoryId",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductSubCategoryId",
                table: "Products",
                column: "ProductSubCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_SubCategories_ProductSubCategoryId",
                table: "Products",
                column: "ProductSubCategoryId",
                principalTable: "SubCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_SubCategories_ProductSubCategoryId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductSubCategoryId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductSubCategoryId",
                table: "Products");
        }
    }
}
