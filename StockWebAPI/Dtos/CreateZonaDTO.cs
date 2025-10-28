namespace StockWebAPI.Dtos
{
    public class CreateZonaDTO
    {
        public Guid AlmacenId { get; set; }
        public required string Nombre { get; set; }
        public string? Descripcion { get; set; } 
    }
}
