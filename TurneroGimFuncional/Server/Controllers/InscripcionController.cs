﻿using Gimnasio.BD.Data;
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
            return await context.TablaInscripciones.ToListAsync();
        }

 
     
        }
    }
