using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Escola.Migrations
{
    /// <inheritdoc />
    public partial class teste1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aulas_Professores_ProfessorId",
                table: "Aulas");

            migrationBuilder.DropForeignKey(
                name: "FK_Materias_Professores_ProfessorId",
                table: "Materias");

            migrationBuilder.RenameColumn(
                name: "ProfessorId",
                table: "Materias",
                newName: "id_do_professor");

            migrationBuilder.RenameIndex(
                name: "IX_Materias_ProfessorId",
                table: "Materias",
                newName: "IX_Materias_id_do_professor");

            migrationBuilder.AlterColumn<int>(
                name: "id_do_professor",
                table: "Materias",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "id_curso_qtsHein",
                table: "Materias",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "ProfessorId",
                table: "Aulas",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Aulas_Professores_ProfessorId",
                table: "Aulas",
                column: "ProfessorId",
                principalTable: "Professores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Materias_Professores_id_do_professor",
                table: "Materias",
                column: "id_do_professor",
                principalTable: "Professores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aulas_Professores_ProfessorId",
                table: "Aulas");

            migrationBuilder.DropForeignKey(
                name: "FK_Materias_Professores_id_do_professor",
                table: "Materias");

            migrationBuilder.DropColumn(
                name: "id_curso_qtsHein",
                table: "Materias");

            migrationBuilder.RenameColumn(
                name: "id_do_professor",
                table: "Materias",
                newName: "ProfessorId");

            migrationBuilder.RenameIndex(
                name: "IX_Materias_id_do_professor",
                table: "Materias",
                newName: "IX_Materias_ProfessorId");

            migrationBuilder.AlterColumn<int>(
                name: "ProfessorId",
                table: "Materias",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "ProfessorId",
                table: "Aulas",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_Aulas_Professores_ProfessorId",
                table: "Aulas",
                column: "ProfessorId",
                principalTable: "Professores",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Materias_Professores_ProfessorId",
                table: "Materias",
                column: "ProfessorId",
                principalTable: "Professores",
                principalColumn: "Id");
        }
    }
}
