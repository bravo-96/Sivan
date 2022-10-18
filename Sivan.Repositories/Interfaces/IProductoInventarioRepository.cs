using Sivan.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sivan.Repositories.Interfaces
{
    public interface IProductoInventarioRepository
    {
        Task<ProductoInventario> Insert(ProductoInventario model);
        Task<ProductoInventario> Update(ProductoInventario model);
        Task Delete(int id);
        Task<IEnumerable<ProductoInventario>> GetAll();
        Task<ProductoInventario> GetById(int id);
    }
}
