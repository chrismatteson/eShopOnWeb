using Microsoft.EntityFrameworkCore.Migrations;

namespace Microsoft.eShopWeb.Infrastructure.Data.Migrations
{
    public partial class UpdatedConstraints : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Catalog_CatalogBrand_CatalogBrandId",
                table: "Catalog");

            migrationBuilder.DropForeignKey(
                name: "FK_Catalog_CatalogType_CatalogTypeId",
                table: "Catalog");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CatalogType",
                table: "CatalogType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CatalogBrand",
                table: "CatalogBrand");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CatalogTypes",
                table: "CatalogType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CatalogBrands",
                table: "CatalogBrand",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Catalog_CatalogBrands_CatalogBrandId",
                table: "Catalog",
                column: "CatalogBrandId",
                principalTable: "CatalogBrand",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Catalog_CatalogTypes_CatalogTypeId",
                table: "Catalog",
                column: "CatalogTypeId",
                principalTable: "CatalogType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Catalog_CatalogBrands_CatalogBrandId",
                table: "Catalog");

            migrationBuilder.DropForeignKey(
                name: "FK_Catalog_CatalogTypes_CatalogTypeId",
                table: "Catalog");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CatalogTypes",
                table: "CatalogType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CatalogBrands",
                table: "CatalogBrand");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CatalogType",
                table: "CatalogType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CatalogBrand",
                table: "CatalogBrand",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Catalog_CatalogBrand_CatalogBrandId",
                table: "Catalog",
                column: "CatalogBrandId",
                principalTable: "CatalogBrand",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Catalog_CatalogType_CatalogTypeId",
                table: "Catalog",
                column: "CatalogTypeId",
                principalTable: "CatalogType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
