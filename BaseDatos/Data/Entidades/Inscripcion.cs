using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.BD.Data.Entidades
{

    [Index(nameof(EntrenamientoId),nameof(InscripcionId), Name = "InscripcionEntrenamientoId_UQ", IsUnique = true)]
    public class Inscripcion : EntityBase
    {
        [Required]
        public int AlumnoId { get; set; }
     
        [Required]
        public int EntrenamientoId { get; set; }
        [Required]
        public int InscripcionId { get; set; }
        public DateTime? FechaTurno { get; set; }
        [Required]
        public DateTime? HoraTurno { get; set; }

   

        public List<Alumno> ListaAlumno { get; set; }
        public List<Profesor> ListaProfesor { get; set; }
      
        public List<Entrenamiento> ListaEntrenamiento { get; set; }
    }
}
