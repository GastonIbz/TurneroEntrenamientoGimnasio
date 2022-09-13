﻿// <auto-generated />
using System;
using Gimnasio.BD.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Gimnasio.BD.Migrations
{
    [DbContext(typeof(BDContext))]
    [Migration("20220912230012_Indices")]
    partial class Indices
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Gimnasio.BD.Data.Entidades.Alumno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("DNI")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<int?>("EntrenamientoId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaModif")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdCreacion")
                        .HasColumnType("int");

                    b.Property<int>("IdModificacion")
                        .HasColumnType("int");

                    b.Property<string>("ImagenPerfil")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("InscripcionId")
                        .HasColumnType("int");

                    b.Property<string>("NombreCompleto")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.HasKey("Id");

                    b.HasIndex("EntrenamientoId");

                    b.HasIndex("InscripcionId");

                    b.HasIndex(new[] { "DNI" }, "AlumnoDNI_UQ")
                        .IsUnique();

                    b.ToTable("TablaAlumnos");
                });

            modelBuilder.Entity("Gimnasio.BD.Data.Entidades.Entrenamiento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaModif")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdCreacion")
                        .HasColumnType("int");

                    b.Property<int>("IdModificacion")
                        .HasColumnType("int");

                    b.Property<int?>("InscripcionId")
                        .HasColumnType("int");

                    b.Property<string>("NombreClase")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("InscripcionId");

                    b.ToTable("TablaEntrenamientos");
                });

            modelBuilder.Entity("Gimnasio.BD.Data.Entidades.Inscripcion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AlumnoId")
                        .HasColumnType("int");

                    b.Property<int?>("EntrenamientoId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaModif")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaTurno")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("HoraTurno")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<int>("IdAlumno")
                        .HasColumnType("int");

                    b.Property<int>("IdCreacion")
                        .HasColumnType("int");

                    b.Property<int>("IdEntrenamiento")
                        .HasColumnType("int");

                    b.Property<int>("IdInscripcion")
                        .HasColumnType("int");

                    b.Property<int>("IdModificacion")
                        .HasColumnType("int");

                    b.Property<int>("IdProfesor")
                        .HasColumnType("int");

                    b.Property<int?>("ProfesorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AlumnoId");

                    b.HasIndex("EntrenamientoId");

                    b.HasIndex("ProfesorId");

                    b.HasIndex(new[] { "IdEntrenamiento", "IdInscripcion" }, "InscripcionEntrenamientoId_UQ")
                        .IsUnique();

                    b.ToTable("TablaInscripciones");
                });

            modelBuilder.Entity("Gimnasio.BD.Data.Entidades.Profesor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("DNI")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<int?>("EntrenamientoId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaModif")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdCreacion")
                        .HasColumnType("int");

                    b.Property<int>("IdModificacion")
                        .HasColumnType("int");

                    b.Property<string>("ImagenPerfil")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("InscripcionId")
                        .HasColumnType("int");

                    b.Property<string>("NombreCompleto")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.HasKey("Id");

                    b.HasIndex("EntrenamientoId");

                    b.HasIndex("InscripcionId");

                    b.HasIndex(new[] { "DNI" }, "ProfesorDNI_UQ")
                        .IsUnique();

                    b.ToTable("TablaProfesores");
                });

            modelBuilder.Entity("Gimnasio.BD.Data.Entidades.Alumno", b =>
                {
                    b.HasOne("Gimnasio.BD.Data.Entidades.Entrenamiento", null)
                        .WithMany("ListaAlumno")
                        .HasForeignKey("EntrenamientoId");

                    b.HasOne("Gimnasio.BD.Data.Entidades.Inscripcion", null)
                        .WithMany("ListaAlumno")
                        .HasForeignKey("InscripcionId");
                });

            modelBuilder.Entity("Gimnasio.BD.Data.Entidades.Entrenamiento", b =>
                {
                    b.HasOne("Gimnasio.BD.Data.Entidades.Inscripcion", null)
                        .WithMany("ListaEntrenamiento")
                        .HasForeignKey("InscripcionId");
                });

            modelBuilder.Entity("Gimnasio.BD.Data.Entidades.Inscripcion", b =>
                {
                    b.HasOne("Gimnasio.BD.Data.Entidades.Alumno", "Alumno")
                        .WithMany()
                        .HasForeignKey("AlumnoId");

                    b.HasOne("Gimnasio.BD.Data.Entidades.Entrenamiento", "Entrenamiento")
                        .WithMany()
                        .HasForeignKey("EntrenamientoId");

                    b.HasOne("Gimnasio.BD.Data.Entidades.Profesor", "Profesor")
                        .WithMany()
                        .HasForeignKey("ProfesorId");

                    b.Navigation("Alumno");

                    b.Navigation("Entrenamiento");

                    b.Navigation("Profesor");
                });

            modelBuilder.Entity("Gimnasio.BD.Data.Entidades.Profesor", b =>
                {
                    b.HasOne("Gimnasio.BD.Data.Entidades.Entrenamiento", null)
                        .WithMany("ListaProfesor")
                        .HasForeignKey("EntrenamientoId");

                    b.HasOne("Gimnasio.BD.Data.Entidades.Inscripcion", null)
                        .WithMany("ListaProfesor")
                        .HasForeignKey("InscripcionId");
                });

            modelBuilder.Entity("Gimnasio.BD.Data.Entidades.Entrenamiento", b =>
                {
                    b.Navigation("ListaAlumno");

                    b.Navigation("ListaProfesor");
                });

            modelBuilder.Entity("Gimnasio.BD.Data.Entidades.Inscripcion", b =>
                {
                    b.Navigation("ListaAlumno");

                    b.Navigation("ListaEntrenamiento");

                    b.Navigation("ListaProfesor");
                });
#pragma warning restore 612, 618
        }
    }
}
