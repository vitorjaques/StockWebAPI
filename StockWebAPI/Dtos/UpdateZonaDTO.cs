namespace StockWebAPI.Dtos
{
    public class UpdateZonaDTO
    {
        public required string Nombre { get; set; }
        public string? Descripcion { get; set; } 
        public Boolean Activo { get; set; }
    }
}
