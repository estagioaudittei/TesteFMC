using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoTeste.Migrations
{
    /// <inheritdoc />
    public partial class removendoHasAlternateKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_TesteSnakeCase_idFuncao",
                table: "TesteSnakeCase");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddUniqueConstraint(
                name: "AK_TesteSnakeCase_idFuncao",
                table: "TesteSnakeCase",
                column: "idFuncao");
        }
    }
}
