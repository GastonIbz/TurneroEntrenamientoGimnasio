using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gimnasio.BD.Migrations
{
    public partial class change2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TablaAlumnos_TablaInscripciones_InscripcionId",
                table: "TablaAlumnos");

            migrationBuilder.DropIndex(
                name: "InscripcionEntrenamientoId_UQ",
                table: "TablaInscripciones");

            migrationBuilder.DropIndex(
                name: "IX_TablaAlumnos_InscripcionId",
                table: "TablaAlumnos");

            migrationBuilder.DropColumn(
                name: "IdAlumno",
                table: "TablaInscripciones");

            migrationBuilder.DropColumn(
                name: "InscripcionId",
                table: "TablaAlumnos");

            migrationBuilder.RenameColumn(
                name: "IdModificacion",
                table: "TablaProfesores",
                newName: "ModificacionId");

            migrationBuilder.RenameColumn(
                name: "IdCreacion",
                table: "TablaProfesores",
                newName: "CreacionId");

            migrationBuilder.RenameColumn(
                name: "IdProfesor",
                table: "TablaInscripciones",
                newName: "ModificacionId");

            migrationBuilder.RenameColumn(
                name: "IdModificacion",
                table: "TablaInscripciones",
                newName: "InscripcionId");

            migrationBuilder.RenameColumn(
                name: "IdInscripcion",
                table: "TablaInscripciones",
                newName: "EntrenamientoId");

            migrationBuilder.RenameColumn(
                name: "IdEntrenamiento",
                table: "TablaInscripciones",
                newName: "CreacionId");

            migrationBuilder.RenameColumn(
                name: "IdCreacion",
                table: "TablaInscripciones",
                newName: "AlumnoId");

            migrationBuilder.RenameColumn(
                name: "IdModificacion",
                table: "TablaEntrenamientos",
                newName: "ProfesorId");

            migrationBuilder.RenameColumn(
                name: "IdCreacion",
                table: "TablaEntrenamientos",
                newName: "ModificacionId");

            migrationBuilder.RenameColumn(
                name: "IdModificacion",
                table: "TablaAlumnos",
                newName: "ModificacionId");

            migrationBuilder.RenameColumn(
                name: "IdCreacion",
                table: "TablaAlumnos",
                newName: "CreacionId");

            migrationBuilder.AddColumn<int>(
                name: "CreacionId",
                table: "TablaEntrenamientos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AlumnoInscripcion",
                columns: table => new
                {
                    ListaAlumnoId = table.Column<int>(type: "int", nullable: false),
                    ListaInscripcionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlumnoInscripcion", x => new { x.ListaAlumnoId, x.ListaInscripcionId });
                    table.ForeignKey(
                        name: "FK_AlumnoInscripcion_TablaAlumnos_ListaAlumnoId",
                        column: x => x.ListaAlumnoId,
                        principalTable: "TablaAlumnos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlumnoInscripcion_TablaInscripciones_ListaInscripcionId",
                        column: x => x.ListaInscripcionId,
                        principalTable: "TablaInscripciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "InscripcionEntrenamientoId_UQ",
                table: "TablaInscripciones",
                columns: new[] { "EntrenamientoId", "InscripcionId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AlumnoInscripcion_ListaInscripcionId",
                table: "AlumnoInscripcion",
                column: "ListaInscripcionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlumnoInscripcion");

            migrationBuilder.DropIndex(
                name: "InscripcionEntrenamientoId_UQ",
                table: "TablaInscripciones");

            migrationBuilder.DropColumn(
                name: "CreacionId",
                table: "TablaEntrenamientos");

            migrationBuilder.RenameColumn(
                name: "ModificacionId",
                table: "TablaProfesores",
                newName: "IdModificacion");

            migrationBuilder.RenameColumn(
                name: "CreacionId",
                table: "TablaProfesores",
                newName: "IdCreacion");

            migrationBuilder.RenameColumn(
                name: "ModificacionId",
                table: "TablaInscripciones",
                newName: "IdProfesor");

            migrationBuilder.RenameColumn(
                name: "InscripcionId",
                table: "TablaInscripciones",
                newName: "IdModificacion");

            migrationBuilder.RenameColumn(
                name: "EntrenamientoId",
                table: "TablaInscripciones",
                newName: "IdInscripcion");

            migrationBuilder.RenameColumn(
                name: "CreacionId",
                table: "TablaInscripciones",
                newName: "IdEntrenamiento");

            migrationBuilder.RenameColumn(
                name: "AlumnoId",
                table: "TablaInscripciones",
                newName: "IdCreacion");

            migrationBuilder.RenameColumn(
                name: "ProfesorId",
                table: "TablaEntrenamientos",
                newName: "IdModificacion");

            migrationBuilder.RenameColumn(
                name: "ModificacionId",
                table: "TablaEntrenamientos",
                newName: "IdCreacion");

            migrationBuilder.RenameColumn(
                name: "ModificacionId",
                table: "TablaAlumnos",
                newName: "IdModificacion");

            migrationBuilder.RenameColumn(
                name: "CreacionId",
                table: "TablaAlumnos",
                newName: "IdCreacion");

            migrationBuilder.AddColumn<int>(
                name: "IdAlumno",
                table: "TablaInscripciones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InscripcionId",
                table: "TablaAlumnos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "InscripcionEntrenamientoId_UQ",
                table: "TablaInscripciones",
                columns: new[] { "IdEntrenamiento", "IdInscripcion" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TablaAlumnos_InscripcionId",
                table: "TablaAlumnos",
                column: "InscripcionId");

            migrationBuilder.AddForeignKey(
                name: "FK_TablaAlumnos_TablaInscripciones_InscripcionId",
                table: "TablaAlumnos",
                column: "InscripcionId",
                principalTable: "TablaInscripciones",
                principalColumn: "Id");
        }
    }
}
