using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Escola.Migrations
{
    /// <inheritdoc />
    public partial class t2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aulas_Cursos_CursoId",
                table: "Aulas");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Aulas",
                newName: "nome_aula");

            migrationBuilder.RenameColumn(
                name: "CursoId",
                table: "Aulas",
                newName: "id_curso");

            migrationBuilder.RenameIndex(
                name: "IX_Aulas_CursoId",
                table: "Aulas",
                newName: "IX_Aulas_id_curso");

            migrationBuilder.AlterColumn<string>(
                name: "nome_aula",
                table: "Aulas",
                type: "VARCHAR",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<int>(
                name: "id_curso",
                table: "Aulas",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Aulas_Cursos_id_curso",
                table: "Aulas",
                column: "id_curso",
                principalTable: "Cursos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aulas_Cursos_id_curso",
                table: "Aulas");

            migrationBuilder.RenameColumn(
                name: "nome_aula",
                table: "Aulas",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "id_curso",
                table: "Aulas",
                newName: "CursoId");

            migrationBuilder.RenameIndex(
                name: "IX_Aulas_id_curso",
                table: "Aulas",
                newName: "IX_Aulas_CursoId");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Aulas",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR");

            migrationBuilder.AlterColumn<int>(
                name: "CursoId",
                table: "Aulas",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_Aulas_Cursos_CursoId",
                table: "Aulas",
                column: "CursoId",
                principalTable: "Cursos",
                principalColumn: "Id");
        }
    }
}
