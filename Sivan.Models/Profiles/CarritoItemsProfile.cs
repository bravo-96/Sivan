using AutoMapper;
using Sivan.Models.DTO;
using Sivan.Models.Entities;

namespace Sivan.Models.Profiles
{
    public class CarritoItemsProfile : Profile
    {
        public CarritoItemsProfile()
        {
            CreateMap<CarritoItem, CarritoItemsDTO>()
                           .ForMember(destino => destino.Id, option => option.MapFrom(origen => origen.Id))
                           .ForMember(destino => destino.SesionId, option => option.MapFrom(origen => origen.SesionId))
                           .ForMember(destino => destino.ProductoId, option => option.MapFrom(origen => origen.ProductoId))
                           .ForMember(destino => destino.Cantidad, option => option.MapFrom(origen => origen.Cantidad))
                           .ForMember(destino => destino.FechaCreacion, option => option.MapFrom(origen => origen.FechaCreacion))
                           .ForMember(destino => destino.FechaModificacion, option => option.MapFrom(origen => origen.FechaModificacion))
                           .ReverseMap();
        }
    }
}
