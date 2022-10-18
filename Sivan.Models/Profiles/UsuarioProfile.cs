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
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<Usuario, UsuarioDTO>()
                           .ForMember(destino => destino.Id, option => option.MapFrom(origen => origen.Id))
                           .ForMember(destino => destino.NombreUsuario, option => option.MapFrom(origen => origen.NombreUsuario))
                           .ForMember(destino => destino.Contraseña, option => option.MapFrom(origen => origen.Contraseña))
                           .ForMember(destino => destino.Nombre, option => option.MapFrom(origen => origen.Nombre))
                           .ForMember(destino => destino.Apellido, option => option.MapFrom(origen => origen.Apellido))
                           .ForMember(destino => destino.Telefono, option => option.MapFrom(origen => origen.Telefono))
                           .ForMember(destino => destino.FechaCreacion, option => option.MapFrom(origen => origen.FechaCreacion))
                           .ForMember(destino => destino.FechaModificacion, option => option.MapFrom(origen => origen.FechaModificacion))
                           .ReverseMap();
        }
    }
}


