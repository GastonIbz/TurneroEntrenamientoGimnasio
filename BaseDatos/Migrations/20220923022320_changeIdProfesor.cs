using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gimnasio.BD.Migrations
{
    public partial class changeIdProfesor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TablaEntrenamientos_TablaProfesores_ProfesorId",
                table: "TablaEntrenamientos");

            migrationBuilder.AddColumn<int>(
                name: "ProfesorId",
                table: "TablaInscripciones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "ProfesorId",
                table: "TablaEntrenamientos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_TablaEntrenamientos_TablaProfesores_ProfesorId",
                table: "TablaEntrenamientos",
                column: "ProfesorId",
                principalTable: "TablaProfesores",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TablaEntrenamientos_TablaProfesores_ProfesorId",
                table: "TablaEntrenamientos");

            migrationBuilder.DropColumn(
                name: "ProfesorId",
                table: "TablaInscripciones");

            migrationBuilder.AlterColumn<int>(
                name: "ProfesorId",
                table: "TablaEntrenamientos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TablaEntrenamientos_TablaProfesores_ProfesorId",
                table: "TablaEntrenamientos",
                column: "ProfesorId",
                principalTable: "TablaProfesores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
