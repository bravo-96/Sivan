using AutoMapper;
using Sivan.Models.DTO;
using Sivan.Models.Entities;

namespace Sivan.Models.Profiles
{
    public class ProductoCategoriaProfile : Profile
    {

        public ProductoCategoriaProfile()
        {
            CreateMap<ProductoCategoria, ProductoCategoriaDTO>()
                           .ForMember(destino => destino.Id, option => option.MapFrom(origen => origen.Id))
                           .ForMember(destino => destino.Nombre, option => option.MapFrom(origen => origen.Nombre))
                           .ForMember(destino => destino.FechaCreacion, option => option.MapFrom(origen => origen.FechaCreacion))
                           .ForMember(destino => destino.FechaModificacion, option => option.MapFrom(origen => origen.FechaModificacion))
                           .ForMember(destino => destino.FechaEliminado, option => option.MapFrom(origen => origen.FechaEliminado))

                           .ReverseMap();
        }

    }
}
