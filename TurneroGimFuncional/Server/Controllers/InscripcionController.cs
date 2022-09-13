using Gimnasio.BD.Data;
using Gimnasio.BD.Data.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace TurneroGimFuncional.Server.Controllers
{
    [ApiController]
    [Route("api/Alumnos")]
    public class InscripcionController : ControllerBase
    {
        private readonly BDContext context;
        public InscripcionController(BDContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Alumno>>>Get()
        {
            return await context.TablaAlumnos.ToListAsync();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Alumno>> Get(int id)
        {

            var alumno = await context.TablaAlumnos.Where(Al => Al.Id == id).FirstOrDefaultAsync();

            if (alumno == null)
            {
                return NotFound($"No existe el Id del Alumno={id}");
            }
            return alumno;
        }


    }
}
