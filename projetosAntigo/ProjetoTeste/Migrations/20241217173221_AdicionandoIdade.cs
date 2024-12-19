using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoTeste.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandoIdade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "idade",
                table: "Funcionarios",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "idade",
                table: "Funcionarios");
        }
    }
}
