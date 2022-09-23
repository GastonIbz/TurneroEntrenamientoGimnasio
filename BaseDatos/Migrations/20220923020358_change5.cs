using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gimnasio.BD.Migrations
{
    public partial class change5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AlumnoId",
                table: "TablaEntrenamientos");

            migrationBuilder.CreateIndex(
                name: "IX_TablaEntrenamientos_ProfesorId",
                table: "TablaEntrenamientos",
                column: "ProfesorId");

            migrationBuilder.AddForeignKey(
                name: "FK_TablaEntrenamientos_TablaProfesores_ProfesorId",
                table: "TablaEntrenamientos",
                column: "ProfesorId",
                principalTable: "TablaProfesores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TablaEntrenamientos_TablaProfesores_ProfesorId",
                table: "TablaEntrenamientos");

            migrationBuilder.DropIndex(
                name: "IX_TablaEntrenamientos_ProfesorId",
                table: "TablaEntrenamientos");

            migrationBuilder.AddColumn<int>(
                name: "AlumnoId",
                table: "TablaEntrenamientos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
