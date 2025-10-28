using AutoMapper;
using StockWebAPI.Dtos;
using StockWebAPI.Entities;

namespace StockWebAPI.Utilities
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            //Alamcen
            CreateMap<CreateAlmacenDTO, Almacen>();
            CreateMap<UpdateAlmacenDTO, Almacen>();

            //Zona
            CreateMap<CreateZonaDTO, Zona>();
        }
    }
}
