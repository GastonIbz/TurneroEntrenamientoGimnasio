using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gimnasio.BD.Migrations
{
    public partial class change4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TablaAlumnos_TablaEntrenamientos_EntrenamientoId",
                table: "TablaAlumnos");

            migrationBuilder.DropForeignKey(
                name: "FK_TablaProfesores_TablaEntrenamientos_EntrenamientoId",
                table: "TablaProfesores");

            migrationBuilder.DropForeignKey(
                name: "FK_TablaProfesores_TablaInscripciones_InscripcionId",
                table: "TablaProfesores");

            migrationBuilder.DropIndex(
                name: "IX_TablaProfesores_EntrenamientoId",
                table: "TablaProfesores");

            migrationBuilder.DropIndex(
                name: "IX_TablaProfesores_InscripcionId",
                table: "TablaProfesores");

            migrationBuilder.DropIndex(
                name: "IX_TablaAlumnos_EntrenamientoId",
                table: "TablaAlumnos");

            migrationBuilder.DropColumn(
                name: "EntrenamientoId",
                table: "TablaProfesores");

            migrationBuilder.DropColumn(
                name: "InscripcionId",
                table: "TablaProfesores");

            migrationBuilder.DropColumn(
                name: "EntrenamientoId",
                table: "TablaAlumnos");

            migrationBuilder.AddColumn<int>(
                name: "AlumnoId",
                table: "TablaEntrenamientos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "InscripcionProfesor",
                columns: table => new
                {
                    ListaInscripcionId = table.Column<int>(type: "int", nullable: false),
                    ListaProfesorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InscripcionProfesor", x => new { x.ListaInscripcionId, x.ListaProfesorId });
                    table.ForeignKey(
                        name: "FK_InscripcionProfesor_TablaInscripciones_ListaInscripcionId",
                        column: x => x.ListaInscripcionId,
                        principalTable: "TablaInscripciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InscripcionProfesor_TablaProfesores_ListaProfesorId",
                        column: x => x.ListaProfesorId,
                        principalTable: "TablaProfesores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InscripcionProfesor_ListaProfesorId",
                table: "InscripcionProfesor",
                column: "ListaProfesorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InscripcionProfesor");

            migrationBuilder.DropColumn(
                name: "AlumnoId",
                table: "TablaEntrenamientos");

            migrationBuilder.AddColumn<int>(
                name: "EntrenamientoId",
                table: "TablaProfesores",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InscripcionId",
                table: "TablaProfesores",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EntrenamientoId",
                table: "TablaAlumnos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TablaProfesores_EntrenamientoId",
                table: "TablaProfesores",
                column: "EntrenamientoId");

            migrationBuilder.CreateIndex(
                name: "IX_TablaProfesores_InscripcionId",
                table: "TablaProfesores",
                column: "InscripcionId");

            migrationBuilder.CreateIndex(
                name: "IX_TablaAlumnos_EntrenamientoId",
                table: "TablaAlumnos",
                column: "EntrenamientoId");

            migrationBuilder.AddForeignKey(
                name: "FK_TablaAlumnos_TablaEntrenamientos_EntrenamientoId",
                table: "TablaAlumnos",
                column: "EntrenamientoId",
                principalTable: "TablaEntrenamientos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TablaProfesores_TablaEntrenamientos_EntrenamientoId",
                table: "TablaProfesores",
                column: "EntrenamientoId",
                principalTable: "TablaEntrenamientos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TablaProfesores_TablaInscripciones_InscripcionId",
                table: "TablaProfesores",
                column: "InscripcionId",
                principalTable: "TablaInscripciones",
                principalColumn: "Id");
        }
    }
}
