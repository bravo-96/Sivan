using AutoMapper;
using Sivan.Models.DTO;
using Sivan.Models.Entities;

namespace Sivan.Models.Profiles
{
    public class UsuarioDireccionProfile : Profile
    {
        public UsuarioDireccionProfile()
        {
            CreateMap<UsuarioDireccion, UsuarioDireccionDTO>()
                       .ForMember(destino => destino.Id, option => option.MapFrom(origen => origen.Id))
                       .ForMember(destino => destino.UsuarioId, option => option.MapFrom(origen => origen.UsuarioId))
                       .ForMember(destino => destino.Direccion, option => option.MapFrom(origen => origen.Direccion))
                       .ForMember(destino => destino.Ciudad, option => option.MapFrom(origen => origen.Ciudad))
                       .ForMember(destino => destino.CodigoPostal, option => option.MapFrom(origen => origen.CodigoPostal))
                       .ForMember(destino => destino.Pais, option => option.MapFrom(origen => origen.Pais))
                       .ForMember(destino => destino.Telefono, option => option.MapFrom(origen => origen.Telefono))
                       .ReverseMap();
        }
    }
}
