using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.BD.Data.Entidades
{
    public class Entrenamiento : EntityBase
    {
        [Required]
        public int ProfesorId { get; set; }
        [Required]
        [MaxLength(10, ErrorMessage = "El Nombre no debe superar los {1} caracteres")]
        public string NombreClase { get; set; }

     


    }
}
