using System.ComponentModel.DataAnnotations;

namespace Gimnasio.BD.Data.Entidades
{
    public class Entrenamiento : EntityBase
    {

        [Required]
        public int ProfesorId { get; set; }
        public Profesor Profesor { get; set; }
        [Required]
        
        [MaxLength(10, ErrorMessage = "El Nombre no debe superar los {1} caracteres")]
        public string NombreClase { get; set; }




    }
}
