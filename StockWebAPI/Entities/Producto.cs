using System.ComponentModel.DataAnnotations;

namespace StockWebAPI.Entities
{
    public class Producto
    {
        [Key]
        public Guid ProductoId { get; set; }
        public required string Nombre { get; set; }
        public Guid CategoriaID { get; set; }
        public string? ImagenURL { get; set; }
        public Boolean Activo { get; set; }
    }
}
