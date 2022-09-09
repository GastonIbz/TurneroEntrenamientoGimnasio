using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.BD.Data.Entidades
{
    [Index(nameof(DNI), Name = "AlumnoDNI_UQ", IsUnique = true)]
    public class Alumno : EntityBase
    {
        [Required(ErrorMessage = "El DNI de la Persona es obligatorio.")]

        [MaxLength(8, ErrorMessage = "El DNI no debe superar los {1} caracteres")]
        public string DNI { get; set; }

        [Required]
        [MaxLength(12, ErrorMessage = "La contraseña no es valida, no debe superar los {1} caracteres")]
        public string Password { get; set; }

        [Required(ErrorMessage = "El Nombre de la Persona es obligatorio.")]
        [MaxLength(30, ErrorMessage = "El nombre no es valido, no debe superar los {1} caracteres")]
        public string NombreCompleto { get; set; }

        public string ImagenPerfil { get; set; }
    }
}

