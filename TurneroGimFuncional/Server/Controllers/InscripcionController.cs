using Gimnasio.BD.Data;
using Gimnasio.BD.Data.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace TurneroGimFuncional.Server.Controllers
{
    [ApiController]
    [Route("api/Alumnos")]
    public class AlumnosController : ControllerBase
    {
        private readonly BDContext context;
        public AlumnosController(BDContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Alumno>>> Get()
        {
            return await context.TablaAlumnos.ToListAsync();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Alumno>> Get(int id)
        {

            var alumno = await context.TablaAlumnos.Where(Al => Al.Id == id).Include(ins => ins.ListaInscripcion).FirstOrDefaultAsync();

            if (alumno == null)
            {
                return NotFound($"No existe el Id del Alumno={id}");
            }
            return alumno;
        }



        [HttpPost]
        public async Task<ActionResult<int>> Post(Entrenamiento entrenamiento)
        {
            try
            {
                context.TablaEntrenamientos.Add(entrenamiento);
                await context.SaveChangesAsync();
                return entrenamiento.Id;

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}

