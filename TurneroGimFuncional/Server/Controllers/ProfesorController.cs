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
        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            var datos = context.TablaProfesores.Where(x => x.Id == id).FirstOrDefault();

            if (datos == null)
            {
                return NotFound($"El registro {id} no fue encontrado");
            }
            try
            {
                context.TablaProfesores.Remove(datos);
                context.SaveChanges();
                return Ok($"El registro de {datos.DNI} ha sido borrado.");
            }
            catch (Exception e)
            {
                return BadRequest($"Los datos no pudieron eliminarse por:{e.Message}");
            }
        }
        [HttpPut("{id:int}")]

        public ActionResult Put(int id, [FromBody] Profesor profesor)
        {
            if (id != profesor.Id)
            {
                return BadRequest("Los datos son incorrectos");
            }
            var datos = context.TablaProfesores.Where(Al => Al.Id == id).FirstOrDefault();
            if (datos == null)
            {
                return NotFound("No existe el profesor a modificar");
            }

            datos.DNI = profesor.DNI;
            datos.NombreCompleto = profesor.NombreCompleto;
            datos.Password = profesor.Password;

            try
            {
                context.TablaProfesores.Update(datos);
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
    


