﻿// <auto-generated />
using System;
using Gimnasio.BD.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Gimnasio.BD.Migrations
{
    [DbContext(typeof(BDContext))]
    partial class BDContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AlumnoInscripcion", b =>
                {
                    b.Property<int>("ListaAlumnoId")
                        .HasColumnType("int");

                    b.Property<int>("ListaInscripcionId")
                        .HasColumnType("int");

                    b.HasKey("ListaAlumnoId", "ListaInscripcionId");

                    b.HasIndex("ListaInscripcionId");

                    b.ToTable("AlumnoInscripcion");
                });

            modelBuilder.Entity("Gimnasio.BD.Data.Entidades.Alumno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CreacionId")
                        .HasColumnType("int");

                    b.Property<string>("DNI")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<DateTime?>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaModif")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImagenPerfil")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ModificacionId")
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

                    b.Property<int>("CreacionId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaModif")
                        .HasColumnType("datetime2");

                    b.Property<int?>("InscripcionId")
                        .HasColumnType("int");

                    b.Property<int>("ModificacionId")
                        .HasColumnType("int");

                    b.Property<string>("NombreClase")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int?>("ProfesorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("InscripcionId");

                    b.HasIndex("ProfesorId");

                    b.ToTable("TablaEntrenamientos");
                });

            modelBuilder.Entity("Gimnasio.BD.Data.Entidades.Inscripcion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AlumnoId")
                        .HasColumnType("int");

                    b.Property<int>("CreacionId")
                        .HasColumnType("int");

                    b.Property<int>("EntrenamientoId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaModif")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaTurno")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("HoraTurno")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<int>("InscripcionId")
                        .HasColumnType("int");

                    b.Property<int>("ModificacionId")
                        .HasColumnType("int");

                    b.Property<int>("ProfesorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "EntrenamientoId", "InscripcionId" }, "InscripcionEntrenamientoId_UQ")
                        .IsUnique();

                    b.ToTable("TablaInscripciones");
                });

            modelBuilder.Entity("Gimnasio.BD.Data.Entidades.Profesor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CreacionId")
                        .HasColumnType("int");

                    b.Property<string>("DNI")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<DateTime?>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaModif")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImagenPerfil")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ModificacionId")
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

                    b.HasIndex(new[] { "DNI" }, "ProfesorDNI_UQ")
                        .IsUnique();

                    b.ToTable("TablaProfesores");
                });

            modelBuilder.Entity("InscripcionProfesor", b =>
                {
                    b.Property<int>("ListaInscripcionId")
                        .HasColumnType("int");

                    b.Property<int>("ListaProfesorId")
                        .HasColumnType("int");

                    b.HasKey("ListaInscripcionId", "ListaProfesorId");

                    b.HasIndex("ListaProfesorId");

                    b.ToTable("InscripcionProfesor");
                });

            modelBuilder.Entity("AlumnoInscripcion", b =>
                {
                    b.HasOne("Gimnasio.BD.Data.Entidades.Alumno", null)
                        .WithMany()
                        .HasForeignKey("ListaAlumnoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gimnasio.BD.Data.Entidades.Inscripcion", null)
                        .WithMany()
                        .HasForeignKey("ListaInscripcionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Gimnasio.BD.Data.Entidades.Entrenamiento", b =>
                {
                    b.HasOne("Gimnasio.BD.Data.Entidades.Inscripcion", null)
                        .WithMany("ListaEntrenamiento")
                        .HasForeignKey("InscripcionId");

                    b.HasOne("Gimnasio.BD.Data.Entidades.Profesor", null)
                        .WithMany("ListaEntrenamiento")
                        .HasForeignKey("ProfesorId");
                });

            modelBuilder.Entity("InscripcionProfesor", b =>
                {
                    b.HasOne("Gimnasio.BD.Data.Entidades.Inscripcion", null)
                        .WithMany()
                        .HasForeignKey("ListaInscripcionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gimnasio.BD.Data.Entidades.Profesor", null)
                        .WithMany()
                        .HasForeignKey("ListaProfesorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Gimnasio.BD.Data.Entidades.Inscripcion", b =>
                {
                    b.Navigation("ListaEntrenamiento");
                });

            modelBuilder.Entity("Gimnasio.BD.Data.Entidades.Profesor", b =>
                {
                    b.Navigation("ListaEntrenamiento");
                });
#pragma warning restore 612, 618
        }
    }
}
