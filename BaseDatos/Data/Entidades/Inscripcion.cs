using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.BD.Data.Entidades
{
    public class Inscripcion : EntityBase
    {
        [Required]
        public int IdAlumno { get; set; }
        [Required]
        public int IdProfesor { get; set; }
        [Required]
        public int IdEntrenamiento { get; set; }
        [Required]
        public DateTime? FechaTurno { get; set; }
        [Required]
        public DateTime? HoraTurno { get; set; }

    }
}
