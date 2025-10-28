using System.ComponentModel.DataAnnotations;

namespace StockWebAPI.Entities
{
    public class Negocio
    {
        [Key]
        public Guid NegocioId { get; set; }
        public  required string NombreNegocio { get; set; } 
        public required string NIF { get; set; }
        public Boolean Activo { get; set; } 
    }
}
