using System.ComponentModel.DataAnnotations;

namespace StockWebAPI.Entities
{
    public class Centro
    {
        [Key]
        public Guid CentroId { get; set; }
        public Guid NegocioId { get; set; }
        public required string CentroNombre { get; set; }
        public Boolean? Cliente { get; set; }
        public Boolean? Proveedor { get; set; }
        public string? Direccion { get; set; }
        public Boolean Activo { get; set; }

    }
}
