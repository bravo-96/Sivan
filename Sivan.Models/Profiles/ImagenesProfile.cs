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
    public class ImagenesProfile : Profile
    {

        public ImagenesProfile()
        {
            CreateMap<Imagenes, ImagenesDTO>()
                           .ForMember(destino => destino.Id, option => option.MapFrom(origen => origen.Id))
                           .ForMember(destino => destino.ProductoId, option => option.MapFrom(origen => origen.ProductoId))
                           .ForMember(destino => destino.URL, option => option.MapFrom(origen => origen.URL))
                           .ReverseMap();
        }

    }
}
