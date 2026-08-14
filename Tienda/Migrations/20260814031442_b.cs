using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tienda.Migrations
{
    /// <inheritdoc />
    public partial class b : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_AspNetUsers_ClienteId",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Productos_ClienteId",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Productos");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ClienteId",
                table: "Productos",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Productos_ClienteId",
                table: "Productos",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_AspNetUsers_ClienteId",
                table: "Productos",
                column: "ClienteId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
