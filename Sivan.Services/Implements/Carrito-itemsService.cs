using AutoMapper;
using Sivan.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sivan.Services.Implements
{
   public class Carrito_itemsService : ICarrito_itemsService
    {
        private readonly IMapper _mapper;
        private readonly ICarrito_itemsService _Carrito_ItemsService;

    }
}
