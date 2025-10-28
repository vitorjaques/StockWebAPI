using System.ComponentModel.DataAnnotations;

namespace StockWebAPI.Entities
{
    public class Stock
    {
        [Key]
        public Guid StockId { get; set; }
        public Guid ProductId { get; set; }
        public Guid UbicacionId { get; set; }
        public int Cantidad { get; set; }
        public required string NumeroSerie { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaBaja { get; set; }
        public Boolean Activo { get; set; } = true;
    }
}
