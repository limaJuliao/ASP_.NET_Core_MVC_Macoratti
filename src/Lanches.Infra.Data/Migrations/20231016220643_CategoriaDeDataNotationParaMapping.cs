using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lanches.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class CategoriaDeDataNotationParaMapping : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Itens",
                newName: "LancheId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LancheId",
                table: "Itens",
                newName: "Id");
        }
    }
}
