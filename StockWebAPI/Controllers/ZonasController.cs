using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StockWebAPI.Data;
using StockWebAPI.Dtos;
using StockWebAPI.Entities;

namespace StockWebAPI.Controllers
{
    [ApiController]
    [Route("api/zonas")]
    public class ZonasController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public ZonasController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

   

        [HttpGet("{almacenId:Guid}")]
        public async Task<ActionResult<Zona>> GetZonaByAlmacen(Guid almacenId)
        {
            var zonas = await context.Zonas.FirstOrDefaultAsync(x => x.AlmacenId == almacenId);

            if (zonas is null)
            {
                return NotFound();
            }

            return Ok(zonas);
        }

        [HttpPost]
        public async Task<ActionResult> CreateZona([FromBody] CreateZonaDTO createZonaDTO)
        {
            var almacenExistente = await context.Almacenes.FirstOrDefaultAsync(x => x.AlmacenId == createZonaDTO.AlmacenId);

            if (almacenExistente is null)
            {
                return NotFound($"El Almacen con Id {createZonaDTO.AlmacenId} no existe.");
            }

            var zona = mapper.Map<Zona>(createZonaDTO);

            zona.ZonaId = Guid.NewGuid();
            zona.Activo = true;

            if (zona.Descripcion == string.Empty)
            {
                zona.Descripcion = null;
            }

            context.Zonas.Add(zona);
            await context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetZonaByAlmacen), new { id = zona.ZonaId }, zona);
        }

        [HttpPut("{zonaId:Guid}")]
        public async Task<ActionResult> UpdateZona(Guid zonaId,[FromBody] UpdateZonaDTO updateZonaDTO)
        {
            var zonaExistente = await context.Zonas.FirstOrDefaultAsync(x => x.ZonaId == zonaId);

            if (zonaExistente == null)
            {
                return NotFound();
            }

            zonaExistente.Nombre = updateZonaDTO.Nombre;
            zonaExistente.Descripcion = updateZonaDTO.Descripcion;
            zonaExistente.Activo = updateZonaDTO.Activo;
            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{zonaId:Guid}")]
        public async Task<ActionResult> DeleteZona(Guid zonaId)
        {
            var zonaExistente = await context.Zonas.FirstOrDefaultAsync(x => x.ZonaId == zonaId);
            if (zonaExistente == null)
            {
                return NotFound();
            }
            
            zonaExistente.Activo = false;
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}
