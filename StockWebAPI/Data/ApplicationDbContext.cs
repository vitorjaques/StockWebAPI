using Microsoft.EntityFrameworkCore;
using StockWebAPI.Entities;

namespace StockWebAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Almacen> Almacenes { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Ubicacion> Ubicaciones { get; set; }
        public DbSet<Zona> Zonas { get; set; }
        public DbSet<Negocio> Negocios { get; set; }
        public DbSet<Centro> Centros { get; set; }
        public DbSet<Movimiento> Movimientos { get; set; }
        public DbSet<TipoMovimiento> TiposMovimiento { get; set; }
 
        

    }
}
