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
        [MaxLength(30, ErrorMessage = "El Nombre no debe superar los {1} caracteres")]
        public string NombreClase { get; set; }
    }
}
