using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ProjetoTeste.Migrations
{
    /// <inheritdoc />
    public partial class testeMudarNomeTabelaFuncionario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "funcionarios_table");

            migrationBuilder.CreateTable(
                name: "TesteSnakeCase",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "text", nullable: false),
                    idFuncao = table.Column<int>(type: "integer", nullable: false),
                    idade = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TesteSnakeCase", x => x.id);
                    table.UniqueConstraint("AK_TesteSnakeCase_idFuncao", x => x.idFuncao);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TesteSnakeCase");

            migrationBuilder.CreateTable(
                name: "funcionarios_table",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    idFuncao = table.Column<int>(type: "integer", nullable: false),
                    idade = table.Column<int>(type: "integer", nullable: false),
                    nome = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_funcionarios_table", x => x.id);
                });
        }
    }
}
