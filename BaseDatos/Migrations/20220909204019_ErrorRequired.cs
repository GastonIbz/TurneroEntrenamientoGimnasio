using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gimnasio.BD.Migrations
{
    public partial class ErrorRequired : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModif",
                table: "TablaProfesores",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdCreacion",
                table: "TablaProfesores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdModificacion",
                table: "TablaProfesores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModif",
                table: "TablaInscripciones",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdCreacion",
                table: "TablaInscripciones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdModificacion",
                table: "TablaInscripciones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModif",
                table: "TablaEntrenamientos",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdCreacion",
                table: "TablaEntrenamientos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdModificacion",
                table: "TablaEntrenamientos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModif",
                table: "TablaAlumnos",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdCreacion",
                table: "TablaAlumnos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdModificacion",
                table: "TablaAlumnos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaModif",
                table: "TablaProfesores");

            migrationBuilder.DropColumn(
                name: "IdCreacion",
                table: "TablaProfesores");

            migrationBuilder.DropColumn(
                name: "IdModificacion",
                table: "TablaProfesores");

            migrationBuilder.DropColumn(
                name: "FechaModif",
                table: "TablaInscripciones");

            migrationBuilder.DropColumn(
                name: "IdCreacion",
                table: "TablaInscripciones");

            migrationBuilder.DropColumn(
                name: "IdModificacion",
                table: "TablaInscripciones");

            migrationBuilder.DropColumn(
                name: "FechaModif",
                table: "TablaEntrenamientos");

            migrationBuilder.DropColumn(
                name: "IdCreacion",
                table: "TablaEntrenamientos");

            migrationBuilder.DropColumn(
                name: "IdModificacion",
                table: "TablaEntrenamientos");

            migrationBuilder.DropColumn(
                name: "FechaModif",
                table: "TablaAlumnos");

            migrationBuilder.DropColumn(
                name: "IdCreacion",
                table: "TablaAlumnos");

            migrationBuilder.DropColumn(
                name: "IdModificacion",
                table: "TablaAlumnos");
        }
    }
}
