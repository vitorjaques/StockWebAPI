using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class CreacionBBDDytablas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Almacenes",
                columns: table => new
                {
                    AlmacenId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Almacenes", x => x.AlmacenId);
                });

            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    CategoriaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.CategoriaId);
                });

            migrationBuilder.CreateTable(
                name: "Centros",
                columns: table => new
                {
                    CentroId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NegocioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CentroNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cliente = table.Column<bool>(type: "bit", nullable: true),
                    Proveedor = table.Column<bool>(type: "bit", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Activo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Centros", x => x.CentroId);
                });

            migrationBuilder.CreateTable(
                name: "Movimientos",
                columns: table => new
                {
                    MovimientoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StockId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FechaMovimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TipoMovimientoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PrecioUnitario = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UbicOrigenId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UbicDestinoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CentroProveedorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CentroClienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UsuarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NumIncidencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Activo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movimientos", x => x.MovimientoId);
                });

            migrationBuilder.CreateTable(
                name: "Negocios",
                columns: table => new
                {
                    NegocioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NombreNegocio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NIF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Negocios", x => x.NegocioId);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    ProductoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoriaID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImagenURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Activo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.ProductoId);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                columns: table => new
                {
                    StockId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UbicacionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    NumeroSerie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaIngreso = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaBaja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.StockId);
                });

            migrationBuilder.CreateTable(
                name: "TiposMovimiento",
                columns: table => new
                {
                    TipoMovimientoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NombreMovimiento = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposMovimiento", x => x.TipoMovimientoId);
                });

            migrationBuilder.CreateTable(
                name: "Ubicaciones",
                columns: table => new
                {
                    UbicacionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ZonaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CodigoUbicacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CapacidadMaxima = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ubicaciones", x => x.UbicacionId);
                });

            migrationBuilder.CreateTable(
                name: "Zonas",
                columns: table => new
                {
                    ZonaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AlmacenId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Activo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zonas", x => x.ZonaId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Almacenes");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Centros");

            migrationBuilder.DropTable(
                name: "Movimientos");

            migrationBuilder.DropTable(
                name: "Negocios");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Stocks");

            migrationBuilder.DropTable(
                name: "TiposMovimiento");

            migrationBuilder.DropTable(
                name: "Ubicaciones");

            migrationBuilder.DropTable(
                name: "Zonas");
        }
    }
}
