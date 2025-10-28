using System.ComponentModel.DataAnnotations;

namespace StockWebAPI.Entities
{
    public class Movimiento
    {
        [Key]
        public Guid MovimientoId { get; set; }
        public Guid StockId { get; set; }
        public DateTime FechaMovimiento { get; set; }
        public Guid TipoMovimientoId { get; set; }
        public decimal PrecioUnitario { get; set; }
        public Guid? UbicOrigenId { get; set; }
        public Guid? UbicDestinoId { get; set; }
        public Guid? CentroProveedorId { get; set; }
        public Guid? CentroClienteId { get; set; }
        public Guid UsuarioId { get; set; }
        public string? NumIncidencia { get; set; }
        public Boolean Activo { get; set; }

    }
}
