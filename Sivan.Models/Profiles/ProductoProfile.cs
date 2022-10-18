using AutoMapper;
using Sivan.Models.DTO;
using Sivan.Models.Entities;

namespace Sivan.Models.Profiles
{
    public class ProductoProfile : Profile
    {
        public ProductoProfile()
        {
            CreateMap<Producto, ProductoDTO>()
                           .ForMember(destino => destino.Id, option => option.MapFrom(origen => origen.Id))
                           .ForMember(destino => destino.Nombre, option => option.MapFrom(origen => origen.Nombre))
                           .ForMember(destino => destino.Descripcion, option => option.MapFrom(origen => origen.Descripcion))
                           .ForMember(destino => destino.Coleccion, option => option.MapFrom(origen => origen.Coleccion))
                           .ForMember(destino => destino.Marca_Id, option => option.MapFrom(origen => origen.Marca_Id))
                           .ForMember(destino => destino.Sku, option => option.MapFrom(origen => origen.Sku))
                           .ForMember(destino => destino.ProductoCategoriaId, option => option.MapFrom(origen => origen.ProductoCategoriaId))
                           .ForMember(destino => destino.ProductoInventarioId, option => option.MapFrom(origen => origen.ProductoInventarioId))
                           .ForMember(destino => destino.Precio, option => option.MapFrom(origen => origen.Precio))
                           .ForMember(destino => destino.PrecioDescuento, option => option.MapFrom(origen => origen.PrecioDescuento))
                           .ForMember(destino => destino.DescuentoId, option => option.MapFrom(origen => origen.DescuentoId))
                           .ForMember(destino => destino.FechaCreacion, option => option.MapFrom(origen => origen.FechaCreacion))
                           .ForMember(destino => destino.FechaModificacion, option => option.MapFrom(origen => origen.FechaModificacion))
                           .ForMember(destino => destino.FechaEliminado, option => option.MapFrom(origen => origen.FechaEliminado))
                           .ReverseMap();
        }
    }
}
