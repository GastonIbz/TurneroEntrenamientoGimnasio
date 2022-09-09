using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.BD.Data.Entidades
{
    public class EntityBase
    {
        public int Id { get; set; }

        public int IdCreacion { get; set; }
    
        public DateTime? FechaCreacion { get; set; }

        public int IdModificacion { get; set; }
        public DateTime? FechaModif { get; set; }

    }
}
