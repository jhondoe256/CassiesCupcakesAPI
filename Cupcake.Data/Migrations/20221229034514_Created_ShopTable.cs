using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cupcake.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreatedShopTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Shops",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ShopId",
                table: "CupCakes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CupCakes_ShopId",
                table: "CupCakes",
                column: "ShopId");

            migrationBuilder.AddForeignKey(
                name: "FK_CupCakes_Shops_ShopId",
                table: "CupCakes",
                column: "ShopId",
                principalTable: "Shops",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CupCakes_Shops_ShopId",
                table: "CupCakes");

            migrationBuilder.DropIndex(
                name: "IX_CupCakes_ShopId",
                table: "CupCakes");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Shops");

            migrationBuilder.DropColumn(
                name: "ShopId",
                table: "CupCakes");
        }
    }
}
