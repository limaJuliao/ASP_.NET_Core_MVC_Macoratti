using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lanches.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateCarrinhoCompra : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarrinhosCompra",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarrinhosCompra", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarrinhoCompraItens_CarrinhoCompraId",
                table: "CarrinhoCompraItens",
                column: "CarrinhoCompraId");

            migrationBuilder.AddForeignKey(
                name: "FK_CarrinhoCompraItens_CarrinhosCompra_CarrinhoCompraId",
                table: "CarrinhoCompraItens",
                column: "CarrinhoCompraId",
                principalTable: "CarrinhosCompra",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarrinhoCompraItens_CarrinhosCompra_CarrinhoCompraId",
                table: "CarrinhoCompraItens");

            migrationBuilder.DropTable(
                name: "CarrinhosCompra");

            migrationBuilder.DropIndex(
                name: "IX_CarrinhoCompraItens_CarrinhoCompraId",
                table: "CarrinhoCompraItens");
        }
    }
}
