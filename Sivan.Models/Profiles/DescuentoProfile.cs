using AutoMapper;
using Sivan.Models.DTO;

namespace Sivan.Models.Profiles
{
    public class DescuentoProfile : Profile
    {
        public DescuentoProfile()
        {
            CreateMap<DescuentoDTO, DescuentoDTO>()
                .ForMember(destino => destino.Id, option => option.MapFrom(origen => origen.Id))
                .ForMember(destino => destino.DescuentoPorcentaje, option => option.MapFrom(origen => origen.DescuentoPorcentaje))
                .ForMember(destino => destino.FechaCreacion, option => option.MapFrom(origen => origen.FechaCreacion))
                .ForMember(destino => destino.FechaModificacion, option => option.MapFrom(origen => origen.FechaModificacion))
                .ForMember(destino => destino.FechaEliminado, option => option.MapFrom(origen => origen.FechaEliminado))
                .ReverseMap();
        }
    }
}
