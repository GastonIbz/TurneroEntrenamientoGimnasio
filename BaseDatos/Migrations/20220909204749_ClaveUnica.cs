using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gimnasio.BD.Migrations
{
    public partial class ClaveUnica : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "ProfesorDNI_UQ",
                table: "TablaProfesores",
                column: "DNI",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "AlumnoDNI_UQ",
                table: "TablaAlumnos",
                column: "DNI",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "ProfesorDNI_UQ",
                table: "TablaProfesores");

            migrationBuilder.DropIndex(
                name: "AlumnoDNI_UQ",
                table: "TablaAlumnos");
        }
    }
}
