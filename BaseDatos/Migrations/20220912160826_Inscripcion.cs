using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gimnasio.BD.Migrations
{
    public partial class Inscripcion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InscripcionId",
                table: "TablaProfesores",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TablaProfesores_InscripcionId",
                table: "TablaProfesores",
                column: "InscripcionId");

            migrationBuilder.AddForeignKey(
                name: "FK_TablaProfesores_TablaInscripciones_InscripcionId",
                table: "TablaProfesores",
                column: "InscripcionId",
                principalTable: "TablaInscripciones",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TablaProfesores_TablaInscripciones_InscripcionId",
                table: "TablaProfesores");

            migrationBuilder.DropIndex(
                name: "IX_TablaProfesores_InscripcionId",
                table: "TablaProfesores");

            migrationBuilder.DropColumn(
                name: "InscripcionId",
                table: "TablaProfesores");
        }
    }
}
