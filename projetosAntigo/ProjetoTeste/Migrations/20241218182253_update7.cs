using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoTeste.Migrations
{
    /// <inheritdoc />
    public partial class update7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "nome_codificado_kkk",
                table: "funcionarios_table",
                type: "varchar",
                nullable: true,
                defaultValueSql: "gen_random_uuid()",
                oldClrType: typeof(string),
                oldType: "varchar",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "nome_codificado_kkk",
                table: "funcionarios_table",
                type: "varchar",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar",
                oldNullable: true,
                oldDefaultValueSql: "gen_random_uuid()");
        }
    }
}
