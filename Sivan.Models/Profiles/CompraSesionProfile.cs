using AutoMapper;
using Sivan.Models.DTO;
using Sivan.Models.Entities;

namespace Sivan.Models.Profiles
{
    public class CompraSesionProfile : Profile
    {

        public CompraSesionProfile()
        {
            CreateMap<CompraSesion, CompraSesionDTO>()
                           .ForMember(destino => destino.Id, option => option.MapFrom(origen => origen.Id))
                           .ForMember(destino => destino.UsuarioId, option => option.MapFrom(origen => origen.UsuarioId))
                           .ForMember(destino => destino.Total, option => option.MapFrom(origen => origen.Total))
                           .ForMember(destino => destino.FechaCreacion, option => option.MapFrom(origen => origen.FechaCreacion))
                           .ForMember(destino => destino.FechaModificacion, option => option.MapFrom(origen => origen.FechaModificacion))
                           .ReverseMap();
        }
    }
}

