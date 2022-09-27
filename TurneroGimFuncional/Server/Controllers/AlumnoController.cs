using Gimnasio.BD.Data;
using Gimnasio.BD.Data.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace TurneroGimFuncional.Server.Controllers
{
    [ApiController]
    [Route("api/Alumno")]
    public class AlumnoController : ControllerBase
    {
        private readonly BDContext context;
        public AlumnoController(BDContext context)
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
        public async Task<ActionResult<Alumno>> Post(Alumno alumno)
        {
            try
            {
                context.TablaAlumnos.Add(alumno);
                await context.SaveChangesAsync();
                return alumno;
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

          


        }

        [HttpPut("{id:int}")]

        public ActionResult Put(int id, [FromBody] Alumno alumno)
        {
            if (id != alumno.Id)
            {
                return BadRequest("Los datos son incorrectos");
            }
            var datos = context.TablaAlumnos.Where(Al => Al.Id == id).FirstOrDefault();
            if (datos == null)
            {
                return NotFound("No existe el alumno a modificar");
            }

            datos.DNI = alumno.DNI;
            datos.NombreCompleto = alumno.NombreCompleto;
            datos.Password = alumno.Password;

            try
            {
                context.TablaAlumnos.Update(datos);
                context.SaveChanges();
                return Ok();
            }
            catch (Exception Al)
            {

                return BadRequest($"Los datos no fueron actualizados por: {Al.Message}");
            }
        }
    }
    }
