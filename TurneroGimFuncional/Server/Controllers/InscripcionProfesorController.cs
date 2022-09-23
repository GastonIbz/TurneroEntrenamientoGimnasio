using Gimnasio.BD.Data;
using Gimnasio.BD.Data.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace TurneroGimFuncional.Server.Controllers
{
    [ApiController]
    [Route("api/Profesores")]
    public class InscripcionProfesorController : ControllerBase
    {
        private readonly BDContext context;
        public InscripcionProfesorController(BDContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Profesor>>> Get()
        {
            return await context.TablaProfesores.ToListAsync();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Profesor>> Get(int id)
        {

            var profesor = await context.TablaProfesores.Where(Al => Al.Id == id).Include(ins => ins.ListaInscripcion).FirstOrDefaultAsync();

            if (profesor == null)
            {
                return NotFound($"No existe el Id del Profesor={id}");
            }
            return profesor;
        }
    }
}


