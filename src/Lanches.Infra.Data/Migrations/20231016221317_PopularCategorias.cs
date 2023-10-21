using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lanches.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class PopularCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"INSERT INTO Categorias(Nome, Descricao)
                                    VALUES('Normal', 'Item feito com ingredientes normais')");

            migrationBuilder.Sql(@"INSERT INTO Categorias(Nome, Descricao)
                                    VALUES('Natural', 'Item feito com ingredientes integrais e naturais')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
