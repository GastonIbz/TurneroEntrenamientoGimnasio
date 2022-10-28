using Gimnasio.BD.Data;
using Gimnasio.BD.Data.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace TurneroGimFuncional.Server.Controllers
{
    [ApiController]
    [Route("api/Inscripcion")]
    public class InscripcionController : ControllerBase
    {
        private readonly BDContext context;
        public InscripcionController(BDContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Inscripcion>>> Get()
        {
            var resp = await context.TablaInscripciones.ToListAsync();
            return resp;
        }

        [HttpPost]
        public async Task<ActionResult<Inscripcion>> Post(Inscripcion inscripcion)
        {
            try
            {
                context.TablaInscripciones.Add(inscripcion);
                await context.SaveChangesAsync();
                return inscripcion;
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            var datos = context.TablaInscripciones.Where(x => x.Id == id).FirstOrDefault();

            if (datos == null)
            {
                return NotFound($"El registro {id} no fue encontrado");
            }
            try
            {
                context.TablaInscripciones.Remove(datos);
                context.SaveChanges();
                return Ok($"El registro de {datos.InscripcionId} ha sido borrado.");
            }
            catch (Exception e)
            {
                return BadRequest($"Los datos no pudieron eliminarse por:{e.Message}");
            }
        }
        [HttpPut("{id:int}")]

        public ActionResult Put(int id, [FromBody] Inscripcion inscripcion)
        {
            if (id != inscripcion.Id)
            {
                return BadRequest("Los datos son incorrectos");
            }
            var datos = context.TablaInscripciones.Where(Al => Al.Id == id).FirstOrDefault();
            if (datos == null)
            {
                return NotFound("No existe la inscripción a modificar");
            }

            datos.AlumnoId = inscripcion.AlumnoId;
            datos.EntrenamientoId = inscripcion.EntrenamientoId;
            datos.FechaTurno = inscripcion.FechaTurno;
            datos.HoraTurno = inscripcion.HoraTurno;

            try
            {
                context.TablaInscripciones.Update(datos);
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
