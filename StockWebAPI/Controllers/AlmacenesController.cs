using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StockWebAPI.Data;
using StockWebAPI.Dtos;
using StockWebAPI.Entities;

namespace StockWebAPI.Controllers
{
    [ApiController]
    [Route("api/almacenes")]
    public class AlmacenesController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public AlmacenesController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }


        [HttpGet]
        public async Task<IEnumerable<Almacen>> GetAlmacenes()
        {
            var almacenes = await context.Almacenes.ToListAsync();
            return almacenes;
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<Almacen>> GetAlmacenById(Guid id)
        {
            var almacen = await context.Almacenes.FirstOrDefaultAsync(x => x.AlmacenId == id);
            if (almacen == null)
            {
                return NotFound();
            }
            return Ok(almacen);
        }

        [HttpPost]
        public async Task<ActionResult> CreateAlmacen([FromBody] CreateAlmacenDTO createAlmacenDTO)
        {

            var almacen = mapper.Map<Almacen>(createAlmacenDTO);

            almacen.AlmacenId = Guid.NewGuid();
            almacen.Activo = true;

            context.Almacenes.Add(almacen);
            await context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetAlmacenById), new { id = almacen.AlmacenId }, almacen);
        }

        [HttpPut("{id:guid}")]
        public async Task<ActionResult> UpdateAlmacen(Guid id, [FromBody] Almacen almacen)
        {
            var almacenExistente = await context.Almacenes.FirstOrDefaultAsync(x => x.AlmacenId == id);
            if (almacenExistente == null)
            {
                return NotFound();
            }
            almacenExistente.Nombre = almacen.Nombre;
            almacenExistente.Activo = almacen.Activo;
            await context.SaveChangesAsync();
            return NoContent();
        }
        [HttpDelete("{id:guid}")]
        public async Task<ActionResult> DeleteAlmacen(Guid id)
        {
            var almacenExistente = await context.Almacenes.FirstOrDefaultAsync(x => x.AlmacenId == id);
            if (almacenExistente == null)
            {
                return NotFound();
            }
            almacenExistente.Activo = false;
            await context.SaveChangesAsync();
            return NoContent();
        }

    }
}
