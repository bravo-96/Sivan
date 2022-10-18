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
    public class Carrito_itemsProfile : Profile
    {
        public Carrito_itemsProfile()
        {
         CreateMap<Carrito_items, Carrito_itemsDTO>()
                        .ForMember(destino => destino.Id, option => option.MapFrom(origen => origen.Id))
                        .ForMember(destino => destino.SesionId, option => option.MapFrom(origen => origen.SesionId))
                        .ForMember(destino => destino.ProductoId, option => option.MapFrom(origen => origen.ProductoId))
                        .ForMember(destino => destino.Cantidad, option => option.MapFrom(origen => origen.Cantidad))
                        .ForMember(destino => destino.FechaCreacion, option => option.MapFrom(origen => origen.FechaCreacion))
                        .ForMember(destino => destino.FechaModificacion, option => option.MapFrom(origen => origen.FechaModificacion))
                        .ReverseMap();
        }
    }
}