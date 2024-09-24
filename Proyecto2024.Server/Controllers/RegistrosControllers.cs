using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proyecto2024.BD.Data;
using Proyecto2024.BD.Data.Entity;

namespace Proyecto2024.Server.Controllers
{
    [ApiController]
    [Route("api/Registros")]
    public class RegistrosControllers : ControllerBase
    {
        private readonly Context context;

        public RegistrosControllers(Context context)
        {
            this.context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Registro>>> Get()
        { 
            return await context.Registros.ToListAsync();
        }
        [HttpGet("{id:int}")] //api/Registros/2
        public async Task<ActionResult<Registro>> Get(int id)
        {
            Registro? pepe = await context.Registros.FirstOrDefaultAsync(x => x.Id == id);
            if (pepe ==null)
            {
                return NotFound();
            }
            return pepe;
        }

        [HttpGet("cod")] //api/Registro/2
        public async Task<ActionResult<Registro>> GetByCod(string cod)
        {
            Registro? pepe = await context.Registros.FirstOrDefaultAsync(x => x.Codigo == cod);
            if (pepe == null)
            {
                return NotFound();

            }
            return pepe;
        }

        [HttpGet("existe/{id: int}")] //api/Registros/existe/2                                   
        public async Task<ActionResult<bool>>Existe(int id)
        {
           
            var existe = await context.Registros.AnyAsync(x => x.Id == id);
            return existe;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Registro entidad)
        {
            try
            {
                context.Registros.Add(entidad);
                await context.SaveChangesAsync();
                return entidad.Id;
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("{id: int}")] //api/Registro/2
        public async Task<ActionResult> Put(int id, [FromBody] Registro entidad)
        {
            if (id != entidad.Id)
            {
                return BadRequest("Datos Incorrectos");
            }
            var pepe = await context.Registros.Where(e => e.Id == id).FirstOrDefaultAsync();



            if (pepe == null)
            {
                return NotFound(" No existe el registro buscado.");
            }

            pepe.Codigo = entidad.Codigo;
            pepe.Nombre = entidad.Nombre;
            pepe.Activo = entidad.Activo;

            try
            {
                context.Registros.Update(pepe);
                await context.SaveChangesAsync();
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("(id:int)")]
        public async Task<ActionResult> Delete(int id)
        {
            var existe = await context.Registros.AnyAsync(x => x.Id == id);
            if ( !existe)
            {
                return NotFound($"El tipo de cocumento {id} no existe.");
            }
            Registro EntidadaABorrar = new Registro();
            EntidadaABorrar.Id = id;


            context.Remove(EntidadaABorrar);
            await context.SaveChangesAsync();
            return Ok();
        }
        
        

         
        

    }
}
