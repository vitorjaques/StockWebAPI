using System.ComponentModel.DataAnnotations;

namespace StockWebAPI.Entities
{
    public class Zona
    {
        [Key]
        public Guid ZonaId { get; set; } 
        public Guid AlmacenId { get; set; }
        public required string Nombre { get; set; }
        public string? Descripcion { get; set; } 
        public Boolean Activo { get; set; }

    }
}
