using System.ComponentModel.DataAnnotations;

namespace StockWebAPI.Entities
{
    public class Ubicacion
    {
        [Key]
        public Guid UbicacionId { get; set; }
        public Guid ZonaId { get; set; }
        public required string CodigoUbicacion { get; set; }
        public decimal CapacidadMaxima { get; set; }

    }
}
