using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tienda.Migrations
{
    /// <inheritdoc />
    public partial class pp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Productos_ProductoId",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Productos_ProductoId",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "ProductoId",
                table: "Productos");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductoId",
                table: "Productos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Productos_ProductoId",
                table: "Productos",
                column: "ProductoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Productos_ProductoId",
                table: "Productos",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "Id");
        }
    }
}
