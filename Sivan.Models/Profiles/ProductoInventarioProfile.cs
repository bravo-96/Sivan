using AutoMapper;
using Sivan.Models.DTO;
using Sivan.Models.Entities;

namespace Sivan.Models.Profiles
{
    public class ProductoInventarioProfile : Profile
    {

        public ProductoInventarioProfile()
        {
            CreateMap<ProductoInventario, ProductoInventarioDTO>()
                           .ForMember(destino => destino.Id, option => option.MapFrom(origen => origen.Id))
                           .ForMember(destino => destino.Cantidad, option => option.MapFrom(origen => origen.Cantidad))
                           .ForMember(destino => destino.FechaCreacion, option => option.MapFrom(origen => origen.FechaCreacion))
                           .ForMember(destino => destino.FechaModificacion, option => option.MapFrom(origen => origen.FechaModificacion))
                           .ForMember(destino => destino.FechaEliminado, option => option.MapFrom(origen => origen.FechaEliminado))

                           .ReverseMap();
        }

    }
}
