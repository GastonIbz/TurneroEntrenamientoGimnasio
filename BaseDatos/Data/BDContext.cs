
using Gimnasio.BD.Data.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.BD.Data
{
    public class BDContext : DbContext
    {
        public DbSet <Alumno> TablaAlumnos { get; set; }

        public DbSet<Profesor> TablaProfesores { get; set; }
        public DbSet<Entrenamiento> TablaEntrenamientos { get; set; }
        public DbSet<Inscripcion> TablaInscripciones { get; set; }
        public BDContext ()
        { }
        public BDContext(DbContextOptions<BDContext> options) : base(options)
        {
        }
    }
}
