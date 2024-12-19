using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ProjetoTeste.Migrations
{
    /// <inheritdoc />
    public partial class update01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "renomeando_coluna_id_funcao",
                table: "Funcoes",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn);

            migrationBuilder.CreateIndex(
                name: "IX_funcionarios_table_idFuncao",
                table: "funcionarios_table",
                column: "idFuncao");

            migrationBuilder.CreateIndex(
                name: "IX_funcionarios_table_mudando_coluna_idfuncionario",
                table: "funcionarios_table",
                column: "mudando_coluna_idfuncionario")
                .Annotation("Npgsql:IndexInclude", new[] { "nome_codificado_kkk" });

            migrationBuilder.AddForeignKey(
                name: "FK_funcionarios_table_Funcoes_idFuncao",
                table: "funcionarios_table",
                column: "idFuncao",
                principalTable: "Funcoes",
                principalColumn: "renomeando_coluna_id_funcao",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_funcionarios_table_Funcoes_idFuncao",
                table: "funcionarios_table");

            migrationBuilder.DropIndex(
                name: "IX_funcionarios_table_idFuncao",
                table: "funcionarios_table");

            migrationBuilder.DropIndex(
                name: "IX_funcionarios_table_mudando_coluna_idfuncionario",
                table: "funcionarios_table");

            migrationBuilder.AlterColumn<int>(
                name: "renomeando_coluna_id_funcao",
                table: "Funcoes",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);
        }
    }
}
