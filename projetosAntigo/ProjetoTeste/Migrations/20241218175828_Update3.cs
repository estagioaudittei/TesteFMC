using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ProjetoTeste.Migrations
{
    /// <inheritdoc />
    public partial class Update3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TesteSnakeCase",
                table: "TesteSnakeCase");

            migrationBuilder.RenameTable(
                name: "TesteSnakeCase",
                newName: "funcionarios_table");

            migrationBuilder.RenameColumn(
                name: "FuncaoID",
                table: "Funcoes",
                newName: "renomeando_coluna_id_funcao");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "funcionarios_table",
                newName: "nome_codificado_kkk");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "funcionarios_table",
                newName: "mudando_coluna_idfuncionario");

            migrationBuilder.AlterColumn<int>(
                name: "renomeando_coluna_id_funcao",
                table: "Funcoes",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "nome_codificado_kkk",
                table: "funcionarios_table",
                type: "varchar",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<long>(
                name: "mudando_coluna_idfuncionario",
                table: "funcionarios_table",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_funcionarios_table",
                table: "funcionarios_table",
                column: "mudando_coluna_idfuncionario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_funcionarios_table",
                table: "funcionarios_table");

            migrationBuilder.RenameTable(
                name: "funcionarios_table",
                newName: "TesteSnakeCase");

            migrationBuilder.RenameColumn(
                name: "renomeando_coluna_id_funcao",
                table: "Funcoes",
                newName: "FuncaoID");

            migrationBuilder.RenameColumn(
                name: "nome_codificado_kkk",
                table: "TesteSnakeCase",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "mudando_coluna_idfuncionario",
                table: "TesteSnakeCase",
                newName: "id");

            migrationBuilder.AlterColumn<int>(
                name: "FuncaoID",
                table: "Funcoes",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "TesteSnakeCase",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "TesteSnakeCase",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TesteSnakeCase",
                table: "TesteSnakeCase",
                column: "id");
        }
    }
}
