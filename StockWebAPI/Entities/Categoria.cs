using System.ComponentModel.DataAnnotations;

namespace StockWebAPI.Entities
{
    public class Categoria
    {
        [Key]
        public Guid CategoriaId { get; set; }
        public required string Nombre { get; set; }
    }
}
