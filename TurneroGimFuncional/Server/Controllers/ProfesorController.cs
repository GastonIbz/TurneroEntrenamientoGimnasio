using Gimnasio.BD.Data;
using Gimnasio.BD.Data.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace TurneroGimFuncional.Server.Controllers
{
    [ApiController]
    [Route("api/Profesores")]
    public class ProfesorController : ControllerBase
    {
        private readonly BDContext context;
        public ProfesorController(BDContext context)
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

            var profesor = await context.TablaProfesores.Where(Al => Al.Id == id).Include(ins => ins.ListaEntrenamiento).FirstOrDefaultAsync();

            if (profesor == null)
            {
                return NotFound($"No existe el Id del Profesor={id}");
            }
            return profesor;
        }
        [HttpPost]
        public async Task<ActionResult<Profesor>> Post(Profesor profesor)
        {
            try
            {
                context.TablaProfesores.Add(profesor);
                await context.SaveChangesAsync();
                return profesor;
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
    


