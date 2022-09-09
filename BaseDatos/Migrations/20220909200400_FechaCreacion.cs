using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gimnasio.BD.Migrations
{
    public partial class FechaCreacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaTurno",
                table: "TablaProfesores");

            migrationBuilder.DropColumn(
                name: "FechaTurno",
                table: "TablaEntrenamientos");

            migrationBuilder.DropColumn(
                name: "FechaTurno",
                table: "TablaAlumnos");

            migrationBuilder.RenameColumn(
                name: "HoraTurno",
                table: "TablaProfesores",
                newName: "FechaCreacion");

            migrationBuilder.RenameColumn(
                name: "HoraTurno",
                table: "TablaEntrenamientos",
                newName: "FechaCreacion");

            migrationBuilder.RenameColumn(
                name: "HoraTurno",
                table: "TablaAlumnos",
                newName: "FechaCreacion");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreacion",
                table: "TablaInscripciones",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "TablaInscripciones");

            migrationBuilder.RenameColumn(
                name: "FechaCreacion",
                table: "TablaProfesores",
                newName: "HoraTurno");

            migrationBuilder.RenameColumn(
                name: "FechaCreacion",
                table: "TablaEntrenamientos",
                newName: "HoraTurno");

            migrationBuilder.RenameColumn(
                name: "FechaCreacion",
                table: "TablaAlumnos",
                newName: "HoraTurno");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaTurno",
                table: "TablaProfesores",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaTurno",
                table: "TablaEntrenamientos",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaTurno",
                table: "TablaAlumnos",
                type: "datetime2",
                nullable: true);
        }
    }
}
