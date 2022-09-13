using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gimnasio.BD.Migrations
{
    public partial class Indices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdInscripcion",
                table: "TablaInscripciones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "NombreClase",
                table: "TablaEntrenamientos",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.CreateIndex(
                name: "InscripcionEntrenamientoId_UQ",
                table: "TablaInscripciones",
                columns: new[] { "IdEntrenamiento", "IdInscripcion" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "InscripcionEntrenamientoId_UQ",
                table: "TablaInscripciones");

            migrationBuilder.DropColumn(
                name: "IdInscripcion",
                table: "TablaInscripciones");

            migrationBuilder.AlterColumn<string>(
                name: "NombreClase",
                table: "TablaEntrenamientos",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);
        }
    }
}
