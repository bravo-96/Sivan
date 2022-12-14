using AutoMapper;
using Sivan.Models.DTO;
using Sivan.Models.Entities;

namespace Sivan.Models.Profiles
{
    public class OrdenItemProfile : Profile
    {

        public OrdenItemProfile()
        {
            CreateMap<OrdenItem, OrdenItemDTO>()
                           .ForMember(destino => destino.Id, option => option.MapFrom(origen => origen.Id))
                           .ForMember(destino => destino.OrdenId, option => option.MapFrom(origen => origen.OrdenId))
                           .ForMember(destino => destino.ProductoId, option => option.MapFrom(origen => origen.ProductoId))
                           .ForMember(destino => destino.Cantidad, option => option.MapFrom(origen => origen.Cantidad))
                           .ForMember(destino => destino.FechaCreacion, option => option.MapFrom(origen => origen.FechaCreacion))
                           .ForMember(destino => destino.FechaModificacion, option => option.MapFrom(origen => origen.FechaModificacion))
                           .ReverseMap();
        }


    }
}
