using AutoMapper;
using Sivan.Models.DTO;
using Sivan.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sivan.Models.Profiles
{
    public class DetallePagoProfile : Profile
    {

        public DetallePagoProfile()
        {
            CreateMap<DetallePago, DetallePagoDTO>()
                           .ForMember(destino => destino.Id, option => option.MapFrom(origen => origen.Id))
                           .ForMember(destino => destino.OrdenId, option => option.MapFrom(origen => origen.OrdenId))
                           .ForMember(destino => destino.Monto, option => option.MapFrom(origen => origen.Monto))
                           .ForMember(destino => destino.Banco, option => option.MapFrom(origen => origen.Banco))
                           .ForMember(destino => destino.Estado, option => option.MapFrom(origen => origen.Estado))
                           .ForMember(destino => destino.FechaCreacion, option => option.MapFrom(origen => origen.FechaCreacion))
                           .ForMember(destino => destino.FechaModificacion, option => option.MapFrom(origen => origen.FechaModificacion))
                           .ReverseMap();
        }
    }
}

