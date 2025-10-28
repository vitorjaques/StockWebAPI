using System.ComponentModel.DataAnnotations;

namespace StockWebAPI.Entities
{
    public class Almacen
    {
        [Key]
        public Guid AlmacenId { get; set; }
        public required string Nombre { get; set; }
        public Boolean Activo { get; set; }
        public List<Zona> Zonas { get; set; } = [];

    }
}
