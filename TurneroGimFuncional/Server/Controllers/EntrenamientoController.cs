using Gimnasio.BD.Data;
using Gimnasio.BD.Data.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace TurneroGimFuncional.Server.Controllers
{
    [ApiController]
    [Route("api/Entrenamientos")]
    public class EntrenamientoController : ControllerBase
    {
        private readonly BDContext context;
        public EntrenamientoController(BDContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Entrenamiento>>> Get()
        {
            return await context.TablaEntrenamientos.ToListAsync();
        }

        }
    }

    


