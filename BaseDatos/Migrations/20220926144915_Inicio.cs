using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gimnasio.BD.Migrations
{
    public partial class Inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TablaAlumnos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DNI = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    NombreCompleto = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ImagenPerfil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModificacionId = table.Column<int>(type: "int", nullable: false),
                    FechaModif = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreacionId = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TablaAlumnos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TablaInscripciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlumnoId = table.Column<int>(type: "int", nullable: false),
                    EntrenamientoId = table.Column<int>(type: "int", nullable: false),
                    InscripcionId = table.Column<int>(type: "int", nullable: false),
                    FechaTurno = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HoraTurno = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModificacionId = table.Column<int>(type: "int", nullable: false),
                    FechaModif = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreacionId = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TablaInscripciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TablaProfesores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DNI = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    NombreCompleto = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ImagenPerfil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModificacionId = table.Column<int>(type: "int", nullable: false),
                    FechaModif = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreacionId = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TablaProfesores", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "TablaEntrenamientos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfesorId = table.Column<int>(type: "int", nullable: false),
                    NombreClase = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    InscripcionId = table.Column<int>(type: "int", nullable: true),
                    ModificacionId = table.Column<int>(type: "int", nullable: false),
                    FechaModif = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreacionId = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TablaEntrenamientos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TablaEntrenamientos_TablaInscripciones_InscripcionId",
                        column: x => x.InscripcionId,
                        principalTable: "TablaInscripciones",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TablaEntrenamientos_TablaProfesores_ProfesorId",
                        column: x => x.ProfesorId,
                        principalTable: "TablaProfesores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AlumnoInscripcion_ListaInscripcionId",
                table: "AlumnoInscripcion",
                column: "ListaInscripcionId");

            migrationBuilder.CreateIndex(
                name: "IX_InscripcionProfesor_ListaProfesorId",
                table: "InscripcionProfesor",
                column: "ListaProfesorId");

            migrationBuilder.CreateIndex(
                name: "AlumnoDNI_UQ",
                table: "TablaAlumnos",
                column: "DNI",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TablaEntrenamientos_InscripcionId",
                table: "TablaEntrenamientos",
                column: "InscripcionId");

            migrationBuilder.CreateIndex(
                name: "IX_TablaEntrenamientos_ProfesorId",
                table: "TablaEntrenamientos",
                column: "ProfesorId");

            migrationBuilder.CreateIndex(
                name: "InscripcionEntrenamientoId_UQ",
                table: "TablaInscripciones",
                columns: new[] { "EntrenamientoId", "InscripcionId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ProfesorDNI_UQ",
                table: "TablaProfesores",
                column: "DNI",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlumnoInscripcion");

            migrationBuilder.DropTable(
                name: "InscripcionProfesor");

            migrationBuilder.DropTable(
                name: "TablaEntrenamientos");

            migrationBuilder.DropTable(
                name: "TablaAlumnos");

            migrationBuilder.DropTable(
                name: "TablaInscripciones");

            migrationBuilder.DropTable(
                name: "TablaProfesores");
        }
    }
}
