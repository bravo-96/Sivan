﻿using AutoMapper;
using Sivan.Models.DTO;
using Sivan.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sivan.Models.Profiles
{
    public class MarcaProfile : Profile
    {
        public MarcaProfile()
        {
            CreateMap<Marca, MarcaDTO>()
                           .ForMember(destino => destino.Id, option => option.MapFrom(origen => origen.Id))
                           .ForMember(destino => destino.Nombre, option => option.MapFrom(origen => origen.Nombre))
                           .ForMember(destino => destino.ImagenUrl, option => option.MapFrom(origen => origen.ImagenUrl))
                           .ReverseMap();
        }
    }
}
