using System.ComponentModel.DataAnnotations;

namespace StockWebAPI.Entities
{
    public class TipoMovimiento
    {
        [Key]
        public Guid TipoMovimientoId { get; set; }
        public required string NombreMovimiento { get; set; }
    }
}
