using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoTeste.Migrations
{
    /// <inheritdoc />
    public partial class MudandoNomeTabela : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Funcionarios",
                table: "Funcionarios");

            migrationBuilder.RenameTable(
                name: "Funcionarios",
                newName: "funcionarios_table");

            migrationBuilder.AddPrimaryKey(
                name: "PK_funcionarios_table",
                table: "funcionarios_table",
                column: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_funcionarios_table",
                table: "funcionarios_table");

            migrationBuilder.RenameTable(
                name: "funcionarios_table",
                newName: "Funcionarios");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Funcionarios",
                table: "Funcionarios",
                column: "id");
        }
    }
}
