using AutoMapper;
using Sivan.Models.DTO;
using Sivan.Models.Entities;

namespace Sivan.Models.Profiles
{
    public class UsuarioPagosProfile : Profile
    {
        public UsuarioPagosProfile()
        {
            CreateMap<UsuarioPagos, UsuarioPagosDTO>()
                           .ForMember(destino => destino.Id, option => option.MapFrom(origen => origen.Id))
                           .ForMember(destino => destino.UsuarioId, option => option.MapFrom(origen => origen.UsuarioId))
                           .ForMember(destino => destino.TipoPago, option => option.MapFrom(origen => origen.TipoPago))
                            .ForMember(destino => destino.MontoCompra, option => option.MapFrom(origen => origen.MontoCompra))
                           .ForMember(destino => destino.Banco, option => option.MapFrom(origen => origen.Banco))
                           .ForMember(destino => destino.Vencimiento, option => option.MapFrom(origen => origen.Vencimiento))
                           .ReverseMap();
        }
    }
}

